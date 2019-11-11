<?php

//inicializar a sessão de usuário
if (!isset($_SESSION)){
    session_start();
}

//definindo padrão de Zona GMT (TimeZone) -3,00
date_default_timezone_set('America/Sao_Paulo');

//inicia carregamento das classes do projeto
// spl_autoload_register(function($nome_classe)
//     {
//         $server_str = $_SERVER['REQUEST_URI'];
//         $caminho = strpos($server_str,'admin') !== false?'class':'admin/class';
//         $nome_arquivo = $caminho.DIRECTORY_SEPARATOR.$nome_classe.".php";
//         if(file_exists($nome_arquivo))
//         {
//             require_once($nome_arquivo);
//         }
//     });    
spl_autoload_register(function($nome_classe)
{
    
    $server_str = $_SERVER['REQUEST_URI'];
    // var_dump($server_str);
    echo"<br>";
    $caminho = strpos($server_str,'admin') !== false?'../admin':'../admin/class';
    // var_dump($caminho);
    echo"<br>";
    $nome_arquivo = $caminho."/".$nome_classe.".php";
    // var_dump($nome_arquivo);
    echo"<br>";
    if(file_exists($nome_arquivo))
    {      
        require_once($nome_arquivo);
    }
});    

//Criar constantes do servidor de banco de dados
define ('IP_SERVER_DB', '127.0.0.1');
define ('HOSTNAME','ITQ0626028W10-1');
define ('NOME_BANCO','posichange');
define ('USER_DB','root');
define ('PASS_DB','');
?>