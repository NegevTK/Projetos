import pyttsx3
from logging import error
import mysql.connector
import serial
from datetime import datetime
arduino = serial.Serial('COM1', 9600)
voz = pyttsx3.init()
while True:
    linha = str(arduino.readline())
    valorSeparado = linha[2:-5].split(":")
    data_horas_atuais = datetime.now()
    data_horas_atuais_convertida = data_horas_atuais.strftime(
        '%d/%m/%Y %H:%M:%S')
    print('\n--------------------------------------------')
    print("Sensor: " + str(valorSeparado) +
          "\nData/Hora Atuais: " + data_horas_atuais_convertida)
    try:
        connection = mysql.connector.connect(host='localhost',
                                             database='sensor_dados',
                                             user='root',
                                             password='')
        cursor = connection.cursor()
        cursor.execute("SELECT * FROM clima WHERE idClima = 1")
        myselect = cursor.fetchall()
        if(len(myselect) > 0):
            cursor.execute(
                "UPDATE clima SET valorTemperatura = " + valorSeparado[0] + ", valorUmidade = " + valorSeparado[1] + ", dataColeta = '" + data_horas_atuais_convertida + "' WHERE idClima = 1 ")
            connection.commit()
            print(cursor.rowcount, "Dados Atualizados!")
        else:
            cursor.execute("INSERT INTO clima (valorTemperatura, valorUmidade, dataColeta) VALUES (" +
                           valorSeparado[0] + ", " + valorSeparado[1] + ", '" + data_horas_atuais_convertida + "') ")
            connection.commit()
            print(cursor.rowcount, "Dado Inserido!")
            cursor.close()
        voz.say("Temperatura de " +
                valorSeparado[0].split(".")[0] + "Graus Celsius")
        voz.say("Umidade relativa do ar, equivalente a " +
                valorSeparado[1].split(".")[0] + "%")
        voz.runAndWait()
    except:
        print("Falha no Banco de Dados" + error)
    finally:
        if (connection.is_connected()):
            connection.close()
            print("Conexão Encerrada!")
