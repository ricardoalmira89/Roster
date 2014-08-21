/*
Navicat MySQL Data Transfer

Source Server         : local
Source Server Version : 50524
Source Host           : localhost:3306
Source Database       : roster_mysql

Target Server Type    : MYSQL
Target Server Version : 50524
File Encoding         : 65001

Date: 2014-08-21 14:55:07
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for drop_info
-- ----------------------------
DROP TABLE IF EXISTS `drop_info`;
CREATE TABLE `drop_info` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `refund` bit(1) DEFAULT NULL,
  `amount` int(11) DEFAULT NULL,
  `date` datetime DEFAULT NULL,
  `check` text,
  `paid` bit(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of drop_info
-- ----------------------------

-- ----------------------------
-- Table structure for enrollment_officer
-- ----------------------------
DROP TABLE IF EXISTS `enrollment_officer`;
CREATE TABLE `enrollment_officer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `text` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of enrollment_officer
-- ----------------------------
INSERT INTO `enrollment_officer` VALUES ('1', 'Lars Ulrich');
INSERT INTO `enrollment_officer` VALUES ('2', 'Lars Ulrich');
INSERT INTO `enrollment_officer` VALUES ('3', 'Kirk Hammer');
INSERT INTO `enrollment_officer` VALUES ('4', 'James Hetfield');

-- ----------------------------
-- Table structure for graduated
-- ----------------------------
DROP TABLE IF EXISTS `graduated`;
CREATE TABLE `graduated` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `licensed` bit(1) DEFAULT NULL,
  `temporary` bit(1) DEFAULT NULL,
  `employment_status` text,
  `company_name` text,
  `company_address` text,
  `company_city` text,
  `company_state` text,
  `company_zip` text,
  `company_phone` text,
  `full_time` bit(1) DEFAULT NULL,
  `diploma_printed` date DEFAULT NULL,
  `start_working` date DEFAULT NULL,
  `supervisor_phone` text,
  `supervisor_name` text,
  `job_title` text,
  `employer_address` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of graduated
-- ----------------------------

-- ----------------------------
-- Table structure for locker
-- ----------------------------
DROP TABLE IF EXISTS `locker`;
CREATE TABLE `locker` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(3) NOT NULL,
  `busy` bit(1) NOT NULL DEFAULT b'0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of locker
-- ----------------------------
INSERT INTO `locker` VALUES ('1', 'A1', '');
INSERT INTO `locker` VALUES ('2', 'A2', '');
INSERT INTO `locker` VALUES ('3', 'A3', '');
INSERT INTO `locker` VALUES ('4', 'A4', '');
INSERT INTO `locker` VALUES ('5', 'A5', '');

-- ----------------------------
-- Table structure for program
-- ----------------------------
DROP TABLE IF EXISTS `program`;
CREATE TABLE `program` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` text NOT NULL,
  `slug` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of program
-- ----------------------------
INSERT INTO `program` VALUES ('1', 'Esthetics', 'EC');
INSERT INTO `program` VALUES ('2', 'Nail Speciality', 'NSC');
INSERT INTO `program` VALUES ('3', 'Skin Care 140', 'SCC');
INSERT INTO `program` VALUES ('4', 'Waxing', 'WAX');
INSERT INTO `program` VALUES ('5', 'Make Up', 'BMU-AMU');
INSERT INTO `program` VALUES ('10', 'prueba', 'wer');

-- ----------------------------
-- Table structure for schedule
-- ----------------------------
DROP TABLE IF EXISTS `schedule`;
CREATE TABLE `schedule` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` text NOT NULL,
  `slug` text NOT NULL,
  `languages` text,
  `program_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `program_id` (`program_id`),
  CONSTRAINT `schedule_ibfk_1` FOREIGN KEY (`program_id`) REFERENCES `program` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of schedule
-- ----------------------------
INSERT INTO `schedule` VALUES ('2', 'Full Time Day', 'FTD', 'EN', '1');
INSERT INTO `schedule` VALUES ('3', 'Monday and Tuesday', 'MT', 'EN/ES', '1');
INSERT INTO `schedule` VALUES ('4', 'Part Time Evening', 'PTE', 'EN', '1');
INSERT INTO `schedule` VALUES ('5', 'Part Time Weekend', 'PTW', 'EN', '1');
INSERT INTO `schedule` VALUES ('6', 'Part Time Day 9-2', 'PTD', 'EN', '1');
INSERT INTO `schedule` VALUES ('8', 'Wednesday-Friday', 'WF/S', 'ES', '1');
INSERT INTO `schedule` VALUES ('9', 'Full Time Day', 'FTD', 'EN', '2');
INSERT INTO `schedule` VALUES ('10', 'Part Time Evening', 'PTE', 'EN/ES', '2');
INSERT INTO `schedule` VALUES ('11', 'Part Time Weekend', 'PTW', 'EN', '2');
INSERT INTO `schedule` VALUES ('12', 'Full Time Day', 'FTD', 'EN', '3');
INSERT INTO `schedule` VALUES ('13', 'Part Time Evening', 'FTE', 'EN', '3');
INSERT INTO `schedule` VALUES ('15', 'Part Time Day 9-2', 'PTD', 'EN', '3');
INSERT INTO `schedule` VALUES ('16', 'Part Time Monday and Tuesday', 'MT', 'EN', '3');
INSERT INTO `schedule` VALUES ('17', 'Sunday and Monday', 'PTW/PTE', 'EN', '4');
INSERT INTO `schedule` VALUES ('18', 'Full Time Day', 'FTD', 'EN', '5');
INSERT INTO `schedule` VALUES ('19', 'Part Time Evening', 'PTE', 'EN', '5');
INSERT INTO `schedule` VALUES ('20', 'Part Time Weekend', 'PTW', 'EN', '5');
INSERT INTO `schedule` VALUES ('21', 'Part Time Monday and Tuesday', 'MT', 'EN/ES', '5');
INSERT INTO `schedule` VALUES ('22', 'Part Time Wednesday-Friday', 'WF', 'ES', '5');
INSERT INTO `schedule` VALUES ('23', 'prueba', '1222', 'es', '10');

-- ----------------------------
-- Table structure for student
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `last_name` text,
  `first_name` text,
  `email` text,
  `start_date` datetime NOT NULL,
  `end_date` datetime NOT NULL,
  `home_phone` text,
  `bussiness_phone` text,
  `cell_phone` text,
  `fax_number` text,
  `address` text,
  `city` text,
  `state` text,
  `ZIP` text,
  `country` text,
  `credit_trans` text,
  `refered` text,
  `web_page` text,
  `notes` text,
  `attachment` text,
  `location` text,
  `status` text,
  `comments` text,
  `emergency_contact_name` text,
  `emergency_contact_phone1` text,
  `emergency_contact_phone2` text,
  `emergency_contact_phone3` text,
  `cv` text,
  `cvs` bit(1) DEFAULT NULL,
  `middle_initial` text,
  `picture` text,
  `graduated_id` int(11) DEFAULT NULL,
  `payment_info` text,
  `payment_plan_amount` text,
  `dropinfo_id` int(11) DEFAULT NULL,
  `EO_id` int(11) DEFAULT NULL,
  `locker_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_student_graduated` (`graduated_id`),
  KEY `fk_student_enrollmentofficer` (`EO_id`),
  KEY `fk_sudent_dropinfo` (`dropinfo_id`),
  KEY `fk_student_locker` (`locker_id`),
  CONSTRAINT `fk_student_locker` FOREIGN KEY (`locker_id`) REFERENCES `locker` (`id`),
  CONSTRAINT `fk_student_enrollmentofficer` FOREIGN KEY (`EO_id`) REFERENCES `enrollment_officer` (`id`),
  CONSTRAINT `fk_student_graduated` FOREIGN KEY (`graduated_id`) REFERENCES `graduated` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_sudent_dropinfo` FOREIGN KEY (`dropinfo_id`) REFERENCES `drop_info` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES ('2', 'Almira', 'Ricardo', 'ricardoalmira89@bnjm.cu', '2014-07-01 11:54:15', '2014-09-01 11:54:20', '2036910', '6558999', '052789045', null, 'calle 214 A# 6707', 'Havana', null, '10400', 'Cuba', '89998877', null, 'http://www.programacion.com', null, null, null, null, '123456', null, null, null, null, null, '', null, 'C:\\Users\\cyber\\Desktop\\Roster-master\\roster visual\\bin\\Debug\\Student_Pictures\\a661d680a7f53fbe5ce9e2b0c2ca4fcc01cec1bd.png', null, 'VESID', null, null, null, '1');
INSERT INTO `student` VALUES ('3', 'Alvarez', 'Dileimis', 'lili@gmail.com', '2014-06-01 13:30:31', '2014-08-11 13:30:36', '23456789', '65432123', '056777766', null, 'calle 214 A# 6707', 'Havana', null, '10400', 'Cuba', '78887788', null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, '2');

-- ----------------------------
-- Table structure for student_schedule
-- ----------------------------
DROP TABLE IF EXISTS `student_schedule`;
CREATE TABLE `student_schedule` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `student_id` int(11) NOT NULL,
  `schedule_id` int(11) NOT NULL,
  `program_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `schedule_id` (`schedule_id`),
  KEY `student_id` (`student_id`),
  KEY `student_schedule_ibfk3` (`program_id`),
  CONSTRAINT `student_schedule_ibfk3` FOREIGN KEY (`program_id`) REFERENCES `program` (`id`),
  CONSTRAINT `student_schedule_ibfk_1` FOREIGN KEY (`schedule_id`) REFERENCES `schedule` (`id`),
  CONSTRAINT `student_schedule_ibfk_2` FOREIGN KEY (`student_id`) REFERENCES `student` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of student_schedule
-- ----------------------------
INSERT INTO `student_schedule` VALUES ('41', '2', '2', '1');
