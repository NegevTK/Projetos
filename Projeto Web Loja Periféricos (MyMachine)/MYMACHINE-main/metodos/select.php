<?php 
    session_start();
    include '../metodos/conexao.php';
    $select = $_GET['txtSelect'];
    
    if($select!="Todos"){
        $_SESSION['Select'] = $select;
    }else{
        unset($_SESSION['Select']);
    }
    header("location:../formularios/index.php"); 
?>