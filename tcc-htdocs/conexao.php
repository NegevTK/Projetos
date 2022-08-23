<?php

$host = 'localhost';
$user = 'root';
$password = '';
$db = 'FEMA_DATA_SYSTEM';

try{
$pdo = new PDO("mysql:dbname=FEMA_DATA_SYSTEM;host=localhost","root","");
}catch(PDOException $e){
    echo "Error: ".$e->getMessage();
}
