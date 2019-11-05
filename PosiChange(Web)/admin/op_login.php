<?php
$txt_login = isset($_POST['txt_login'])?$_POST['txt_login']:'';
$txt_senha = isset($_POST['txt_senha'])?$_POST['txt_senha']:'';
if(empty($txt_login) || empty($txt_senha))  {
    echo 'Preencha os dados do Responsável.';
    exit;
}
$query = "SELECT * FROM responsavel WHERE login= :login AND senha = :senha";
$cmd = $cn->prepare($query);
$cmd->bindParam(':login',$txt_login);
$cmd->bindParam(':senha',$txt_senha); 
$cmd->execute();
$respon_return = $cmd->fetchAll(PDO::FETCH_ASSOC);
if(count($respon_return)>0){
    print "<script type='text/javascript'>location.href='principal.php'</script>";
}
else{
    print "<META HTTP-EQUIV=REFRESH CONTENT = '0'; URL='index.php'>
    <script type='text/javascript'>window.alert('Login ou senha incorretos, Tente novamente')</script>";
}




?>