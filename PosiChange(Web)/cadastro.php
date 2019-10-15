<?php?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title> Enfermagem Decubito</title>
    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="css/bulma/bulma.min.css"
</head>
<body>
    <header>
        
     
    <nav class="menu" id="menu">
       <ul>
        <li><a href="index.php">Home</a></li>
        <li><a href="paciente.php">Paciente</a></li>
        <li><a href="login.php">Login</a></li>
        <li><a href="cadastro.php">Cadastro</a></li>
       </ul>
     </nav>
     <img src="img/logo.png" alt="750px" width="750px" height="150px">

      
                    <div class="box">
                        <form action="op_cadastro.php" method="POST">
                            <div class="field">
                                <div class="control">
                                    <input name="CPF" type="text" class="input is-large" placeholder="CPF" autofocus>
                                </div>
                            </div>
                            <div class="field">
                                <div class="control">
                                    <input name="senha" class="input is-large" type="password" placeholder="Senha">
                                </div>
                            </div>
                            <button type="submit" class="button is-block is-link is-danger is-large is-fullwidth">Cadastrar</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </section>
</body>
 
</html>