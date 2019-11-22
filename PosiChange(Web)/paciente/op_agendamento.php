<?php
  require_once('../config.php');
  #Inserindo POST    
  if(isset($_POST['btna']))
  {
      $agend = new Agendamento();
      if(isset($agend))
      {
          $agend->inserirAgend($_POST['id_categoria_post'],$_POST['titulo_post'],$_POST['descricao_post'],$img[0],$_POST['data_post'],isset($_POST['ativo_post'])?'s':'n');
          if($agend->getId()>0)
          {
              header('location:novoagend.php?link=4&msg=inserido');
          }
          else
          {
              header('location:novoagend.php?link=4&msg=erro');
          }
      }        
  }    
    #delete post
    if(isset($_GET['excluir']) && isset($_GET['id_agend']))
    {        
        if($_GET['excluir']==1)
        {
            $agend = new Agendamento();
            $agend->deleteAgend($_GET['id_agend']);
            header('location:novoagend.php?link=5&msg=excluido');        
            $_GET['excluir'] = null;
            $_GET['id_'] = null;
        }        
    }
?>