<?php
    session_start();

    if(isset($_SESSION['Nome'])){
        unset($_SESSION['Nome']);
        unset($_SESSION['CPF']);
    } 
    if(isset($_SESSION['Tipo'])){
        unset($_SESSION['Tipo']);
    }
    if(isset($_SESSION['Select'])){
        unset($_SESSION['Select']);
    }
    header("location:../formularios/frmTelaLogin.php");
?>