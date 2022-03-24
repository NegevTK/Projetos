<?php
function retornaInfo()
{
    $host = "localhost";
    $user = "root";
    $password = null;
    $database = "sensor_dados";
    try {
        $connect = new mysqli($host, $user, $password, $database);
        if ($connect->connect_error) {
            die("Falha na conexão: " . $connect->connect_error);
        } else {
            $valorColetado = "";
            $my_query = "SELECT valorTemperatura, valorUmidade, dataColeta FROM clima WHERE idClima=1";
            $result = $connect->query($my_query);

            if ($result->num_rows > 0) {
                while ($row = $result->fetch_assoc()) {
                    $valorColetado = $row["valorTemperatura"] . " | " . $row["valorUmidade"] . " | " . $row["dataColeta"] . "";
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
