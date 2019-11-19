<?php
include_once('../config.php');


$resp = new Responsavel();  

?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title> Enfermagem Decubito</title>
    <link rel="stylesheet" href="style.css">
    <link href="https://fonts.googleapis.com/css?family=Roboto+Condensed&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">

</head>
<body>


<header>
    <p ALIGN="center">
      <img SRC="../img/logo.png" WIDTH="600" HEIGHT="100" />
    </p>
    <!-- Aqui vai o $_session [nome_do_usuario] etc -->
    <h2> Responsável: <?php require_once('../login/op_login.php');
           
           echo $_SESSION['nome']; ?> </h2> 
    <h2> Paciente: <?php echo $_SESSION['paciente'];?> </h2>
   

 </header>

    <div class="middle">
      <div class="menu">
        <li class="item" id='profile'>
          <a href="#profile" class="btn"><i class="material-icons">perm_identity</i></i>Paciente</a>
          <div class="smenu">
                    <a href="#">Informações Gerais</a>
                    <a href="#">Estado Atual</a>
          </div>
        </li>
        <li class="item" id="messages">
          <a href="#messages" class="btn"><i class="material-icons">date_range</i>Agendamento</a>
          <div class="smenu">
            <a href="#">Novo Agendamento</a>
            <a href="#">Cancelamento de Agendamento</a>

            <li class="item" id="messages">
            <a href="../index.php" class="btn"><i class="material-icons">
cancel
</i>Encerrar</a>

         </div>
        </li>
      </div>
    </div>
</html>



<footer>

</footer>
</body>
</html>