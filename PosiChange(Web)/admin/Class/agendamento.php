<?php
class Agendamento{

 private $cod_age;
 private $cod_res;
 private $dia;
 private $novo;

 public function getCodAge(){
    return $this->cod_age;
    }
    public function setCodAge($value){
    $this->cod_age = $value;
    }

    public function getCodRes(){
    return $this->cod_res;
    }
    public function setCodRes($value){
    $this->cod_res = $value;
    }

    public function getDia(){
    return $this->dia;
    }
    public function setDia($value){
    $this->dia = $value;
    }

    public function getNovo(){
        return $this->novo;
        }
        public function setNovo($value){
        $this->novo = $value;
        }
    
        // buscando pelo id do Agendamento
        public function loadById($_id){
        $sql = new Sql();
        $results = $sql->select("SELECT * FROM agendamento WHERE id = :id",array(':id'=>$_id));
        if (count($results)>0) {
            $this->setData($results[0]);
        }
    }

    // inserindo agendamento
    public function insert(){
        $sql = new Sql();
        $results = $sql->query("INSERT INTO agendamento VALUES(null, :_cod_res, :dia, :cod_age)",
            array(
                ":_cod_res"=>$this->getCodRes(),
                ":dia"=>$this->getDia(),
                ":cod_age"=>$this->getCodAge()
            ));
        if (count($results)>0) {
            $this->setData($results[0]);
        }
    }

    // alterando agendamento
    public function update( $_dia, $_novo){
        $sql = new Sql();
        $sql->query("UPDATE agendamento SET dia = :dia, novo = :novo 
            WHERE cod_age = :cod_age",
            array(
                ":dia"=>$_dia,
                ":novo"=>$_novo
            ));
    }


    
    // cancelando agendamento
    public function cancel(){
        $sql = new Sql();
        $sql->query("DELETE FROM agendamento WHERE cod_age = :cod_age",array(":cod_age"=>$this->getCodAge()));
    }

    // fazendo construtores
    public function __construct($_codres="",$_dia="",$_novo=""){
        $this->cod_res = $_codres;
        $this->dia = $_dia;
        $this->novo = $_novo;
    }




}

?>