from logging import error
import mysql.connector
import serial
from datetime import datetime
arduino = serial.Serial('COM3', 9600)
while True:
    try:
        data_horas_atuais_convertida = datetime.now().strftime('%d/%m/%Y %H:%M:%S')
        valorSeparado = str(arduino.readline())[2:-5].split(":")
        if(int(valorSeparado[2]) <= 70):
            sistema_ligado = "Sim"
        else:
            sistema_ligado = "Não"
        connection = mysql.connector.connect(host='localhost',database='FEMA_DATA_SYSTEM',user='root', password='')
        cursor = connection.cursor()
        insert = ("INSERT INTO DATA_SENSOR (valorTemperatura, valorUmidade, valorUmidadeSolo, sistemaLigado, dataColeta) VALUES (" 
        + str(valorSeparado[0]) + ", " + str(valorSeparado[1]) + ", " + str(valorSeparado[2]) + ", '" + sistema_ligado + "', '"
         + data_horas_atuais_convertida + "') ")
        cursor.execute("SELECT * FROM DATA_SENSOR")
        if(len(cursor.fetchall()) >= 10):
            cursor.execute("DELETE FROM DATA_SENSOR WHERE idColeta = (SELECT MIN(idColeta) FROM DATA_SENSOR) ")
            cursor.execute(insert)
            connection.commit()
            print(cursor.rowcount, "Dados Atualizados!")
        else:
            cursor.execute(insert)
            connection.commit()
            print(cursor.rowcount, "Dado Inserido!")
            cursor.close()
    except:
        print("Falha no Banco de Dados" + error)
    finally:
        if (connection.is_connected()):
            connection.close()
            print("Conexão Encerrada!")




        # print('\n--------------------------------------------')
        # print("Sensor: " + str(valorSeparado) +
        #     "\nData/Hora Atuais: " + data_horas_atuais_convertida)