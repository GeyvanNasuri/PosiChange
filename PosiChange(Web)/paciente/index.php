
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

 </header>
 <?php
include_once('../config.php');
$resp = new Responsavel();  

?>
    <div class="topo" id="topo">
    <h3> Seja bem-vindo <?php require_once('../login/op_login.php');
           
           $Nome = $_SESSION['nome'];
$primeiroNome = explode(" ", $Nome);
 

 
//ou
echo current($primeiroNome); // Fulano?>! </h3> 
    
    </div>
      <div class="menu">
        <li class="item" id='profile'>
          <a href="#profile" class="btn"><i class="material-icons">perm_identity</i></i>Área do Responsável</a>
          <div class="smenu">
                    <a href="index.php?link=1">Informações Gerais</a>

          </div>
        </li>
        <li class="item" id="messages">
          <a href="#messages" class="btn"><i class="material-icons">date_range</i>Agendamento</a>
          <div class="smenu">
            <a href="index.php?link=2">Novo Agendamento</a>
            <a href="index.php?link=3">Ver Agendamentos</a>

            <li class="item" id="messages">
            <a href="../index.php" class="btn"><i class="material-icons">
cancel
</i>Encerrar</a>
         </div>
        </li>
      </div>

      <div id="centro" class="centro">
                <?php      
                  $link = isset($_GET['link'])? $_GET['link']:'';
                  $pag[1] = "informacoes.php";                    
                  $pag[2] = "novoagend.php"; 
                  $pag[3] = "agendamentos.php";
                  if(!empty($link))
                  {
                      if(file_exists($pag[$link]))
                      {
                          include($pag[$link]);
                      }
                      else
                      {
                          include($pag[1]); //Mostre o home
                      }
                  }
                  else
                  {
                      include($pag[1]); //Mostre o home
                  }   

                ?>
            </div>

            


</html>
<footer>
</footer>
</body>
</html>