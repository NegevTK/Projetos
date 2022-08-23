<!DOCTYPE html>
<html lang="pt-br">
<head>
  <meta charset="utf-8">
  <link href="/Imagem/favicon.ico" rel="shortcut icon" type="image/x-icon" />
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <script src="https://code.jquery.com/jquery-3.3.1.min.js"></script>
  <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
  <script type="text/javascript" src="//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
  <title>Irrigação</title>
  <script type="text/javascript">
    google.charts.load('current', {packages: ['corechart']});
    google.charts.setOnLoadCallback(atualizar);
    function atualizar() {
      $.ajax({
        url: "./consulta.php",
        success: function(data) {
          var data_collect = data.split("@");
          var json_data = JSON.parse(data_collect[1]);
          $('.dados').html(data_collect[0]);
          console.log(data_collect[1]);
          var dados_sensor = [['Hora', 'Umidade do Solo (%)', 'Temperatura Ambiente (°C)', 'Umidade Ambiente (%)']];
          var data = '';
          $.each(json_data, function(index, value) {
            data = value.dataColeta.split(' ')[0];
            dados_sensor.push([value.dataColeta.split(' ')[1], parseFloat(value.valorUmidadeSolo), parseFloat(value.valorTemperatura), parseFloat(value.valorUmidade)]);
          });
          var options = {
            title: 'Dados Sensor (' + data + ')',
            legend: {
              position: 'bottom',
              textStyle: {
                color: '#555',
                fontSize: 14
              }
            }
          };
          var figures = google.visualization.arrayToDataTable(dados_sensor)
          var chart = new google.visualization.LineChart(document.getElementById('chart'));
          chart.draw(figures, options);
        },
        error: function() {
          console.log("Error");
        }
      });
    }
    setInterval("atualizar()", 1000);
  </script>

  <style>
    .table-wrapper {
      max-height: 250px;
      overflow: auto;
      display: inline-block;
    }
  </style>
</head>

<body>
  <div id="chart" style="height: 400px;"></div>
  <div class="container justify-content-center mt-5">
    <div class='dados'></div>
</body>

</html>