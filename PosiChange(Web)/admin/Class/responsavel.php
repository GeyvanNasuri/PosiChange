<?php
class Responsavel{
private $id; 

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

public function efetuarLogin($_login, $_senha){
    $sql = new Sql();
    $senha_cript = md5($_senha);
    $results = $sql->select("SELECT * FROM responsavel WHERE login = :login AND senha = :senha",
    array(':login'=>$_login,":senha"=>$senha_cript));
    if (count($results)>0) {
        $this->setData($results[0]);
    }
}
public function setData($dados){
    $this->setId($dados['id']);
    $this->setNome($dados['nome']);
    $this->setRg($dados['rg']);
    $this->setCpf($dados['cpf']);
    $this->setAgend($dados['agend']);
    $this->setSenha($dados['senha']);
    $this->setTelefone($dados['telefone']);
    $this->setEmail($dados['email']);
    $this->setPaciente($dados['paciente']);
}
public function insert(){
    $sql = new Sql();
    $results = $sql->select("CALL sp_responsavel_insert(:cpf, :telefone, :login, :senha)",
        array(
            ":cpf"=>$this->getCpf(),
            ":telefone"=>$this->getTelefone(),
            ":login"=>$this->getLogin(),
            ":senha"=>md5($this->getSenha())
        ));
    if (count($results)>0) {
        $this->setData($results[0]);
    }
}

}




?>