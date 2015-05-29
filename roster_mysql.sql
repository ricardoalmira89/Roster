/*
Navicat MySQL Data Transfer

Source Server         : Localhost MySql
Source Server Version : 50525
Source Host           : localhost:3306
Source Database       : roster_mysql

Target Server Type    : MYSQL
Target Server Version : 50525
File Encoding         : 65001

Date: 2014-11-04 15:38:44
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
) ENGINE=InnoDB AUTO_INCREMENT=206 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of graduated
-- ----------------------------
INSERT INTO `graduated` VALUES ('195', '\0', '\0', '', '', '', '', '', '', '', '\0', null, null, '', '', '', '');
INSERT INTO `graduated` VALUES ('196', '\0', '\0', '', '', '', '', '', '', '', '\0', null, null, '', '', '', '');
INSERT INTO `graduated` VALUES ('197', '\0', '\0', '', '', '', '', '', '', '', '\0', null, null, '', '', '', '');
INSERT INTO `graduated` VALUES ('198', '\0', '\0', '', '', '', '', '', '', '', '\0', null, null, '', '', '', '');
INSERT INTO `graduated` VALUES ('199', '\0', '\0', '', '', '', '', '', '', '', '\0', '2014-03-03', null, '', '', '', '');
INSERT INTO `graduated` VALUES ('200', '\0', '\0', '', '', '', '', '', '', '', '\0', '2014-04-07', null, '', '', '', '');
INSERT INTO `graduated` VALUES ('201', '\0', '\0', '', '', '', '', '', '', '', '\0', null, null, '', '', '', '');
INSERT INTO `graduated` VALUES ('202', '\0', '\0', '', '', '', '', '', '', '', '\0', '2014-04-21', null, '', '', '', '');
INSERT INTO `graduated` VALUES ('203', '\0', '\0', '', '', '', '', '', '', '', '\0', null, null, '', '', '', '');
INSERT INTO `graduated` VALUES ('204', '\0', '\0', '', '', '', '', '', '', '', '\0', null, null, '', '', '', '');
INSERT INTO `graduated` VALUES ('205', '\0', '\0', '', '', '', '', '', '', '', '\0', '2014-03-24', null, '', '', '', '');

-- ----------------------------
-- Table structure for locker
-- ----------------------------
DROP TABLE IF EXISTS `locker`;
CREATE TABLE `locker` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(3) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name` (`name`) USING HASH
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of locker
-- ----------------------------
INSERT INTO `locker` VALUES ('46', 'A60');
INSERT INTO `locker` VALUES ('48', 'A63');
INSERT INTO `locker` VALUES ('45', 'B13');
INSERT INTO `locker` VALUES ('49', 'C54');
INSERT INTO `locker` VALUES ('50', 'C71');
INSERT INTO `locker` VALUES ('47', 'D5');
INSERT INTO `locker` VALUES ('51', 'D6');

-- ----------------------------
-- Table structure for program
-- ----------------------------
DROP TABLE IF EXISTS `program`;
CREATE TABLE `program` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `slug` varchar(10) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `slug` (`slug`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of program
-- ----------------------------
INSERT INTO `program` VALUES ('1', 'Esthetics', 'EC');
INSERT INTO `program` VALUES ('2', 'Nail Speciality', 'NSC');
INSERT INTO `program` VALUES ('3', 'Skin Care 140', 'SCC');
INSERT INTO `program` VALUES ('4', 'Waxing', 'WAX');
INSERT INTO `program` VALUES ('5', 'Make Up', 'BMU-AMU');
INSERT INTO `program` VALUES ('44', 'UNKNOWN', 'NS');
INSERT INTO `program` VALUES ('45', 'UNKNOWN', 'MU');
INSERT INTO `program` VALUES ('46', 'UNKNOWN', 'BMU');
INSERT INTO `program` VALUES ('47', 'UNKNOWN', 'SCC35H');
INSERT INTO `program` VALUES ('48', 'UNKNOWN', 'BAMU');
INSERT INTO `program` VALUES ('49', 'UNKNOWN', 'AMU');
INSERT INTO `program` VALUES ('50', 'UNKNOWN', 'NC');
INSERT INTO `program` VALUES ('51', 'UNKNOWN', 'ECK');
INSERT INTO `program` VALUES ('52', 'UNKNOWN', 'SCC140');

-- ----------------------------
-- Table structure for role
-- ----------------------------
DROP TABLE IF EXISTS `role`;
CREATE TABLE `role` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `access` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of role
-- ----------------------------
INSERT INTO `role` VALUES ('1', 'Admin', 'GeneralTab,EnrollmentTab,FinancialTab,ServicesTab,GraduatedTab,FindTab,DropTab,ReportingTab');
INSERT INTO `role` VALUES ('2', 'Recepcion', 'GeneralTab,FindTab');

-- ----------------------------
-- Table structure for schedule
-- ----------------------------
DROP TABLE IF EXISTS `schedule`;
CREATE TABLE `schedule` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` text NOT NULL,
  `slug` varchar(10) NOT NULL,
  `languages` text,
  `program_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`,`slug`(6)),
  KEY `program_id` (`program_id`),
  CONSTRAINT `schedule_ibfk_1` FOREIGN KEY (`program_id`) REFERENCES `program` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=latin1;

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
INSERT INTO `schedule` VALUES ('46', 'UNKNOWN', 'PTE', 'EN', '44');
INSERT INTO `schedule` VALUES ('47', 'UNKNOWN', 'FTD', 'EN', '45');
INSERT INTO `schedule` VALUES ('48', 'UNKNOWN', 'PTWF', 'ES', '1');
INSERT INTO `schedule` VALUES ('49', 'UNKNOWN', 'PTMT', 'ES', '1');
INSERT INTO `schedule` VALUES ('50', 'UNKNOWN', 'FTD', 'EN', '46');
INSERT INTO `schedule` VALUES ('51', 'UNKNOWN', 'PTW', 'EN', '47');
INSERT INTO `schedule` VALUES ('52', 'UNKNOWN', 'FTD', 'EN', '48');
INSERT INTO `schedule` VALUES ('53', 'UNKNOWN', 'AMU', 'FTD', '46');
INSERT INTO `schedule` VALUES ('54', 'UNKNOWN', 'PTW', 'EN', '49');
INSERT INTO `schedule` VALUES ('55', 'UNKNOWN', 'FTD', 'EN', '50');
INSERT INTO `schedule` VALUES ('56', 'UNKNOWN', 'WF', 'EN', '51');
INSERT INTO `schedule` VALUES ('57', 'UNKNOWN', 'FTD', 'EN', '52');

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
  `picture` longblob,
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
  `graduated_id` int(11) DEFAULT NULL,
  `payment_info` text,
  `payment_plan_amount` text,
  `dropinfo_id` int(11) DEFAULT NULL,
  `EO` varchar(255) DEFAULT NULL,
  `locker_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_student_graduated` (`graduated_id`),
  KEY `fk_student_enrollmentofficer` (`EO`),
  KEY `fk_sudent_dropinfo` (`dropinfo_id`),
  KEY `fk_student_locker` (`locker_id`),
  CONSTRAINT `fk_student_graduated` FOREIGN KEY (`graduated_id`) REFERENCES `graduated` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_student_locker` FOREIGN KEY (`locker_id`) REFERENCES `locker` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_sudent_dropinfo` FOREIGN KEY (`dropinfo_id`) REFERENCES `drop_info` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=478 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES ('453', 'SCHWARTZ', 'MICAH', 'micahschw@gmail.com', '2014-02-03 00:00:00', '2014-06-25 00:00:00', '732-513-1350', '', '732-513-1350', '', null, '1705 DORCHESTER RD', 'BROOKLYN', 'NY', '11226', '', '', '', '', '', '', 'current', null, '', null, null, null, null, '214001', '\0', 'S', null, '', null, null, 'HY', '45');
INSERT INTO `student` VALUES ('454', 'AZARASHVILI', 'IRINA', 'irinaazarashvili@yahoo.com', '2014-01-20 00:00:00', '2014-07-11 00:00:00', '', '', '718-915-2126', '', null, '64-33 99TH STREET 1E ', 'REGO PARK', 'NY', '11374', '', '', '', '', '', '', 'grad', 'Graduated', '', null, null, null, null, '214002', '\0', 'A', '195', '', null, null, 'ES', '46');
INSERT INTO `student` VALUES ('455', 'GREENFIELD', 'LESA', 'gnomedepetit@gmail.com', '2014-01-06 00:00:00', '2014-05-16 00:00:00', '347-677-2562', '', '', '', null, '60 MONITOR STREET 5D', 'BROOKLYN', 'NY', '11222', '', '', '', '', '', '', 'basement', null, 'RDS refunded 2/19/2014', null, null, null, null, '214003', '\0', 'G', null, '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('456', 'GONZALEZ', 'SILVIA', 'silvia.1103.sg@gmail.com', '2014-02-03 00:00:00', '2014-02-14 00:00:00', '(347) 596-0470', '', '347-596-0470', '', null, '30-53 82ND STREET', 'QUEENS', 'NY', '11370', '', '250H/$3125', '', '', '', '', 'basement', null, '', null, null, null, null, '214004', '', 'G', null, '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('457', 'ALVAREZ', 'JACQUELINE', 'jalvarez1009@yahoo.com', '2014-01-08 00:00:00', '2014-05-02 00:00:00', '212-567-5695', '', '917-744-5343', '', null, '4520 BROADWAY 5E', 'NEW YORK', 'NY', '10040', '', '', '', '', '', '', 'grad', 'Graduated', '', null, null, null, null, '214005', '', 'A', '196', '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('458', 'BETANCES', 'EVA', 'abetances91@gmail.com', '2014-02-24 00:00:00', '2014-12-16 00:00:00', '973-424-5067', '', '', '', null, '43 SAYRE STREET', 'NEWARK', 'NJ', '7103', '', '', '', '', '', '', 'basement', null, 'rds', null, null, null, null, '214006', '\0', 'B', null, '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('459', 'WALLACE', 'SHENIECE', 'shenieceldennis@yahoo.com', '2014-01-20 00:00:00', '2014-01-24 00:00:00', '347-262-3725', '', '', '', null, '3155 GRAND CONCOURSE', 'BRONX', 'NY', '10468', '', '', 'Bridgett McNeill', '', '', '', 'grad', 'Graduated', '', null, null, null, null, '214007', '\0', 'W', '197', '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('460', 'LEVY', 'VASINEE', 'ahmeenok@yahoo.com', '2014-02-03 00:00:00', '2014-07-25 00:00:00', '212-871-0076', '', '917-696-3487', '', null, '200 RIVERSIDE BLVD APT 2', 'NEW YORK', 'NY', '10069', '', '', '', '', '', '', 'grad', 'Graduated', '', null, null, null, null, '214008', '\0', 'L', '198', '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('461', 'DEGALE', 'YOLANDE', 'yobejon@yahoo.com', '2014-01-13 00:00:00', '2014-02-28 00:00:00', '718-857-1353', '', '347-278-4257', '', null, '17 HALSEY STREET', 'BROOKLYN', 'NY', '11216', '', '', '', '', '', '', 'grad', 'Graduated', '', null, null, null, null, '214009', '\0', 'D', '199', '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('462', 'TUMIDAJEWICZ', 'BOZENA', 'bozenatumidajewicz', '2014-02-10 00:00:00', '2014-03-13 00:00:00', '347-673-9102', '', '347-673-9102', '', null, '1007 LORIMER STREET', 'BROOKLYN', 'NY', '11222', '', '', '', '', '', '', 'grad', 'Graduated', '', null, null, null, null, '214010', '\0', 'T', '200', '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('463', 'ENACHE', 'DAFINA', 'dafina_adam81@yahoo.com', '2014-01-20 00:00:00', '2014-05-16 00:00:00', '646-256-2259', '', '', '', null, '3400 FT INDEPENDENCE ST', 'BRONX', 'NY', '10463', '', '', '', '', '', '', 'grad', 'Graduated', '', null, null, null, null, '214011', '\0', 'E', '201', '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('464', 'FUENTES', 'LIBERTAD', 'lfuentes@optonline.net', '2014-01-27 00:00:00', '2014-05-08 00:00:00', '', '', '9175603473', '', null, 'PO BOX 54', 'ORANGEBURG', 'NY', '10962', '', '', '', '', '', '', 'grad', 'Graduated', '', null, null, null, null, '214012', '', 'F', '202', '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('465', 'ANZAI', 'RISA', 'risa-anzai@hotmail.com', '2014-08-18 00:00:00', '2014-12-12 00:00:00', '917-747-5080', '', '917-747-5080', '', null, '259 W. 55TH STREET', 'NEW YORK', 'NY', '10019', '', '', '', '', '', '', '', null, 'RDS', null, null, null, null, '214013', '\0', 'A', null, '', null, null, 'HY', null);
INSERT INTO `student` VALUES ('466', 'WEINSTEIN', 'LAUREN', 'ldwmakeupdesign@aol.com', '2015-02-14 00:00:00', '2015-02-28 00:00:00', '718-996-5474', '', '917-225-9861', '', null, '275 BAY 37TH', 'BROOKLYN', 'NY', '11214', '', '250H/$2250', '', '', '', '', 'prestart', null, '', null, null, null, null, '214014', '\0', 'W', null, '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('467', 'ENCARNACION', 'GLENIS', 'glenisencarnacion@gmail.com', '2014-02-24 00:00:00', '2014-12-16 00:00:00', '718-708-4375', '', '917-436-0899', '', null, '234 NAPLES TERRACE 4C', 'BRONX', 'NY', '10463', '', '', '', '', '', '', 'current', null, '', null, null, null, null, '214015', '\0', 'E', null, '', null, null, 'CF', '47');
INSERT INTO `student` VALUES ('468', 'SWIONTKOWSKI', 'JENNIFER', 'swiontkj@verizon.net', '2014-01-20 00:00:00', '2014-01-31 00:00:00', '908-721-1360', '', '908-721-1360', '', null, '810 WILLIS PLACE ', 'ROSELLE PARK', 'NJ', '7204', '', '', '', '', '', '', 'Grad. Pending', null, '', null, null, null, null, '214016', '\0', 'S', null, '', null, null, 'HY', null);
INSERT INTO `student` VALUES ('469', 'VASSELL', 'SUZAN', 'suzanvassell@hotmail.com', '2014-02-03 00:00:00', '2014-02-14 00:00:00', '845-200-8444', '', '845-267-0221', '', null, '21 FRIEND STREET', 'CONGERS', 'NY', '10920', '', '100H/ $1250', '', '', '', '', 'grad proc', null, '', null, null, null, null, '214017', '\0', 'V', null, '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('470', 'CHARLTON', 'DIANE', 'diane.charlton@me.com', '2014-02-03 00:00:00', '2014-06-05 00:00:00', '718-249-6855', '', '', '', null, '105 ASHLAND PLACE APT12B', 'BROOKLYN', 'NY', '11201', '', '', '', '', '', '', 'basement', null, 'refunded on time', null, null, null, null, '214018', '\0', 'C', null, '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('471', 'ORTIZ ', 'MARIA AUDRA ', 'maria.ortiz48@gmail.com ', '2014-02-03 00:00:00', '2014-06-06 00:00:00', '347-356-6341', '', '516-500-9543', '', null, '238 WEST MILLER AVE', 'GARDEN CITY ', 'NY', '11530', '', '', '', '', '', '', 'grad', 'Graduated', '', null, null, null, null, '214019', '\0', 'O', '203', '', null, null, 'HY', '48');
INSERT INTO `student` VALUES ('472', 'ELIYAHU', 'SHANI', '', '2014-01-19 00:00:00', '2014-02-02 00:00:00', '347-513-1714', '', '', '', null, '235 E 95TH STREET 9F', 'NEW YORK', 'NY', '10128', '', '', '', '', '', '', 'grad', 'Graduated', '', null, null, null, null, '214020', '\0', 'E', '204', '', null, null, 'CF', null);
INSERT INTO `student` VALUES ('473', 'VASTARIOS', 'DESPINA', 'ellasitsa@mac.com', '2014-02-24 00:00:00', '2014-04-11 00:00:00', '917-225-2525', '', '718-626-3952', '', null, '22-37 80TH STREET', 'EAST ELMHURST', 'NY', '11370', '', '', '', '', '', '', 'basement', null, 'refunded on time', null, null, null, null, '214021', '\0', 'V', null, '', null, null, 'HY', null);
INSERT INTO `student` VALUES ('474', 'LENOIR BARCHI', 'SARAH', 'sarahlenoir@yahoo.fr', '2014-06-23 00:00:00', '2015-04-21 00:00:00', '347-299-2668', '', '347-299-2668', '', null, '63-19 AUSTINE STREET #APT 1F', 'REGO PARK', 'NY', '11374', '', '', 'AYAKO IN CVS', '', '', '', 'basement', null, '', null, null, null, null, '214022', '', 'L', null, '', null, null, 'HY', null);
INSERT INTO `student` VALUES ('475', 'SHIN', 'JAE KYOUNG', 'shinjky@gmail.com', '2014-02-18 00:00:00', '2014-09-11 00:00:00', '347-884-6078', '', '347-884-6078', '', null, '42-60 157TH ST. #1D', 'FLUSHING ', 'NY', '11355', '', '', '', '', '', '', 'basement', null, '', null, null, null, null, '214023', '', 'S', null, '', null, null, 'HY', '49');
INSERT INTO `student` VALUES ('476', 'MADRIGAL', 'MAUREEN', 'maureennhs@yahoo.com', '2014-02-10 00:00:00', '2014-12-18 00:00:00', '347-804-3952', '', '347-804-3952', '', null, '31-46 35TH STREET APT 3F', 'ASTORIA', 'NY', '11106', '', '', '', '', '', '', 'current', null, '', null, null, null, null, '214024', '\0', 'M', null, '', null, null, 'CF', '50');
INSERT INTO `student` VALUES ('477', 'NAHEED', 'FARAH', 'farahnaheed@gmail.com', '2014-02-03 00:00:00', '2014-03-14 00:00:00', '718-262-9781', '', '917-309-6400', '', null, '147-10 84 ROAD APT 1-J', 'BRIARWOOD', 'NY', '11435', '', '', '', '', '', '', 'grad', 'Graduated', '', null, null, null, null, '214025', '\0', 'N', '205', '', null, null, 'CF', null);

-- ----------------------------
-- Table structure for student_schedule
-- ----------------------------
DROP TABLE IF EXISTS `student_schedule`;
CREATE TABLE `student_schedule` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `student_id` int(11) DEFAULT NULL,
  `schedule_id` int(11) DEFAULT NULL,
  `program_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `schedule_id` (`schedule_id`),
  KEY `student_id` (`student_id`),
  KEY `student_schedule_ibfk3` (`program_id`),
  CONSTRAINT `student_schedule_ibfk_1` FOREIGN KEY (`schedule_id`) REFERENCES `schedule` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `student_schedule_ibfk3` FOREIGN KEY (`program_id`) REFERENCES `program` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `student_schedule_ibfk_2` FOREIGN KEY (`student_id`) REFERENCES `student` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=442 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of student_schedule
-- ----------------------------
INSERT INTO `student_schedule` VALUES ('417', '453', '6', '1');
INSERT INTO `student_schedule` VALUES ('418', '454', '6', '1');
INSERT INTO `student_schedule` VALUES ('419', '455', '4', '44');
INSERT INTO `student_schedule` VALUES ('420', '456', '2', '45');
INSERT INTO `student_schedule` VALUES ('421', '457', '48', '1');
INSERT INTO `student_schedule` VALUES ('422', '458', '49', '1');
INSERT INTO `student_schedule` VALUES ('423', '459', '2', '46');
INSERT INTO `student_schedule` VALUES ('424', '460', '6', '1');
INSERT INTO `student_schedule` VALUES ('425', '461', '2', '44');
INSERT INTO `student_schedule` VALUES ('426', '462', '4', '5');
INSERT INTO `student_schedule` VALUES ('427', '463', '2', '1');
INSERT INTO `student_schedule` VALUES ('428', '464', '4', '1');
INSERT INTO `student_schedule` VALUES ('429', '465', '2', '1');
INSERT INTO `student_schedule` VALUES ('430', '466', '5', '47');
INSERT INTO `student_schedule` VALUES ('431', '467', '49', '1');
INSERT INTO `student_schedule` VALUES ('432', '468', '2', '48');
INSERT INTO `student_schedule` VALUES ('433', '469', '53', '46');
INSERT INTO `student_schedule` VALUES ('434', '470', '2', '1');
INSERT INTO `student_schedule` VALUES ('435', '471', '2', '1');
INSERT INTO `student_schedule` VALUES ('436', '472', '5', '49');
INSERT INTO `student_schedule` VALUES ('437', '473', '2', '50');
INSERT INTO `student_schedule` VALUES ('438', '474', '49', '1');
INSERT INTO `student_schedule` VALUES ('439', '475', '22', '51');
INSERT INTO `student_schedule` VALUES ('440', '476', '4', '1');
INSERT INTO `student_schedule` VALUES ('441', '477', '2', '52');

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `full_name` varchar(255) NOT NULL,
  `role_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `role_id` (`role_id`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `role` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', 'cyber', '123', 'ricardo almira', '1');
INSERT INTO `user` VALUES ('3', 'lili', '123', 'Dileimis Alvarez', '2');

-- ----------------------------
-- View structure for studentview
-- ----------------------------
DROP VIEW IF EXISTS `studentview`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER  VIEW `studentview` AS SELECT
student_schedule.schedule_id,
CONCAT(student.first_name,' ',student.last_name) AS fullname,
CONCAT('CV# :',student.cv) AS cv,
student.cv as cv_clear,
student.picture,
CONCAT(program.`name`,'/',`schedule`.`name`) AS program_schedule_name,
CONCAT(program.`slug`,'/',`schedule`.`slug`) AS program_schedule_slug,
`schedule`.languages,
student.id,
student.last_name,
student.first_name,
student.start_date,
student.cell_phone,
program.`name` AS program_name,
program.slug AS program_slug,
`schedule`.`name` AS schedule_name,
`schedule`.slug AS schedule_slug,
program.id as 'programid',
`schedule`.id as 'scheduleid'
FROM
student_schedule
INNER JOIN student ON student_schedule.student_id = student.id
INNER JOIN `schedule` ON student_schedule.schedule_id = `schedule`.id
INNER JOIN program ON student_schedule.program_id = program.id AND `schedule`.program_id = program.id ;
