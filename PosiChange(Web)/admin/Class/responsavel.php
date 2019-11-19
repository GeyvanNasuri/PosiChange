<?php
    class Responsavel 
    {
        private $id; 
        private $nome;
        private $rg;
        private $cpf;
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
            $results = $sql->select("SELECT * FROM responsavel WHERE cod_res = :id",array(':id'=>$_id));
            if (count($results)>0) 
            {
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
            $results = $sql->select("SELECT * FROM responsavel WHERE cpf = :cpf AND senha = :senha",
            array(':cpf'=>$_cpf,":senha"=>$_senha));
            if (count($results)>0) {
                $this->setData($results[0]);
            }
        }
        public function setData($data){  // erros aquix
            $this->setId($data['cod_res']);
            $this->setNome($data['nome']);
            $this->setRg($data['rg']);
            $this->setCpf($data['cpf']);
            $this->setSenha($data['senha']);
            $this->setTelefone($data['telefone']);
            $this->setEmail($data['email']);
            $this->setPaciente($data['paciente']);
            $this->setAcesso($data['acesso']);

        }
        public function insert(){
            $sql = new Sql();
            $results = $sql->select("CALL sp_insert_responsavel(:sp_nome, :sp_email, :sp_senha, :sp_rg, :sp_cpf, :sp_telefone, :sp_endereco, sp_acesso, sp_cod_pac)",
                array(
                    ":sp_nome"=>$this->getNome(),
                    ":sp_email"=>$this->getEmail(),
                    ":sp_senha"=>$this->getSenha(),
                    ":sp_rg"=>$this->getRg(),
                    ":sp_cpf"=>$this->getCpf(),
                    ":sp_telefone"=>$this->getTelefone(),
                    ":sp_endereco"=>$this->getEndereco(),
                    ":sp_acesso"=>$this->getAcesso(),
                    ":sp_cod_pac"=>$this->getPaciente(),
                ));
            if (count($results)>0) {
                $this->setData($results[0]);
            }
        }
        
        public function __construct($_id='',$_nome="",$_email="",$_cpf="",$_senha="")
        {
            $this->id = $_id;
            $this->nome = $_nome;
            $this->email = $_email;
            $this->cpf = $_cpf;
            $this->senha = $_senha;
        }

    }


?>
