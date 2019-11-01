-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema posichange
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema posichange
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `posichange` DEFAULT CHARACTER SET utf8 ;
USE `posichange` ;

-- -----------------------------------------------------
-- Table `posichange`.`atendimento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`atendimento` (
  `cod_ate` INT(11) NOT NULL AUTO_INCREMENT ,
  `nome` VARCHAR(50) NOT NULL ,
  `login` VARCHAR(20) NOT NULL ,
  `senha` VARCHAR(32) NOT NULL ,
  `intervalo` TIME NOT NULL ,
  `turno` VARCHAR(10) NOT NULL ,
  `telefone` VARCHAR(15) NULL DEFAULT NULL ,
  `pri_ace` BIT(1) NOT NULL ,
  PRIMARY KEY (`cod_ate`, `intervalo`)  ,
  UNIQUE INDEX `login_UNIQUE` (`login` ASC)  ,
  UNIQUE INDEX `cod_ate_UNIQUE` (`cod_ate` ASC)  )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`nivel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`nivel` (
  `cod_nivel` INT(11) NOT NULL AUTO_INCREMENT ,
  `nivel` VARCHAR(20) NOT NULL ,
  `sigla` CHAR(3) NOT NULL ,
  PRIMARY KEY (`cod_nivel`)  )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`enfermagem`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`enfermagem` (
  `cod_enf` INT(11) NOT NULL AUTO_INCREMENT ,
  `nome` VARCHAR(50) NOT NULL ,
  `coren` INT(11) NOT NULL ,
  `turno` VARCHAR(10) NOT NULL ,
  `intervalo` TIME NOT NULL ,
  `telefone` VARCHAR(15) NULL DEFAULT NULL ,
  `_nivel` INT(11) NOT NULL ,
  PRIMARY KEY (`cod_enf`)  ,
  UNIQUE INDEX `coren_UNIQUE` (`coren` ASC)  ,
  UNIQUE INDEX `cod_enf_UNIQUE` (`cod_enf` ASC)  ,
  INDEX `fk_enfermagem_nivel1_idx` (`_nivel` ASC)  ,
  CONSTRAINT `fk_enfermagem_nivel1`
    FOREIGN KEY (`_nivel`)
    REFERENCES `posichange`.`nivel` (`cod_nivel`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`paciente` (
  `cod_pac` INT(11) NOT NULL AUTO_INCREMENT ,
  `nome` VARCHAR(50) NOT NULL ,
  `apr_fer` BIT(1) NOT NULL ,
  `des_fer` VARCHAR(150) NULL DEFAULT NULL ,
  `sit_pac` VARCHAR(300) NOT NULL ,
  PRIMARY KEY (`cod_pac`)  ,
  UNIQUE INDEX `cod_pac_UNIQUE` (`cod_pac` ASC)  )
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`historico_paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`historico_paciente` (
  `cod_his_pac` INT(11) NOT NULL AUTO_INCREMENT ,
  `razao` VARCHAR(100) NULL DEFAULT NULL ,
  `_pac` INT(11) NOT NULL ,
  `hora_reg` DATETIME NOT NULL ,
  PRIMARY KEY (`cod_his_pac`)  ,
  UNIQUE INDEX `cod_his_pac_UNIQUE` (`cod_his_pac` ASC)  ,
  INDEX `fk_historico_paciente_paciente1_idx` (`_pac` ASC)  ,
  CONSTRAINT `fk_historico_paciente_paciente1`
    FOREIGN KEY (`_pac`)
    REFERENCES `posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`infracao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`infracao` (
  `cod_inf` INT(11) NOT NULL AUTO_INCREMENT ,
  `infracao_cometida` VARCHAR(45) NOT NULL ,
  `_pac` INT(11) NOT NULL ,
  `_enf` INT(11) NOT NULL ,
  PRIMARY KEY (`cod_inf`)  ,
  INDEX `fk_infracao_paciente1_idx` (`_pac` ASC)  ,
  INDEX `fk_infracao_enfermagem1_idx` (`_enf` ASC)  ,
  CONSTRAINT `fk_infracao_enfermagem1`
    FOREIGN KEY (`_enf`)
    REFERENCES `posichange`.`enfermagem` (`cod_enf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_infracao_paciente1`
    FOREIGN KEY (`_pac`)
    REFERENCES `posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`monitoramento_paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`monitoramento_paciente` (
  `cod_mon` INT(11) NOT NULL AUTO_INCREMENT ,
  `des_fer_ant` VARCHAR(100) NOT NULL ,
  `des_fer_atu` VARCHAR(100) NOT NULL ,
  `_pac` INT(11) NOT NULL ,
  PRIMARY KEY (`cod_mon`)  ,
  UNIQUE INDEX `cod_mon_UNIQUE` (`cod_mon` ASC)  ,
  INDEX `fk_monitoramento_paciente_paciente1_idx` (`_pac` ASC)  ,
  CONSTRAINT `fk_monitoramento_paciente_paciente1`
    FOREIGN KEY (`_pac`)
    REFERENCES `posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`posicao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`posicao` (
  `cod_posicao` INT(11) NOT NULL AUTO_INCREMENT ,
  `posicao` VARCHAR(50) NOT NULL ,
  PRIMARY KEY (`cod_posicao`)  )
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`quarto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`quarto` (
  `andar` VARCHAR(10) NOT NULL ,
  `numero` VARCHAR(10) NOT NULL ,
  `_pac` INT(11) NOT NULL ,
  INDEX `fk_quarto_paciente1_idx` (`_pac` ASC)  ,
  CONSTRAINT `fk_quarto_paciente1`
    FOREIGN KEY (`_pac`)
    REFERENCES `posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`responsavel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`responsavel` (
  `cod_res` INT(11) NOT NULL AUTO_INCREMENT ,
  `nome` VARCHAR(50) NOT NULL ,
  `rg` VARCHAR(13) NOT NULL ,
  `cpf` VARCHAR(14) NOT NULL ,
  `agendamento` DATETIME NOT NULL ,
  `senha` VARCHAR(20) NOT NULL ,
  `telefone` VARCHAR(15) NULL DEFAULT NULL ,
  `email` VARCHAR(45) NOT NULL ,
  `pri_ace` BIT(1) NULL DEFAULT NULL ,
  `_pac` INT(11) NOT NULL ,
  PRIMARY KEY (`cod_res`)  ,
  UNIQUE INDEX `rg_UNIQUE` (`rg` ASC)  ,
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC)  ,
  UNIQUE INDEX `cod_res_UNIQUE` (`cod_res` ASC)  ,
  INDEX `fk_responsavel_paciente1_idx` (`_pac` ASC)  ,
  CONSTRAINT `fk_responsavel_paciente1`
    FOREIGN KEY (`_pac`)
    REFERENCES `posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`mudancas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`mudancas` (
  `_cod_pac` INT(11) NOT NULL ,
  `_cod_posicao` INT(11) NOT NULL ,
  INDEX `fk_mudancas_paciente1_idx` (`_cod_pac` ASC)  ,
  INDEX `fk_mudancas_posicao1_idx` (`_cod_posicao` ASC)  ,
  CONSTRAINT `fk_mudancas_paciente1`
    FOREIGN KEY (`_cod_pac`)
    REFERENCES `posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_mudancas_posicao1`
    FOREIGN KEY (`_cod_posicao`)
    REFERENCES `posichange`.`posicao` (`cod_posicao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `posichange` ;

-- -----------------------------------------------------
-- procedure sp_insert_atendente
-- -----------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_atendente`(
	sp_nome varchar(50),
    sp_login varchar(20),
    sp_senha varchar(32),
    sp_intervalo time,
    sp_turno varchar(10),
    sp_telefone varchar(15),
    sp_acesso bit(1)
)
begin
	insert into `atendimento` values(
		null,
        sp_nome,
        sp_login,
        sp_senha,
        sp_intervalo,
        sp_turno,
        sp_telefone
    );
	select * from `atendente` where last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insert_enfermeiro
-- -----------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_enfermeiro`(
	sp_nome varchar(50),
    sp_coren int,
    sp_turno varchar(10),
    sp_intervalo time,
    sp_telefone varchar(15),
    sp_code_nivel int
)
begin
insert into `enfermagem` values(
	null,
    spnome,
    spcoren,
    spturno,
    spintervalo,
    sptelefone,
    sp_cod_nivel
);
select * from `enfermagem` where last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insert_paciente
-- -----------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_paciente`(
	sp_nome varchar(50),
    sp_apr_fer bit,
    sp_des_fer varchar(150),
    sp_sit_pac varchar(100),
    sp_cod_pos int
)
begin
insert into `paciente` values(
	null,
    sp_nome,
    sp_apr_fer,
    sp_des_fer,
    sp_sit_pac,
    sp_cod_pos
);
select * from `paciente` where last_insert_id();
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insert_responsavel
-- -----------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_responsavel`(
	sp_nome varchar(50),
    sp_email varchar(45),
    sp_senha varchar(20),
    sp_rg varchar(13),
    sp_cpf varchar(14),
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
    sp_email,
    sp_senha,
    sp_rg,
    sp_cpf,
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

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_atendente`(
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

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_enfermeiro`(
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

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_paciente`(
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
-- procedure sp_update_responsavel
-- -----------------------------------------------------

DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_responsavel`(
	sp_cod int,
	sp_nome varchar(50),
    sp_senha varchar(20),
    sp_telefone varchar(15),
    sp_endereco varchar(200),
    sp_agendamento datetime,
    sp_acesso bit(1)
)
begin
update `responsavel` set
    nome = sp_nome,
    senha = sp_senha,
    telefone = sp_telefone,
    endereco = sp_endereco,
    agendamento = sp_agendamento,
    pri_ace = sp_acesso
    where cod_res = sp_cod;
end$$

DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
