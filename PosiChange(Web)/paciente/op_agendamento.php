<!-- <?php
  require_once('../config.php');
  #Inserindo POST    
  if(isset($_POST['btna']))
  {
      $agend = new Agendamento();
      if(isset($agend))
      {
          $agend->inserirAgend($_POST['_res'],$_POST['dia'],$_POST['nov_age']);
          if($agend->getId()>0)
          {
              header('location:novoagend.php?link=2&msg=inserido');
          }
          else
          {
              header('location:novoagend.php?link=2&msg=erro');
          }
      }        
  }    
    #delete post
    if(isset($_GET['excluir']) && isset($_GET['id']))
    {        
        if($_GET['excluir']==1)
        {
            $agend = new Agendamento();
            $agend->deleteAgend($_GET['id']);
            header('location:novoagend.php?link=2&msg=excluido');        
            $_GET['excluir'] = null;
            $_GET['id_'] = null;
        }        
    }
?>