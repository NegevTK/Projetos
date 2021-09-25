<?php
include("./conexao.php");
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="utf-8">
  <link href="/Imagem/favicon.ico" rel="shortcut icon" type="image/x-icon" />
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
  <title>Clima</title>
  <script>
    window.setInterval(function() {
      var result = '<?php echo retornaInfo() ?>';
      if (result != "") {
        document.getElementById("temperatura").innerHTML = (result.split(" | ")[0] + "<sup>ºC</sup>");
        document.getElementById("umidade").innerHTML = (result.split(" | ")[1] + "%");
        document.getElementById("data-hora").innerHTML = (result.split(" | ")[2]);
      }
    }, 1000);
  </script>
</head>

<body>
  <div class="container d-flex justify-content-center mt-5">
    <div class="column">
      <div class="row justify-content-md-center">
        <h5 id="data-hora">00/00/0000 00:00:00</h5>
      </div>
      <div class="row">
        <div class="card-group">
          <div class="card border-dark mb-3" style="max-width: 18rem;">
            <div class="text-center card-header">
              <h5>Temperatura</h5>
            </div>
            <div class="card-body text-dark">
              <img class="card-img" src="/ProjetoTemperatura/Imagem/temperature.png" alt="Card image">
            </div>
            <div class="text-center card-footer">
              <h5 class="align-middle" id="temperatura">0<sup>ºC</sup></h5>
            </div>
          </div>
          <div class="card border-dark mb-3" style="max-width: 18rem;">
            <div class="text-center card-header">
              <h5>Umidade</h5>
            </div>
            <div class="card-body text-dark">
              <img class="card-img" src="/ProjetoTemperatura/Imagem/umidade.png" alt="Card image">
            </div>
            <div class="text-center card-footer">
              <h5 class="align-middle" id="umidade">0%</h5>
            </div>
          </div>
        </div>
      </div>
    </div>

  </div>

  <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>

</html>