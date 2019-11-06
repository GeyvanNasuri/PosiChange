<?php
class Responsavel{
private $id; 
private $nome;
private $rg;
private $cpf;
private $agendamento;
private $senha;
private $telefone;
private $email;
private $paciente;
private $acesso;


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
    
    public function getRg(){
    return $this->rg;
    }
    public function setRg($value){
    $this->rg = $value;
    }
    
    public function getCpf(){
    return $this->cpf;
    }
    public function setCpf($value){
    $this->cpf = $value;
    }
    
    public function getAgend(){
    return $this->agendamento;
    }
    public function setAgend($value){
    $this->agendamento = $value;
    }
    
    public function getSenha(){
    return $this->senha;
    }
    public function setSenha($value){
    $this->senha = $value;
    }
    
    public function getTelefone(){
    return $this->telefone;
    }
    public function setTelefone($value){
    $this->telefone = $value;
    }
    
    public function getEmail(){
    return $this->email;
    }
    public function setEmail($value){
    $this->email = $value;
    }
    
    public function getPaciente(){
    return $this->paciente;
    }
    public function setPaciente($value){
        $this->paciente = $value;
    }

    public function getAcesso(){
    return $this->acesso;
    }
    public function setAcesso($value){
    $this->acesso = $value;
    }
    


    public function loadById($_id){
        $sql = new Sql();
        $results = $sql->select("SELECT * FROM responsavel WHERE id = :id",array(':id'=>$_id));
        if (count($results)>0) {
            $this->setData($results[0]);
        }
    }
    public static function getList(){
        $sql = new Sql();
        return $sql->select("SELECT * FROM responsavel order by nome");
    }
    public static function search($nome){
        $sql = new Sql();
        return $sql->select("SELECT * FROM responsavel WHERE nome LIKE :nome",
            array(":nome"=>"%".$nome."%"));
    }
    public function efetuarLogin($_cpf, $_senha){
        $sql = new Sql();
        $senha_cript = md5($_senha);
        $results = $sql->select("SELECT * FROM responsavel WHERE cpf = :cpf AND senha = :senha",
        array(':cpf'=>$_cpf,":senha"=>$senha_cript));
        if (count($results)>0) {
            $this->setData($results[0]);
        }
    }
    public function setData($dados){ 
        $this->setId($dados['id']);
        $this->setNome($dados['nome']);
        $this->setRg($dados['rg']);
        $this->setCpf($dados['cpf']);
        $this->setAgend($dados['agendamento']);
        $this->setSenha($dados['senha']);
        $this->setTelefone($dados['telefone']);
        $this->setEmail($dados['email']);
        $this->setPaciente($dados['paciente']);
        $this->setAcesso($dados['acesso']);

    }
    public function insert(){
        $sql = new Sql();
        $results = $sql->select("CALL sp_insert_responsavel(:sp_nome, :sp_email, :sp_senha, :sp_rg, :sp_cpf, :sp_telefone, :sp_endereco, :sp_agendamento, sp_acesso, sp_cod_pac)",
            array(
                ":sp_nome"=>$this->getNome(),
                ":sp_email"=>$this->getEmail(),
                ":sp_senha"=>md5($this->getSenha()),
                ":sp_rg"=>$this->getRg(),
                ":sp_cpf"=>$this->getCpf(),
                ":sp_telefone"=>$this->getTelefone(),
                ":sp_endereco"=>$this->getEndereco(),
                ":sp_agendamento"=>$this->getAgend(),
                ":sp_acesso"=>$this->getAcesso(),
                ":sp_cod_pac"=>$this->getPaciente(),


            ));
        if (count($results)>0) {
            $this->setData($results[0]);
        }
    }
    
    public function __construct($_cpf="",$_senha=""){

        $this->cpf = $_cpf;
        $this->senha = $_senha;
    }

}


?>