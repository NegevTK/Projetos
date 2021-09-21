<?php
session_start();
if (!isset($_SESSION['Nome'])) {
    header('location:../formularios/frmTelaLogin.php');
}
    include '../metodos/conexao.php';

    if(!isset($_SESSION['Select'])){
        $pdo = Conexao::conectar();
        $sql = "SELECT * FROM produtos WHERE Quantidade > 0";
        $listaProdutos = $pdo->query($sql);
    } 
    if(isset($_SESSION['Select'])){
        $pdo = Conexao::conectar();
        $selecao = $_SESSION['Select'];
        $sql = "SELECT * FROM produtos WHERE Quantidade > 0 AND Categoria = '$selecao'";
        $listaProdutos = $pdo->query($sql);
    }
    if(isset($_SESSION['Select']) && $_SESSION['Select'] == "Esgotados"){
        $pdo = Conexao::conectar();
        $selecao = $_SESSION['Select'];
        $sql = "SELECT * FROM produtos WHERE Quantidade <=0";
        $listaProdutos = $pdo->query($sql);
    }
?>

<!DOCTYPE html>
<html lang='pt-br'>

<head>
    <title>MyMachine.com</title>
    <meta charset='utf-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1'>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link rel='shortcut icon' href='../imagens/icon_index.ico' type='image/x-icon' />
</head>

<body>

    <!-- Barra Superior -->

    <nav class="navbar navbar-expand-lg navbar-dark bg-primary">

        <div class="container">
            <a class="navbar-brand mb-0  h1" href="../formularios/index.php">Inicio</a>

            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSite">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarSite">

                <ul class="navbar-nav mr-auto h5">
                    <li class="nav-item">
                        <a class="nav-link" href="#produtos"> Produtos </a>
                    </li>
                </ul>

                <ul class="navbar-nav ml-auto h5">
                    <li class="navbar-item dropdown">
                        <a class="nav-link dropdown-toggle" data-toggle="dropdown" id="navDrop" href="#">
                            <?php echo $_SESSION['Nome'] ?>
                        </a>
                        <div class="dropdown-menu">

                            <a class="dropdown-item" href="../formularios/frmComprasRealizadas.php">Pedidos feitos</a>

                            <?php if (isset($_SESSION['Tipo'])) { ?>
                                <div class="dropdown-divider"> </div>
                                <a class="dropdown-item" href="../formularios/frmListarProdutos.php"> Gerenciar </a>
                            <?php
                            }
                            ?>

                            <div class="dropdown-divider"> </div>

                            <a class="dropdown-item label-success btn" type='button' value='Sair' onclick="JavaScript:location.href='../metodos/logout.php'">
                                Sair
                            </a>

                        </div>
                    </li>

                </ul>

            </div>

        </div>

    </nav>

    <!-- Sessão de Slides -->

    <div id="carouselSite" class="carousel slide carousel-fade" data-ride="carousel" data-interval="5000">

        <ol class="carousel-indicators">
            <li data-target="#carouselSite" data-slide-to="0" class="active"></li>
            <li data-target="#carouselSite" data-slide-to="1"></li>
            <li data-target="#carouselSite" data-slide-to="2"></li>
        </ol>

        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="../imagens/Slide1.jpg" class="img-fluid d-block">
                <div class="carousel-caption d-none d-md-block">
                    <h3> Nova linhagem Razer </h3>
                    <p> Destrua nos games com os novos periféricos da linha Razer </p>
                </div>
            </div>

            <div class="carousel-item">
                <img src="../imagens/Slide2.jpg" class="img-fluid d-block">
                <div class="carousel-caption d-none d-md-block">
                    <h3> O Pai ta ON! </h3>
                    <p> Seja o "monstro" que seus inimigos receiam! </p>
                </div>
            </div>

            <div class="carousel-item">
                <img src="../imagens/Slide3.jpg" class="img-fluid d-block">
                <div class="carousel-caption d-none d-md-block">
                    <h3> "Totalmente previsível" </h3>
                    <p> Escute os passos a distancia de todos os seus inimigos! </p>
                </div>
            </div>
        </div>

        <a class="carousel-control-prev" href="#carouselSite" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon"></span>
            <span class="sr-only">Anterior</span>
        </a>

        <a class="carousel-control-next" href="#carouselSite" role="button" data-slide="next">
            <span class="carousel-control-next-icon"></span>
            <span class="sr-only">Avançar</span>
        </a>

    </div>

    <!-- Barra central -->
    <a name='produtos'></a>
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary wd-12">
        
        <div class="table-responsive-xl col-md-12 mt-5 bg-light pt-3 border border-danger">
        <form action='../metodos/select.php' method="GET">  
            <div class='float-right mb-2'>
                <input type='submit' value="filtrar" class="btn btn-dark">
                <select id='categoria' onchange="select()" class="align-middle mr-1">
                    <option value='Todos'>Todos</option>
                    <option value='Teclados'>Teclados</option>
                    <option value='Mouses'>Mouses</option>
                    <option value='Mousepads'>Mousepads</option>
                    <option value='Headsets'>Headsets</option>
                    <option value='Esgotados'>Esgotados</option>
                    <input type='hidden' id='txtSelect' name='txtSelect' value='Todos'>
                    <script> 
                    function select(){
                        var categoria = document.getElementById('categoria').value;
                            document.getElementById('txtSelect').value = categoria;
                         }
                    </script>
                </select>
            </div>
            <table class="table border border-secondary">
                <tr class="bg-danger text-black">
                    <th>Produto</th>
                    <th>Categoria</th>
                    <th>Fabricante</th>
                    <th>Nome</th>
                    <th>Valor</th>
                    <th scope="col" colspan="1">Comprar</th>
                </tr>
                <?php
                foreach ($listaProdutos as $produto) {
                ?>
                    <tr>
                        <td><img src='../imagens/catalogo/<?php echo $produto['Imagem'] ?>'></td>
                        <td class="align-middle"><?php echo $produto['Categoria']; ?> </td>
                        <td class="align-middle"><?php echo $produto['Fabricante']; ?></td>
                        <td class="align-middle"><?php echo $produto['Nome']; ?></td>
                        <td class="align-middle"><?php echo  number_format($produto['Valor'], 2, ',', '.'); ?></td>

                        <td class="align-middle"><a class="btn" onclick="JavaScript:location.href='../formularios/frmComprarProdutos.php?ID=' + 
                           <?php echo $produto['ID']; ?>">
                                <i class="material-icons">shopping_cart</i></a>
                        </td>
                    </tr>
                <?php
                }
                ?>
            </table>
            </form>
        </div>
    </nav>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/js/materialize.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>