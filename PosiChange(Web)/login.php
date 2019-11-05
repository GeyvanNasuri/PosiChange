<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title> Enfermagem Decubito</title>
    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    
    <link rel="stylesheet" href="css/bulma/bulma.min.css">
</head>
<body>
    <header>
        
     
    <nav class="menu" id="menu">
       <ul>
        <li><a href="index.php">Home</a></li>
        <li><a href="login.php">Login</a></li>
        <li><a href="sobrenos.php">Sobre-Nós</a></li>

       </ul>
     </nav>
     <img src="img/logo.png" alt="750px" width="750px" height="150px">
     <div id="box-login">
        <div id="formulario-login">
            <form id="frm_login" name="frm_login" action="op_login.php" method="post">
                <fieldset>
                    <legend>Faça login</legend>
                    <label for=""><span>Login</span></label>
                    <input name="CPF" type="text" class="input is-large" placeholder="CPF" name="txt_login" id="txt_login">
                    <label for=""><span>Senha</span></label>
                    <input name="senha" class="input is-large" type="password" placeholder="Senha" name="txt_senha" id="txt_senha">
                    <button type="submit" class="button is-block is-danger is-large is-fullwidth" name="entrar" id="entrar" value="Entrar" class="botao">Entrar
                </fieldset>
            </form>       
        </div>
    </div>
 </header>
 <main>