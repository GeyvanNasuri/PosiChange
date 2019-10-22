-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
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
  `nome_ate` VARCHAR(50) NOT NULL ,
  `email_ate` VARCHAR(50) NOT NULL ,
  `login` VARCHAR(20) NOT NULL ,
  `senha_ate` VARCHAR(32) NOT NULL ,
  `intervalo_ate` TIME NOT NULL ,
  `turno_ate` VARCHAR(10) NOT NULL ,
  `telefone_ate` VARCHAR(15) NULL ,
  PRIMARY KEY (`cod_ate`)  ,
  UNIQUE INDEX `login_UNIQUE` (`login` ASC)  )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`nivel`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`nivel` (
  `cod_nivel` INT(11) NOT NULL ,
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
  `nome_enf` VARCHAR(50) NOT NULL ,
  `coren` INT(11) NOT NULL ,
  `turno_enf` VARCHAR(10) NOT NULL ,
  `intervalo_enf` TIME NOT NULL ,
  `telefone_enf` VARCHAR(15) NULL ,
  `cod_nivel_enf` INT(11) NOT NULL ,
  PRIMARY KEY (`cod_enf`)  ,
  UNIQUE INDEX `coren_UNIQUE` (`coren` ASC)  ,
  INDEX `fk_enfermagem_nivel1_idx` (`cod_nivel_enf` ASC)  ,
  CONSTRAINT `fk_enfermagem_nivel1`
    FOREIGN KEY (`cod_nivel_enf`)
    REFERENCES `posichange`.`nivel` (`cod_nivel`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`historicopaciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`historicopaciente` (
  `cod_hist_pac` INT(11) NOT NULL ,
  `nomePaciente` VARCHAR(50) NOT NULL ,
  `razao` VARCHAR(100) NULL DEFAULT NULL ,
  `horaRegistro` DATETIME NOT NULL ,
  `desc_feri_ant` VARCHAR(300) NULL DEFAULT NULL ,
  `desc_feri_atu` VARCHAR(300) NULL DEFAULT NULL ,
  `alteracao` VARCHAR(300) NULL DEFAULT NULL ,
  PRIMARY KEY (`cod_hist_pac`)  )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`posicao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`posicao` (
  `cod_pos` INT(11) NOT NULL AUTO_INCREMENT ,
  `Posicao` VARCHAR(30) NOT NULL ,
  PRIMARY KEY (`cod_pos`)  )
ENGINE = InnoDB
AUTO_INCREMENT = 4
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`paciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`paciente` (
  `cod_pac` INT(11) NOT NULL AUTO_INCREMENT ,
  `nome_pac` VARCHAR(50) NOT NULL ,
  `apr_fer_pac` BIT(1) NOT NULL ,
  `des_fer_pac` VARCHAR(150) NULL ,
  `sit_pac` VARCHAR(100) NOT NULL ,
  `telefone_pac` VARCHAR(15) NULL ,
  `endereco_pac` VARCHAR(200) NULL DEFAULT NULL ,
  `cod_pos_pac` INT(11) NOT NULL ,
  PRIMARY KEY (`cod_pac`)  ,
  INDEX `fk_paciente_posicao_idx` (`cod_pos_pac` ASC)  ,
  CONSTRAINT `fk_paciente_posicao`
    FOREIGN KEY (`cod_pos_pac`)
    REFERENCES `posichange`.`posicao` (`cod_pos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`monitoramentopaciente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`monitoramentopaciente` (
  `cod_mon_pac` INT(11) NOT NULL AUTO_INCREMENT ,
  `pos_ant` VARCHAR(20) NOT NULL ,
  `pos_atu` VARCHAR(20) NOT NULL ,
  `infracao` BIT(1) NULL DEFAULT NULL ,
  `tipo_infracao` VARCHAR(55) NULL DEFAULT NULL ,
  `cod_pac` INT(11) NOT NULL ,
  `cod_enf` INT(11) NOT NULL ,
  PRIMARY KEY (`cod_mon_pac`)  ,
  INDEX `fk_monitoramentopaciente_paciente1_idx` (`cod_pac` ASC)  ,
  INDEX `fk_monitoramentopaciente_enfermagem1_idx` (`cod_enf` ASC)  ,
  CONSTRAINT `fk_monitoramentopaciente_enfermagem1`
    FOREIGN KEY (`cod_enf`)
    REFERENCES `posichange`.`enfermagem` (`cod_enf`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_monitoramentopaciente_paciente1`
    FOREIGN KEY (`cod_pac`)
    REFERENCES `posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `posichange`.`quarto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `posichange`.`quarto` (
  `andar` VARCHAR(10) NOT NULL ,
  `n_quarto` VARCHAR(10) NOT NULL ,
  `cod_pac_quarto` INT(11) NOT NULL ,
  INDEX `fk_quarto_paciente1_idx` (`cod_pac_quarto` ASC)  ,
  CONSTRAINT `fk_quarto_paciente1`
    FOREIGN KEY (`cod_pac_quarto`)
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
  `nome_res` VARCHAR(50) NOT NULL ,
  `email_res` VARCHAR(45) NOT NULL ,
  `senha_res` VARCHAR(20) NOT NULL ,
  `rg_res` VARCHAR(13) NOT NULL ,
  `cpf_res` VARCHAR(14) NOT NULL ,
  `telefone_res` VARCHAR(15) NOT NULL ,
  `endreco_res` VARCHAR(200) NOT NULL ,
  `agendamento` DATETIME NOT NULL ,
  `cod_pac` INT(11) NOT NULL ,
  PRIMARY KEY (`cod_res`)  ,
  UNIQUE INDEX `rg_UNIQUE` (`rg_res` ASC)  ,
  UNIQUE INDEX `cpf_UNIQUE` (`cpf_res` ASC)  ,
  INDEX `fk_responsavel_paciente1_idx` (`cod_pac` ASC)  ,
  CONSTRAINT `fk_responsavel_paciente1`
    FOREIGN KEY (`cod_pac`)
    REFERENCES `posichange`.`paciente` (`cod_pac`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- procedure sp_insert_atendente
-- -----------------------------------------------------

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_atendente`(
	sp_nome varchar(50),
    sp_email varchar(50),
    sp_login varchar(20),
    sp_senha varchar(32),
    sp_intervalo time,
    sp_turno varchar(10),
    sp_telefone varchar(15)
)
begin
insert into `atendimento` values(
	null,
    sp_nome,
    sp_email,
    sp_login,
    sp_senha,
    sp_intervalo,
    sp_turno,
    sp_telefone
);
select * from `atendimento` where last_insert_id();

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
    sp_nome,
    sp_coren,
    sp_turno,
    sp_intervalo,
    sp_telefone,
    sp_cod_nivel
);
select * from `enfermagem` where last_insert_id();

end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_insert_paciente
-- -----------------------------------------------------

DELIMITER $$
USE `posichange`$$
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
USE `posichange`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_insert_responsavel`(
	sp_nome varchar(50),
    sp_email varchar(45),
    sp_senha varchar(20),
    sp_rg varchar(13),
    sp_cpf varchar(14),
    sp_telefone varchar(15),
    sp_endereco varchar(200),
    sp_agendamento datetime,
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
    sp_cod_pac
);
select * from `responsavel` where last_insert_id();

end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_atendente
-- -----------------------------------------------------

DELIMITER $$
USE `posichange`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_update_atendente`(
	sp_cod int,
    sp_nome varchar(50),
    sp_email varchar(50),
    sp_login varchar(20),
    sp_senha varchar(32),
    sp_intervalo time,
    sp_turno varchar(10),
    sp_telefone varchar(15)
)
begin
update `atendimento` set 
	nome = sp_nome,
    email = sp_email,
    senha = sp_senha,
    intervalo = sp_intervalo,
    turno = sp_turno,
    telefone = sp_telefone
    where cod_ate = sp_cod;
end$$

DELIMITER ;

-- -----------------------------------------------------
-- procedure sp_update_enfermeiro
-- -----------------------------------------------------

DELIMITER $$
USE `posichange`$$
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
    sp_email varchar(45),
    sp_senha varchar(20),
    sp_telefone varchar(15),
    sp_endereco varchar(200),
    sp_agendamento datetime
)
begin
update `responsavel` set
	nome = sp_nome,
    email = sp_email,
    senha = sp_senha,
    telefone = sp_telefone,
    endereco = sp_endereco,
    agendamento = sp_agendamento
	where cod_res = sp_cod;

end$$

DELIMITER ;