<?php
require './conexao.php';
$sql =  $pdo->query("SELECT * FROM DATA_SENSOR ORDER BY idColeta DESC;");
if ($sql->rowCount() > 0) {
    $string = '<div class="table table-wrapper">';
    $string .= '<table class="table table-bordered table-striped mb-0 ">';
    $string .= '<thead>';
    $string .= '<tr>';
    $string .= '<th scope="col" class="text-center">Sistema Ligado</th>';
    $string .= '<th scope="col" class="text-center">Umidade do Solo (%)</th>';
    $string .= '<th scope="col" class="text-center">Umidade Ambiente (%)</th>';
    $string .= '<th scope="col" class="text-center">Temperatura Ambiente (<sup>º</sup>C)</th>';
    $string .= '<th scope="col" class="text-center">Data / Hora</th>';
    $string .= '</tr>';
    $string .= '</thead>';
    $string .= '<tbody>';
    foreach ($sql->fetchAll() as $data) {
        $json_data[] = $data;
        $string .= '<tr>';
        if($data['sistemaLigado'] == 'Sim'){
            $string .= '<td class="text-center text-success">' . $data['sistemaLigado'] . '</td>';
        }else{
            $string .= '<td class="text-center text-danger">' . $data['sistemaLigado'] . '</td>';
        }
        $string .= '<td class="text-center">' . $data['valorUmidadeSolo'] . '</td>';
        $string .= '<td class="text-center">' . $data['valorUmidade'] . '</td>';
        $string .= '<td class="text-center">' . $data['valorTemperatura'] . '</td>';
        $string .= '<td class="text-center">' . $data['dataColeta'] . '</td>';
        $string .= '</tr>';
    }
    $string .= '</tbody>';
    $string .= '</table>';
    $string .= '</div>';
    $string .= '</div>';
    echo $string.'@'.json_encode(array_reverse($json_data));
}
