drop database afms;
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';


CREATE SCHEMA IF NOT EXISTS `afms` DEFAULT CHARACTER SET utf8 ;
USE `afms` ;

-- -----------------------------------------------------
-- Table `afms`.`audit_area_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`audit_area_t` (
  `audit_area_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'Computer generated primary key' ,
  `audit_area_name` VARCHAR(45) NOT NULL COMMENT 'Name of the audit area' ,
  `audit_area_description` TEXT NOT NULL COMMENT 'Description of a audit area' ,
  PRIMARY KEY (`audit_area_id`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`audit_document_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`audit_document_t` (
  `audit_document_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'Computer generated primary key for audit documents.' ,
  `longname` VARCHAR(40) NOT NULL COMMENT 'Long name of a document' ,
  `shortname` VARCHAR(15) NOT NULL COMMENT 'Short name of a document which are used in documentations.' ,
  `purpose` TEXT NOT NULL COMMENT 'Document purpose' ,
  PRIMARY KEY (`audit_document_id`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`auditable_unit_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`auditable_unit_t` (
  `auditable_unit_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'Unique key of a auditable unit. Computer generated. ' ,
  `name` VARCHAR(45) NOT NULL COMMENT 'Name of the Auditable Unit.' ,
  `sol` VARCHAR(10) NOT NULL COMMENT 'SOL of the Auditable Group.' ,
  `rc` VARCHAR(10) NOT NULL COMMENT 'RC of the auditable group.' ,
  `divgrp_hname` VARCHAR(45) NOT NULL COMMENT 'Name of the Division Head' ,
  `divgrp_hsolrc` VARCHAR(45) NOT NULL COMMENT 'SOL/RC of the Head' ,
  `divgrp_hemail` VARCHAR(45) NOT NULL COMMENT 'Email of the Division Head' ,
  PRIMARY KEY (`auditable_unit_id`) )
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`audit_group_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`audit_group_t` (
  `audit_group_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'Computer generated primary key.' ,
  `audit_group_name` VARCHAR(30) NOT NULL COMMENT 'Name of the audit group.' ,
  PRIMARY KEY (`audit_group_id`, `audit_group_name`) )
ENGINE = InnoDB
AUTO_INCREMENT = 9
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`engagement_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`engagement_t` (
  `engagement_ref_no` VARCHAR(15) NOT NULL COMMENT 'Primary Key of a Single Engagement. Its syntax is as follows: <Abbreviation of Audit Group>-<Date the Engagement is Created>-AutoincrementedNumber' ,
  `engagement_name` VARCHAR(60) NOT NULL COMMENT 'Name of the Engagement.' ,
  `cutoff_date` DATETIME NOT NULL COMMENT 'Cutoff Date' ,
  `engagement_age` INT NOT NULL ,
  `auditable_unit_id` INT(11) NOT NULL ,
  `audit_group_id` INT(11) NOT NULL ,
  `audit_group_name` VARCHAR(30) NOT NULL ,
  `audit_coverage` VARCHAR(45) NULL ,
  PRIMARY KEY (`engagement_ref_no`, `auditable_unit_id`, `audit_group_id`, `audit_group_name`) ,
  UNIQUE INDEX `engagement_ref_no_UNIQUE` (`engagement_ref_no` ASC) ,
  INDEX `fk_engagement_t_auditable_unit_t1_idx` (`auditable_unit_id` ASC) ,
  INDEX `fk_engagement_t_audit_group_t1_idx` (`audit_group_id` ASC, `audit_group_name` ASC) ,
  CONSTRAINT `fk_engagement_t_auditable_unit_t1`
    FOREIGN KEY (`auditable_unit_id` )
    REFERENCES `afms`.`auditable_unit_t` (`auditable_unit_id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_engagement_t_audit_group_t1`
    FOREIGN KEY (`audit_group_id` , `audit_group_name` )
    REFERENCES `afms`.`audit_group_t` (`audit_group_id` , `audit_group_name` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`audit_finding_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`audit_finding_t` (
  `afs_ref_no` VARCHAR(10) NOT NULL COMMENT 'Primary key of a audit finding.' ,
  `findings_title` VARCHAR(80) NOT NULL COMMENT 'Title of a audit finding' ,
  `risk_assessment` VARCHAR(10) NOT NULL COMMENT 'Current risk assessment.' ,
  `new_risk_assessment` VARCHAR(10) NOT NULL COMMENT 'New risk assessment' ,
  `compliance_date` DATETIME NOT NULL COMMENT 'Compliance Date of a finding\n' ,
  `audit_area` VARCHAR(30) NULL DEFAULT NULL COMMENT 'Audit area' ,
  `finding_status` VARCHAR(10) NOT NULL COMMENT 'Status of the findings' ,
  `nature_ofthe_finding` TEXT NOT NULL COMMENT 'Cause of the finding' ,
  `risk_implication` TEXT NOT NULL COMMENT 'Risk or Implication' ,
  `policy_standards` TEXT NOT NULL COMMENT 'Policy or Standards' ,
  `recommendation` TEXT NOT NULL COMMENT 'Recommendation' ,
  `mgtrap_briefdesc` TEXT NULL DEFAULT NULL COMMENT 'Management Reply/ Action Plan:\nBrief Description of the Plan' ,
  `mgtrap_person_responsible` TEXT NULL DEFAULT NULL COMMENT 'Management Reply/ Action Plan:\nPerson or Unit Responsible' ,
  `remarks` TEXT NULL DEFAULT NULL COMMENT 'Remarks' ,
  `outstanding_balance` VARCHAR(60) NULL DEFAULT NULL COMMENT 'Outstanding Balance' ,
  `attached_file` VARCHAR(60) NULL DEFAULT NULL COMMENT 'Attached File' ,
  `engagement_ref_no` VARCHAR(30) NOT NULL COMMENT 'Engagement Ref No.' ,
  `audit_area_id` INT(11) NOT NULL ,
  PRIMARY KEY (`afs_ref_no`) ,
  INDEX `fk_audit_finding_t_engagement_t1_idx` (`engagement_ref_no` ASC) ,
  INDEX `fk_audit_finding_t_audit_area1_idx` (`audit_area_id` ASC) ,
  CONSTRAINT `fk_audit_finding_t_audit_area1`
    FOREIGN KEY (`audit_area_id` )
    REFERENCES `afms`.`audit_area_t` (`audit_area_id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_audit_finding_t_engagement_t1`
    FOREIGN KEY (`engagement_ref_no` )
    REFERENCES `afms`.`engagement_t` (`engagement_ref_no` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`audit_member_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`audit_member_t` (
  `audit_member_id` INT(7) NOT NULL COMMENT 'Audit members in an audit group. Most likely auditors. Primary key of a audit member. An auditors employee number.' ,
  `surname` VARCHAR(30) NOT NULL COMMENT '	' ,
  `firstname` VARCHAR(50) NOT NULL ,
  `middlename` VARCHAR(45) NOT NULL ,
  `initials` VARCHAR(10) NOT NULL ,
  `email` VARCHAR(45) NOT NULL ,
  `isTeamLeader` TINYINT(1) NOT NULL DEFAULT '0' ,
  `audit_group_id` INT(11) NOT NULL ,
  `audit_group_name` VARCHAR(30) NOT NULL ,
  PRIMARY KEY (`audit_member_id`, `audit_group_id`, `audit_group_name`) ,
  INDEX `fk_audit_member_t_audit_group_t1_idx` (`audit_group_id` ASC, `audit_group_name` ASC) ,
  CONSTRAINT `fk_audit_member_t_audit_group_t1`
    FOREIGN KEY (`audit_group_id` , `audit_group_name` )
    REFERENCES `afms`.`audit_group_t` (`audit_group_id` , `audit_group_name` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`audit_user_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`audit_user_t` (
  `audit_user_id` INT(7) NOT NULL AUTO_INCREMENT COMMENT 'Primary key of the user.' ,
  `audit_access_rights` VARCHAR(10) NOT NULL COMMENT 'Access Rights of a user' ,
  `audit_currentpassword` TEXT NOT NULL COMMENT 'Current password' ,
  `audit_previouspass1` TEXT NULL COMMENT 'Previous password. For password cycle functionality.' ,
  `audit_previouspass2` TEXT NULL DEFAULT NULL COMMENT 'Previous password. For password cycle functionality.' ,
  `date_created` DATETIME NULL DEFAULT NULL COMMENT 'Date when the user is created' ,
  `last_update` DATETIME NULL DEFAULT NULL COMMENT 'Last update of the user\'s password' ,
  `last_login` DATETIME NULL DEFAULT NULL COMMENT 'Last login of the user' ,
  `user_status` VARCHAR(45) NULL DEFAULT NULL COMMENT 'Either locked, password expired ' ,
  `last_logout` DATETIME NULL DEFAULT NULL ,
  `audit_member_id` INT(11) NOT NULL ,
  PRIMARY KEY (`audit_user_id`, `audit_member_id`) ,
  INDEX `fk_audit_user_t_audit_member_t1_idx1` (`audit_member_id` ASC) ,
  CONSTRAINT `fk_audit_user_t_audit_member_t1`
    FOREIGN KEY (`audit_member_id` )
    REFERENCES `afms`.`audit_member_t` (`audit_member_id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`auditee_officer_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`auditee_officer_t` (
  `auditee_officer_id` INT(11) NOT NULL COMMENT 'Computer generated primary key.' ,
  `surname` VARCHAR(35) NOT NULL COMMENT 'Surname of the Auditee Officer' ,
  `firstname` VARCHAR(40) NOT NULL COMMENT 'Firstname' ,
  `middlename` VARCHAR(35) NOT NULL COMMENT 'Middlename' ,
  `initials` VARCHAR(10) NOT NULL COMMENT 'Initials' ,
  `email` VARCHAR(45) NOT NULL COMMENT 'Email' ,
  `auditable_unit_id` INT(11) NOT NULL COMMENT 'Foreign key indicating which unit the audited officer belongs ' ,
  PRIMARY KEY (`auditee_officer_id`, `auditable_unit_id`) ,
  INDEX `fk_auditee_officer_t_auditable_unit_t1_idx` (`auditable_unit_id` ASC) ,
  CONSTRAINT `fk_auditee_officer_t_auditable_unit_t1`
    FOREIGN KEY (`auditable_unit_id` )
    REFERENCES `afms`.`auditable_unit_t` (`auditable_unit_id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`auditee_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`auditee_t` (
  `auditee_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'Computer generated primary key.' ,
  `employee_name` VARCHAR(45) NOT NULL COMMENT 'Name of the audited employee' ,
  `position` VARCHAR(45) NOT NULL COMMENT 'Position of the employee in the company' ,
  `unit_assignment` VARCHAR(45) NOT NULL COMMENT 'Unit where the employee is assigned' ,
  `email` VARCHAR(45) NOT NULL COMMENT 'Email of the employee used for audit findings.' ,
  `phone_number` INT(9) NOT NULL COMMENT 'Phone number of an employee' ,
  `afs_ref_no` VARCHAR(10) NULL DEFAULT NULL ,
  PRIMARY KEY (`auditee_id`) ,
  INDEX `fk_auditee_t_audit_finding_t1_idx` (`afs_ref_no` ASC) ,
  CONSTRAINT `fk_auditee_t_audit_finding_t1`
    FOREIGN KEY (`afs_ref_no` )
    REFERENCES `afms`.`audit_finding_t` (`afs_ref_no` )
    ON DELETE SET NULL
    ON UPDATE SET NULL)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`documentation_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`documentation_t` (
  `documentation_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'Computer Generated ID.' ,
  `attachment` VARCHAR(60) NOT NULL COMMENT 'Directory path of a file that the user selected' ,
  `approver1` VARCHAR(10) NOT NULL COMMENT 'Initials of a Audit Team Leader' ,
  `approver2` VARCHAR(10) NOT NULL DEFAULT '' COMMENT 'Initials of a Audit Group Leader' ,
  `engagement_ref_no` VARCHAR(30) NOT NULL COMMENT 'Foreign key from engagement.' ,
  `audit_document_id` INT(11) NOT NULL COMMENT 'Foreign key containing the desired document.' ,
  PRIMARY KEY (`documentation_id`) ,
  INDEX `fk_documentation_t_engagement_t1_idx` (`engagement_ref_no` ASC) ,
  INDEX `fk_documentation_t_audit_document_t1_idx` (`audit_document_id` ASC) ,
  CONSTRAINT `fk_documentation_t_audit_document_t1`
    FOREIGN KEY (`audit_document_id` )
    REFERENCES `afms`.`audit_document_t` (`audit_document_id` )
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_documentation_t_engagement_t1`
    FOREIGN KEY (`engagement_ref_no` )
    REFERENCES `afms`.`engagement_t` (`engagement_ref_no` )
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`user_history_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`user_history_t` (
  `user_history_id` INT(11) NOT NULL AUTO_INCREMENT COMMENT 'Computer generated user history entry' ,
  `usr_details` VARCHAR(100) NULL DEFAULT NULL COMMENT 'Details of the user.' ,
  `usr_time` DATETIME NULL DEFAULT NULL COMMENT 'Time of the entry.' ,
  `usr_login` VARCHAR(45) NULL ,
  `user_history_tcol` VARCHAR(45) NULL ,
  `audit_user_id` INT(11) NOT NULL ,
  `audit_member_id` INT(11) NOT NULL ,
  `module` VARCHAR(45) NOT NULL ,
  `header` VARCHAR(45) NOT NULL ,
  `subheader` VARCHAR(45) NULL ,
  `action` VARCHAR(45) NULL ,
  `logout` VARCHAR(45) NULL ,
  PRIMARY KEY (`user_history_id`, `audit_user_id`, `audit_member_id`) ,
  INDEX `fk_user_history_t_audit_user_t1_idx` (`audit_user_id` ASC, `audit_member_id` ASC) ,
  CONSTRAINT `fk_user_history_t_audit_user_t1`
    FOREIGN KEY (`audit_user_id` , `audit_member_id` )
    REFERENCES `afms`.`audit_user_t` (`audit_user_id` , `audit_member_id` )
    ON DELETE RESTRICT
    ON UPDATE RESTRICT)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `afms`.`officer_involved_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`officer_involved_t` (
  `engagement_ref_no` VARCHAR(15) NOT NULL ,
  `auditee_officer_id` INT(11) NOT NULL ,
  INDEX `fk_officer_involved_engagement_t1_idx` (`engagement_ref_no` ASC) ,
  INDEX `fk_officer_involved_auditee_officer_t1_idx` (`auditee_officer_id` ASC) ,
  CONSTRAINT `fk_officer_involved_engagement_t1`
    FOREIGN KEY (`engagement_ref_no` )
    REFERENCES `afms`.`engagement_t` (`engagement_ref_no` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_officer_involved_auditee_officer_t1`
    FOREIGN KEY (`auditee_officer_id` )
    REFERENCES `afms`.`auditee_officer_t` (`auditee_officer_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `afms`.`audit_member_involved_t`
-- -----------------------------------------------------
CREATE  TABLE IF NOT EXISTS `afms`.`audit_member_involved_t` (
  `engagement_ref_no` VARCHAR(15) NOT NULL ,
  `audit_member_id` INT(11) NOT NULL ,
  INDEX `fk_audit_member_involved_t_engagement_t1_idx` (`engagement_ref_no` ASC) ,
  INDEX `fk_audit_member_involved_t_audit_member_t1_idx` (`audit_member_id` ASC) ,
  CONSTRAINT `fk_audit_member_involved_t_engagement_t1`
    FOREIGN KEY (`engagement_ref_no` )
    REFERENCES `afms`.`engagement_t` (`engagement_ref_no` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_audit_member_involved_t_audit_member_t1`
    FOREIGN KEY (`audit_member_id` )
    REFERENCES `afms`.`audit_member_t` (`audit_member_id` )
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `afms` ;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
