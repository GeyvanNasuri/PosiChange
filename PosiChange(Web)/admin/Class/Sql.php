<?php
    class Sql extends PDO
    {
        #Definindo atributo privado
        private $cn;
        #Criando function construtor
        public function __construct()
        {
            $this->cn = new PDO("mysql:host="."127.0.0.1".";dbname="."posichange","root","");
        }
        #Método atribui parametroS para query sql
        public function setParams($comando,$parametros = array())
        {
            foreach ($parametros as $key => $value)
            { 
                $this->setParam($comando,$key,$value);
            }
        }
        #Método que associa o valor da associação ao cmd
        public function setParam($cmd,$key,$value)
        {
            $cmd->bindParam($key, $value);            
        }
        #Método query retorna bool caso tenha executado com sucesso
        public function query($comandoSql,$params = array())
        {
            $cmd = $this->cn->prepare($comandoSql);
            $this->setParams($cmd,$params);
            $cmd->execute();     
            return $cmd;
        }
        #Método que retorna um array associativo da consulta do banco de dados
        public function select($comandoSql,$params = array())
        {
            $cmd = $this->query($comandoSql,$params);
            return $cmd->fetchAll(PDO::FETCH_ASSOC);
        }
    }
?>