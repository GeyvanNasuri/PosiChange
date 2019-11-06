<?php

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
    <P ALIGN="center">
    <IMG SRC="../img/logo.png" WIDTH="600" HEIGHT="100" /></P>
    <!-- Aqui vai o $_session [nome_do_usuario] etc -->
  <?php 
    if(isset($_SESSION['logado_responsavel']))
    {
      if($_SESSION['logado_responsavel'])
      {
        echo '<a href="index.php?link=8">Perfil</a>';
      }
      else
      {
        echo '<a href="index.php?link=6">Logar-se</a>';
      }
    }
    ?>
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
<?php
    require_once('../config.php');
    if(isset($_SESSION['logado_responsavel']))
    {
        if($_SESSION['logado_responsavel']==false)
        {
            header('location:index.php?msg=É necessario estar logado para vizualizar');
        }
    }
?>
<h1><?php
 echo $_SESSION['nome']; ?></h1>
<br><br>
<h2><?php //echo $_SESSION['cod_pac']; ?></h2> // aqui vai o codigo do paciente 
<br>
<h3><a href="../login/op_login.php?sair=1">Desconectar-se</a></h3>

</html>



<footer>

</footer>
</body>
</html>