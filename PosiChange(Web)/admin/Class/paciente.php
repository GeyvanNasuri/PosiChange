<?php
class Paciente{

    private $id;
    private $nome;
    private $apr_fer;
    private $des_fer;
    private $sit_pac;


    public function getId(){
        return $this->id;
    }
    public function setId($value){
        $this->id = $value;
    }

    public function getNome(){
        return $this->nome;
    }
    public function setNome($value){
        $this->nome = $value;
    }
     
    public function getAprFer(){    
        return $this->apr_fer;
    }
    public function setAprFer($value){
        $this->apr_fer = $value;
    }


    public function getDesFer(){    
        return $this->des_fer;
    }
    public function setDesFer($value){
        $this->des_fer = $value;
    }

    public function getSitPac(){
        return $this->sit_pac;
    }
    public function setSitPac($value){
        $this->sit_pac = $value;
    }

    public function loadById($_id){
        $sql = new Sql();
        $results = $sql->select("SELECT * FROM paciente WHERE id = :id",array(':id'=>$_id));
        if (count($results)>0) {
            $this->setData($results[0]);
        }
    }
    public static function getList(){
        $sql = new Sql();
        return $sql->select('SELECT * FROM paciente order by paciente');

    } 




    

}




?>