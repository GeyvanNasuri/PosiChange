<?php
    require_once('../config.php');            
    $agends = new Agendamento();


?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">    
    <link rel="stylesheet" href="style.css">
    <title>Seus Agendamentos</title>
</head>
<body>
<table width='100%' border="100px" cellpadding="0" cellspacing="1" bgcolor="">
        <tr bgcolor="#fa4f4f" align="center">
            <th width="5%" height="2" align="rigth"><font size="2" color="#fff">Visitante</font></th>
            <th width="20%" height="2" align="rigth"><font size="2" color="#fff">Data</font></th>
            <th colspan="2" align="center"><font size="2" color="#fff">Cancelar Agendamento</font></th>
        </tr>
    </div>
        <?php            
            foreach($agends as $agend)
            {
        ?>
        <tr align="center">
            <td><?php echo $agend['cod_resp']?></td>
            <td><?php echo $agend['cod_pac']?></td>
            <td><?php echo $agend['dia']?></td>
            <td><?php echo $agend['novo']?></td>
    
            <td align="center"><font size="2" face="verdana, arial" color="#000">
                <a href="<?php echo 'alterar_post.php?id_post='.$agend['cod_resp'].'&categoria='.$agend['cod_pac'].'&titulo='.$agend['titulo_post'].
                '&descricao='.$agend['descricao_post'].'&img='.$agend['img_post'].'&visitas='.$agend['visitas'].'&data='.$agend['data_post'].'&ativo='.$pot['post_ativo']?>">Alterar</a>
            </font></td>
            <td align="center"><font size="2" face="verdana, arial" color="#000">
                <a href="<?php echo 'op_post.php?excluir=1&id_post='.$pot['id_post']?>">Excluir</a>
            </font></td>
        </tr>
        <?php
            }
  
        ?>

</body>
</html>