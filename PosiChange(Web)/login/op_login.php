<?php
// sem sabotagem!
require_once('../config.php');
require_once('../conexao.php');
$txt_cpf = isset($_POST['txt_cpf'])?$_POST['txt_cpf']:'';
$txt_senha = isset($_POST['txt_senha'])?$_POST['txt_senha']:'';
//echo $txt_cpf.' - '.$txt_senha;
if(empty($txt_cpf) || empty($txt_senha))  {
    echo 'Preencha os dados de Usuário.';
    exit;
}
$query = "SELECT * FROM responsavel WHERE cpf= :cpf AND senha = :senha";
$cmd = $cn->prepare($query);
$cmd->bindParam(':cpf',$txt_cpf);
$cmd->bindParam(':senha',$txt_senha); 
$cmd->execute();
$responsavel_retornado = $cmd->fetchAll(PDO::FETCH_ASSOC);
if(count($responsavel_retornado)>0){
    print "<script type='text/javascript'>location.href='../paciente/index.php'</script>";
}
else{
    print "<META HTTP-EQUIV=REFRESH CONTENT = '0'; URL='index.php'>
    <script type='text/javascript'>window.alert('CPF ou senha incorretos, Tente novamente')</script>";
}


// Aqui vai a Declaração da variavel de sessão 
 #logando Usuario
 $resp = new Responsavel();  
 if(isset($_POST['logar']))
 {
     if(isset($_POST['txt_cpf']))        
     {       
            
         $resp->efetuarLogin($_POST['txt_cpf'],$_POST['txt_senha']);
         if($resp->getId()>0)
         {
             $_SESSION['logado'] = true;
             $_SESSION['id_responsavel'] = $resp->getId();
             $_SESSION['nome_responsavel'] = $resp->getNome();
             $_SESSION['email_responsavel'] = $resp->getEmail();   
             header('location:../paciente/index.php?msg=logado com Sucesso');
         }
         else
         {
             header('location:../paciente/index.php?msg=Email ou senha Incorreto!');
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
            var_dump($_SESSION);
            header('location:../index.php');
        }
    }
?>