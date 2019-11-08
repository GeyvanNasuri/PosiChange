<?php
class Agendamento{

 private $id;
 private $cod_resp;
 private $dia;
 private $novo;

 public function getId(){
    return $this->id;
    }
    public function setId($value){
    $this->id = $value;
    }

    public function getCodResp(){
    return $this->cod_resp;
    }
    public function setCodResp($value){
    $this->cod_resp = $value;
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
        $results = $sql->query("INSERT INTO agendamento VALUES(null, :_res, :dia, :nov_age)",
            array(
                ":_res"=>$this->getCodResp(),
                ":dia"=>$this->getDia(),
                ":nov_age"=>$this->getNovo()
            ));
        if (count($results)>0) {
            $this->setData($results[0]);
        }
    }

    // alterando agendamento
    public function update($_id, $_codresp, $_dia, $_novo){
        $sql = new Sql();
        $sql->query("UPDATE agendamento SET dia = :dia, novo = :novo 
            WHERE id = :id",
            array(
                ":id"=>$_id,
                ":dia"=>$_dia,
                ":novo"=>$_novo
            ));
    }
    
    // cancelando agendamento
    public function cancel(){
        $sql = new Sql();
        $sql->query("DELETE FROM agendamento WHERE id = :id",array(":id"=>$this->getId()));
    }

    // fazendo construtores
    public function __construct($_codresp="",$_dia="",$_novo=""){
        $this->cod_resp = $_codresp;
        $this->dia = $_dia;
        $this->novo = $_novo;
    }




}

?>