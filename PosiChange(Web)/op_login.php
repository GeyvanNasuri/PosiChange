<?php
// sem sabotagem!
require_once('config.php');
require_once('conexao.php');
$txt_cpf = isset($_POST['txt_cpf'])?$_POST['txt_cpf']:'';
$txt_senha = isset($_POST['txt_senha'])?$_POST['txt_senha']:'';
//echo $txt_cpf.' - '.$txt_senha;
if(empty($txt_cpf) || empty($txt_senha))  {
    echo 'Preencha os dados de Usuário.';
    exit;
}
$query = "SELECT * FROM Responsavel WHERE cpf= :cpf AND senha = :senha";
$cmd = $cn->prepare($query);
$cmd->bindParam(':cpf',$txt_cpf);
$cmd->bindParam(':senha',$txt_senha); 
$cmd->execute();
$usuario_retornado = $cmd->fetchAll(PDO::FETCH_ASSOC);
if(count($usuario_retornado)>0){
    print "<script type='text/javascript'>location.href='principal.php'</script>";
}
else{
    print "<META HTTP-EQUIV=REFRESH CONTENT = '0'; URL='index.php'>
    <script type='text/javascript'>window.alert('CPF ou senha incorretos, Tente novamente')</script>";
}
?>