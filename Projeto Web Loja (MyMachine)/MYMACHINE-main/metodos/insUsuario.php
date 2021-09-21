<?php //Método de inserção do Usuario
include '../metodos/conexao.php';
session_start();

    $nome = trim($_POST['txtNome']);
    $cpf = trim($_POST['txtCPF']);
    $endereco = trim($_POST['txtEnder']);
    $email = trim($_POST['txtEmail']);
    $senha = trim($_POST['txtSenha']);
    $cidade = trim($_POST['txtCidade']);
    $estado = trim($_POST['txtEstado']);
    $cep = trim($_POST['txtCEP']);
    
    $pdo = Conexao::conectar();
    $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    $sql = "SELECT * FROM Usuarios WHERE Email = ? OR CPF = ?";
    $query = $pdo->prepare($sql);
    $query->execute(array($email,$cpf));
    $dados = $query->fetch(PDO::FETCH_ASSOC);
    Conexao::desconectar();

    

    if (!empty($dados['Email']) or !empty($dados['CPF'])) {
        header("location:../formularios/frmTelaCadastro.php");
        $_SESSION['msg'] = "<div class='alert alert-danger'> Ops! conta já existente! <u><a href='../formularios/frmTelaLogin.php'>Entrar</a></u></div>";
    } else {
        $pdo = Conexao::conectar();
        $pdo->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
        $sql = "INSERT INTO usuarios(CPF, Nome, Endereco, Email, Senha, Cidade, Estado, CEP) VALUES (?, ?, ?, ?, ?, ?, ?, ?);";
        $query = $pdo->prepare($sql);
        $query->execute(array($cpf, $nome, $endereco, $email, $senha, $cidade, $estado, $cep));
        Conexao::desconectar();
        header("location:../formularios/frmTelaLogin.php");
    }
