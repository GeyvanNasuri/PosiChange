<?php

session_start();
include("conexao.php");

$nome = mysqli_real_escape_string($conexao, $_POST['nome']);
$cpf = mysqli_real_escape_string($conexao, $_POST['CPF']);
$senha = mysqli_real_escape_string($conexao, $_POST ['senha']);

$sql = "";