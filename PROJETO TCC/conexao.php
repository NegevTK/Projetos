<?php
function retornaInfo()
{
    $host = "localhost";
    $user = "root";
    $password = null; 
    $database = "FEMA_DATA_SYSTEM"; 
    try {
        $connect = new mysqli($host, $user, $password, $database);
        if ($connect->connect_error) {
            die("Falha na conexão: " . $connect->connect_error);
        } else {
            $valorColetado = array();
            $my_query = "SELECT * FROM DATA_SENSOR";
            $result = $connect->query($my_query);

            if ($result->num_rows > 0) {
                while ($row = $result->fetch_assoc()) {
                    $valorColetado = $row["valorTemperatura"] . " | " . $row["valorUmidade"] . " | " . $row["valorUmidadeSolo"] . " | " . $row["sistemaLigado"] . " | " . $row["dataColeta"];
                }
            } else {
                echo "0 results";
            }
            $connect->close();
        }
    } catch (PDOException $e) {
        echo "Ocorreu um erro: $e";
    }
    return $valorColetado;
}
