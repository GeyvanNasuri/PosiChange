-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema softklee_posichange
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema softklee_posichange
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `softklee_posichange` DEFAULT CHARACTER SET utf8 ;
USE `softklee_posichange` ;

-- -----------------------------------------------------
-- Table `softklee_posichange`.`paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`paciente` (
  `cod_pac` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NOT NULL,
  `rg` VARCHAR(12) NOT NULL,
  `cpf` VARCHAR(15) NOT NULL,
  `apr_fer` BIT(1) NOT NULL,
  `des_fer` VARCHAR(150) NULL DEFAULT NULL,
  `sit_pac` VARCHAR(300) NOT NULL,
  PRIMARY KEY (`cod_pac`),
  UNIQUE INDEX `cod_pac_UNIQUE` (`cod_pac` ASC))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `softklee_posichange`.`responsavel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`responsavel` (
  `cod_res` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NOT NULL,
  `rg` VARCHAR(12) NOT NULL,
  `cpf` VARCHAR(14) NOT NULL,
  `senha` VARCHAR(20) NOT NULL,
  `telefone` VARCHAR(15) NULL DEFAULT NULL,
  `email` VARCHAR(45) NOT NULL,
  `pri_ace` BIT(1) NOT NULL,
  `_pac` INT(11) NOT NULL,
  PRIMARY KEY (`cod_res`),
  UNIQUE INDEX `rg_UNIQUE` (`rg` ASC),
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC),
  UNIQUE INDEX `cod_res_UNIQUE` (`cod_res` ASC),
  INDEX `fk_responsavel_paciente1_idx` (`_pac` ASC),
  CONSTRAINT `fk_responsavel_paciente1`
    FOREIGN KEY (`_pac`)
    REFERENCES `softklee_posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `softklee_posichange`.`agendamento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`agendamento` (
  `cod_age` INT(11) NOT NULL,
  `_cod_res` INT(11) NOT NULL,
  `dia` DATETIME NOT NULL,
  `nov_age` BIT(1) NOT NULL,
  PRIMARY KEY (`cod_age`),
  INDEX `fk_agendamento_responsavel1_idx` (`_cod_res` ASC),
  CONSTRAINT `fk_agendamento_responsavel1`
    FOREIGN KEY (`_cod_res`)
    REFERENCES `softklee_posichange`.`responsavel` (`cod_res`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `softklee_posichange`.`nivel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`nivel` (
  `cod_nivel` INT(11) NOT NULL AUTO_INCREMENT,
  `nivel` VARCHAR(20) NOT NULL,
  `sigla` CHAR(3) NOT NULL,
  PRIMARY KEY (`cod_nivel`))
ENGINE = InnoDB
AUTO_INCREMENT = 6
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `softklee_posichange`.`atendimento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`atendimento` (
  `cod_ate` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NOT NULL,
  `rg` VARCHAR(12) NOT NULL,
  `cpf` VARCHAR(14) NOT NULL,
  `login` VARCHAR(20) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `intervalo` TIME NOT NULL,
  `turno` VARCHAR(10) NOT NULL,
  `telefone` VARCHAR(15) NULL DEFAULT NULL,
  `pri_ace` BIT(1) NOT NULL,
  `_nivel` INT(11) NOT NULL,
  PRIMARY KEY (`cod_ate`, `intervalo`),
  UNIQUE INDEX `login_UNIQUE` (`login` ASC),
  UNIQUE INDEX `cod_ate_UNIQUE` (`cod_ate` ASC),
  INDEX `fk_atendimento_nivel1_idx` (`_nivel` ASC),
  CONSTRAINT `fk_atendimento_nivel1`
    FOREIGN KEY (`_nivel`)
    REFERENCES `softklee_posichange`.`nivel` (`cod_nivel`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `softklee_posichange`.`enfermagem`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`enfermagem` (
  `cod_enf` INT(11) NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(50) NOT NULL,
  `rg` VARCHAR(12) NOT NULL,
  `cpf` VARCHAR(14) NOT NULL,
  `coren` INT(11) NOT NULL,
  `turno` VARCHAR(10) NOT NULL,
  `intervalo` TIME NOT NULL,
  `telefone` VARCHAR(15) NULL DEFAULT NULL,
  `_nivel` INT(11) NOT NULL,
  PRIMARY KEY (`cod_enf`),
  UNIQUE INDEX `coren_UNIQUE` (`coren` ASC),
  UNIQUE INDEX `cod_enf_UNIQUE` (`cod_enf` ASC),
  INDEX `fk_enfermagem_nivel1_idx` (`_nivel` ASC),
  CONSTRAINT `fk_enfermagem_nivel1`
    FOREIGN KEY (`_nivel`)
    REFERENCES `softklee_posichange`.`nivel` (`cod_nivel`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `softklee_posichange`.`historico_paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`historico_paciente` (
  `cod_his_pac` INT(11) NOT NULL AUTO_INCREMENT,
  `razao` VARCHAR(100) NULL DEFAULT NULL,
  `_pac` INT(11) NOT NULL,
  `hora_reg` DATETIME NOT NULL,
  PRIMARY KEY (`cod_his_pac`),
  UNIQUE INDEX `cod_his_pac_UNIQUE` (`cod_his_pac` ASC),
  INDEX `fk_historico_paciente_paciente1_idx` (`_pac` ASC),
  CONSTRAINT `fk_historico_paciente_paciente1`
    FOREIGN KEY (`_pac`)
    REFERENCES `softklee_posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `softklee_posichange`.`infracao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`infracao` (
  `cod_inf` INT(11) NOT NULL AUTO_INCREMENT,
  `infracao_cometida` VARCHAR(45) NOT NULL,
  `_pac` INT(11) NOT NULL,
  `_enf` INT(11) NULL DEFAULT NULL,
  `ocorrido` DATETIME NOT NULL,
  `nov_inf` BIT(1) NOT NULL,
  PRIMARY KEY (`cod_inf`),
  INDEX `fk_infracao_paciente1_idx` (`_pac` ASC),
  INDEX `fk_infracao_enfermagem1_idx` (`_enf` ASC),
  CONSTRAINT `fk_infracao_enfermagem1`
    FOREIGN KEY (`_enf`)
    REFERENCES `softklee_posichange`.`enfermagem` (`cod_enf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_infracao_paciente1`
    FOREIGN KEY (`_pac`)
    REFERENCES `softklee_posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `softklee_posichange`.`monitoramento_paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`monitoramento_paciente` (
  `cod_mon` INT(11) NOT NULL AUTO_INCREMENT,
  `des_fer_ant` VARCHAR(100) NOT NULL,
  `des_fer_atu` VARCHAR(100) NOT NULL,
  `_pac` INT(11) NOT NULL,
  PRIMARY KEY (`cod_mon`),
  UNIQUE INDEX `cod_mon_UNIQUE` (`cod_mon` ASC),
  INDEX `fk_monitoramento_paciente_paciente1_idx` (`_pac` ASC),
  CONSTRAINT `fk_monitoramento_paciente_paciente1`
    FOREIGN KEY (`_pac`)
    REFERENCES `softklee_posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `softklee_posichange`.`posicao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`posicao` (
  `cod_posicao` INT(11) NOT NULL AUTO_INCREMENT,
  `posicao` VARCHAR(50) NOT NULL,
  `imagem` LONGBLOB NOT NULL,
  PRIMARY KEY (`cod_posicao`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `softklee_posichange`.`mudancas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`mudancas` (
  `_cod_pac` INT(11) NOT NULL,
  `proxima` TIME NOT NULL,
  `_cod_posicao` INT(11) NOT NULL,
  `minimo` TIME NOT NULL,
  `ativo` BIT(1) NOT NULL,
  INDEX `fk_mudancas_paciente1_idx` (`_cod_pac` ASC),
  INDEX `fk_mudancas_posicao1_idx` (`_cod_posicao` ASC),
  CONSTRAINT `fk_mudancas_paciente1`
    FOREIGN KEY (`_cod_pac`)
    REFERENCES `softklee_posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_mudancas_posicao1`
    FOREIGN KEY (`_cod_posicao`)
    REFERENCES `softklee_posichange`.`posicao` (`cod_posicao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `softklee_posichange`.`quarto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `softklee_posichange`.`quarto` (
  `andar` VARCHAR(10) NOT NULL,
  `numero` VARCHAR(10) NOT NULL,
  `_pac` INT(11) NOT NULL,
  INDEX `fk_quarto_paciente1_idx` (`_pac` ASC),
  CONSTRAINT `fk_quarto_paciente1`
    FOREIGN KEY (`_pac`)
    REFERENCES `softklee_posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

USE `softklee_posichange` ;

-- -----------------------------------------------------
-- procedure sp_insert_atendente
-- -----------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_insert_atendente`(
	sp_nome varchar(50),
    sp_rg varchar(12),
    sp_cpf varchar(15),
    sp_login varchar(20),
    sp_senha varchar(32),
    sp_intervalo time,
    sp_turno varchar(10),
    sp_telefone varchar(15),
    sp_acesso bit(1),
    sp_cod_nivel int
)
begin
	insert into `atendimento` values(
		null,
        sp_nome,
        sp_rg,
        sp_cpf,
        sp_login,
        sp_senha,
        sp_intervalo,
        sp_turno,
        sp_telefone,
        sp_acesso,
        sp_cod_nivel
    );
	select * from `atendente` where last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insert_enfermeiro
-- -----------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_insert_enfermeiro`(
	sp_nome varchar(50),
	sp_rg varchar(12),
    sp_cpf varchar(15),
    sp_coren int,
    sp_turno varchar(10),
    sp_intervalo time,
    sp_telefone varchar(15),
    sp_code_nivel int
)
begin
insert into `enfermagem` values(
	null,
    sp_nome,
	sp_rg,
	sp_cpf,
    sp_coren,
    sp_turno,
    sp_intervalo,
    sp_telefone,
    sp_code_nivel
);
select * from `enfermagem` where last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insert_paciente
-- -----------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_insert_paciente`(
	sp_nome varchar(50),
    sp_rg varchar(12),
    sp_cpf varchar(15),
    sp_apr_fer bit,
    sp_des_fer varchar(150),
    sp_sit_pac varchar(100)
)
begin
insert into `paciente` values(
	null,
    sp_nome,
	sp_rg,
	sp_cpf,
    sp_apr_fer,
    sp_des_fer,
    sp_sit_pac
);
select * from `paciente` where last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insert_posicao
-- -----------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_insert_posicao`(
	sp_posicao varchar(50),
    sp_img longblob
)
begin
insert into `responsavel` values(
	null,
    sp_posicao,
    sp_img
);
select * from `posicao` where last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insert_responsavel
-- -----------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_insert_responsavel`(
	sp_nome varchar(50),
    sp_rg varchar(12),
    sp_cpf varchar(15),
    sp_email varchar(45),
    sp_senha varchar(20),
    sp_telefone varchar(15),
    sp_endereco varchar(200),
    sp_agendamento datetime,
    sp_acesso bit(1),
    sp_cod_pac int
)
begin
insert into `responsavel` values(
	null,
    sp_nome,
    sp_rg,
    sp_cpf,
    sp_email,
    sp_senha,
    sp_telefone,
    sp_endereco,
    sp_agendamento,
    sp_acesso,
    sp_cod_pac
);
select * from `responsavel` where last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_atendente
-- -----------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_update_atendente`(
	sp_cod int,
    sp_nome varchar(50),
    sp_senha varchar(32),
    sp_intervalo time,
    sp_turno varchar(10),
    sp_tefone varchar(15),
    sp_acesso bit(1)
)
begin
update `atendimento` set
	nome = sp_nome,
    senha = sp_senha,
    intervalo = sp_intervalo,
    turno = sp_turno,
    telefone = sp_telefone,
    pri_ace = sp_acesso
    where cod_enf = sp_cod;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_enfermeiro
-- -----------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_update_enfermeiro`(
	sp_cod int,
    sp_nome varchar(50),
    sp_turno varchar(10),
    sp_intervalo time,
    sp_tefone varchar(15)
)
begin
update `enfermagem` set
	nome = sp_nome,
    turno = sp_turno,
    intervalo = sp_intervalo,
    telefone = sp_telefone
    where cod_enf = sp_cod;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_paciente
-- -----------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_update_paciente`(
	sp_cod int,
    sp_nome varchar(50),
    sp_apr_fer bit,
    sp_des_fer varchar(150),
    sp_sit_pac varchar(100)
)
begin
update `paciente` set
	nome = sp_nome,
    apr_fer = sp_apr_fer,
    des_fer = sp_des_fer,
    sit_pac = sp_sit_pac
	where cod_pac = sp_cod;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_posicao
-- -----------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_update_posicao`(
	sp_cod int,
	sp_posicao varchar(50),
    sp_imagem longblob
)
begin
update `responsavel` set
	posicao = sp_posicao,
    imagem = sp_imagem
    where cod_posicao = sp_cod;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_responsavel
-- -----------------------------------------------------

DELIMITER $$
CREATE PROCEDURE `sp_update_responsavel`(
	sp_cod int,
	sp_nome varchar(50),
    sp_senha varchar(20),
    sp_telefone varchar(15),
    sp_email varchar(50),
    sp_acesso bit(1)
)
begin
update `responsavel` set
    nome = sp_nome,
    senha = sp_senha,
    telefone = sp_telefone,
    email = sp_email,
    pri_ace = sp_acesso
    where cod_res = sp_cod;
end$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
