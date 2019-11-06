<?php

?>

<!DOCTYPE html>
<html lang="pt-br">
  <head>
    <meta charset="utf-8">
    <title></title>
    <link rel="stylesheet" href="estilo.css">
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js" charset="utf-8"></script>
    <link href="https://fonts.googleapis.com/css?family=Roboto+Condensed&display=swap" rel="stylesheet">

  </head>
  <body>


        <form id="frmlogin" name="frmlogin" action="op_login.php" method="post" class="login-form">
        <h1>Login PosiChange</h1>
        <label>CPF</label>
        <div class="txtb">
        <input type="text" name="txt_cpf" id="txt_cpf">
        </div>
        <label>Senha</label>
        <div class="txtb">
        <input type="password" name="txt_senha" id="txt_senha">
        </div>
        <input type="submit" name="logar" id="logar" value="logar" class="logbtn">

        <div>
          Caso login não seja sucedido contatar o Administrador.
        </div>
        </fieldset>
      </form>

      <script type="text/javascript">
      $(".txtb input").on("focus",function(){
        $(this).addClass("focus");
      });

      $(".txtb input").on("blur",function(){
        if($(this).val() == "")
        $(this).removeClass("focus");
      });

      </script>


  </body>
</html>
