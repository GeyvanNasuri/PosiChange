<?php
define('HOST', '127.0.0.1') /* Ip do servidor */
define('USUARIO', 'root')
define('SENHA', 'gtr456yu')
define('DB', 'login')

$conexao = mysqli_connect(HOST, USUARIO, SENHA, DB) or die('Não foi possível conectar');