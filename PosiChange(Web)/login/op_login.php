<?php
// sem sabotagem!
require_once('../config.php');



 #logando Usuario
$resp = new Responsavel();  

if(isset($_POST['logar']))

 {

     if(isset($_POST['txt_cpf']))        
     {       
        // var_dump($_POST[`txt_cpf`]);

         $resp->efetuarLogin($_POST['txt_cpf'],$_POST['txt_senha']);
         var_dump($resp);
         if($resp->getId()>0)
         {
             $_SESSION['logado'] = true;
             $_SESSION['id'] = $resp->getId();
             $_SESSION['cpf'] = $resp->getCpf();
             $_SESSION['nome'] = $resp->getNome();
             $_SESSION['email'] = $resp->getEmail();   
             $_SESSION['paciente'] = $resp->getPaciente();   
             
             var_dump($_SESSION);
             header('location:../paciente/index.php');
         }
         else
         {
             //header('location:../login/index.php?msg=Email ou senha Incorreto!');
         }            
    }
}


    #Encerrando a sessão
    if(isset($_GET['sair']))
    {
        if($_GET['sair']==1)
        {
            $_SESSION['logado_usuario'] = null;
            $_SESSION['id_usuario'] = null;
            $_SESSION['nome_usuario'] = null;
            $_SESSION['email_usuario'] = null;                
            // var_dump($_SESSION);
            header('location:../index.php');
        }
    }
?>