<?php
include_once('../config.php');
$resp = new Responsavel();  

?>

<div id="centro">
<h3>Nome do responsável:  <?php require_once('../login/op_login.php');
           
           echo $_SESSION['nome']; ?></h3>

<h3>Nome do paciente:  <?php require_once('../login/op_login.php');
           
           echo $_SESSION['paciente']; ?></h3>

<h3>RG responsável:  <?php require_once('../login/op_login.php');
           
           echo $_SESSION['rg']; ?></h3>

<h3>CPF responsável:  <?php require_once('../login/op_login.php');
           
           echo $_SESSION['cpf']; ?></h3>

<h3>Email:  <?php require_once('../login/op_login.php');
           
           echo $_SESSION['email']; ?></h3>

<h3>Telefone:  <?php require_once('../login/op_login.php');
           
           echo $_SESSION['telefone']; ?></h3>

</div>

