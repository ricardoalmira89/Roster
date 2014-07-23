/*
Navicat SQL Server Data Transfer

Source Server         : SQL
Source Server Version : 100000
Source Host           : DVELOP\SQLEXPRESS:1433
Source Database       : roster
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 100000
File Encoding         : 65001

Date: 2014-07-23 12:12:43
*/


-- ----------------------------
-- Table structure for Program
-- ----------------------------
DROP TABLE [dbo].[Program]
GO
CREATE TABLE [dbo].[Program] (
[id] int NOT NULL IDENTITY(1,1) ,
[name] text NOT NULL ,
[slug] text NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Program]', RESEED, 10)
GO

-- ----------------------------
-- Records of Program
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Program] ON
GO
INSERT INTO [dbo].[Program] ([id], [name], [slug]) VALUES (N'1', N'Esthetics', N'EC')
GO
GO
INSERT INTO [dbo].[Program] ([id], [name], [slug]) VALUES (N'2', N'Nail Speciality', N'NSC')
GO
GO
INSERT INTO [dbo].[Program] ([id], [name], [slug]) VALUES (N'3', N'Skin Care 140', N'SCC')
GO
GO
INSERT INTO [dbo].[Program] ([id], [name], [slug]) VALUES (N'4', N'Waxing', N'WAX')
GO
GO
INSERT INTO [dbo].[Program] ([id], [name], [slug]) VALUES (N'5', N'Make Up', N'BMU-AMU')
GO
GO
INSERT INTO [dbo].[Program] ([id], [name], [slug]) VALUES (N'10', N'prueba', N'wer')
GO
GO
SET IDENTITY_INSERT [dbo].[Program] OFF
GO

-- ----------------------------
-- Table structure for Schedule
-- ----------------------------
DROP TABLE [dbo].[Schedule]
GO
CREATE TABLE [dbo].[Schedule] (
[id] int NOT NULL IDENTITY(1,1) ,
[name] text NOT NULL ,
[slug] text NOT NULL ,
[languages] text NULL DEFAULT ('EN') ,
[program_id] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Schedule]', RESEED, 23)
GO

-- ----------------------------
-- Records of Schedule
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Schedule] ON
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'2', N'Full Time Day', N'FTD', N'EN', N'1')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'3', N'Monday and Tuesday', N'MT', N'EN/ES', N'1')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'4', N'Part Time Evening', N'PTE', N'EN', N'1')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'5', N'Part Time Weekend', N'PTW', N'EN', N'1')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'6', N'Part Time Day 9-2', N'PTD', N'EN', N'1')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'8', N'Wednesday-Friday', N'WF/S', N'ES', N'1')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'9', N'Full Time Day', N'FTD', N'EN', N'2')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'10', N'Part Time Evening', N'PTE', N'EN/ES', N'2')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'11', N'Part Time Weekend', N'PTW', N'EN', N'2')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'12', N'Full Time Day', N'FTD', N'EN', N'3')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'13', N'Part Time Evening', N'FTE', N'EN', N'3')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'15', N'Part Time Day 9-2', N'PTD', N'EN', N'3')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'16', N'Part Time Monday and Tuesday', N'MT', N'EN', N'3')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'17', N'Sunday and Monday', N'PTW/PTE', N'EN', N'4')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'18', N'Full Time Day', N'FTD', N'EN', N'5')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'19', N'Part Time Evening', N'PTE', N'EN', N'5')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'20', N'Part Time Weekend', N'PTW', N'EN', N'5')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'21', N'Part Time Monday and Tuesday', N'MT', N'EN/ES', N'5')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'22', N'Part Time Wednesday-Friday', N'WF', N'ES', N'5')
GO
GO
INSERT INTO [dbo].[Schedule] ([id], [name], [slug], [languages], [program_id]) VALUES (N'23', N'prueba', N'1222', N'es', N'10')
GO
GO
SET IDENTITY_INSERT [dbo].[Schedule] OFF
GO

-- ----------------------------
-- Table structure for Student
-- ----------------------------
DROP TABLE [dbo].[Student]
GO
CREATE TABLE [dbo].[Student] (
[id] int NOT NULL IDENTITY(1,1) ,
[last_name] text NULL ,
[first_name] text NULL ,
[email] text NULL ,
[start_date] smalldatetime NOT NULL ,
[end_date] smalldatetime NOT NULL ,
[home_phone] text NULL ,
[bussiness_phone] text NULL ,
[mobile_phone] text NULL ,
[fax_number] text NULL ,
[address] text NULL ,
[city] text NULL ,
[state] text NULL ,
[ZIP] text NULL ,
[country] text NULL ,
[company] text NULL ,
[credit_trans] text NULL ,
[refered] text NULL ,
[web_page] text NULL ,
[notes] text NULL ,
[attachment] text NULL ,
[location] text NULL ,
[locker] text NULL ,
[status] text NULL ,
[comments] text NULL ,
[EO] text NULL ,
[emergency_contact_name] text NULL ,
[emergency_contact_phone1] text NULL ,
[emergency_contact_phone2] text NULL ,
[emergency_contact_phone3] text NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Student]', RESEED, 18)
GO

-- ----------------------------
-- Records of Student
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Student] ON
GO
INSERT INTO [dbo].[Student] ([id], [last_name], [first_name], [email], [start_date], [end_date], [home_phone], [bussiness_phone], [mobile_phone], [fax_number], [address], [city], [state], [ZIP], [country], [company], [credit_trans], [refered], [web_page], [notes], [attachment], [location], [locker], [status], [comments], [EO], [emergency_contact_name], [emergency_contact_phone1], [emergency_contact_phone2], [emergency_contact_phone3]) VALUES (N'14', N'Almira', N'Ricardo', N'ricardoalmira89@bnjm.cu', N'2014-07-23 08:28:00', N'2014-07-23 08:28:00', N'-', N'78887788', N'52789045', N'-', N'calle aaa # bbb', N'Havana', N'La Lisa', N'10400', N'CUBA', N'BNJM', N'7888774455', N'¿?', N'www.programacion-cero.blogspot.com', N'NO NOTES', N'¿?', N'¿?', N'¿?', N'La Lisa', N'NO COMMENTS', N'¿?', N'-', N'-', N'-', N'-')
GO
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO

-- ----------------------------
-- Table structure for Student_Program
-- ----------------------------
DROP TABLE [dbo].[Student_Program]
GO
CREATE TABLE [dbo].[Student_Program] (
[id] int NOT NULL IDENTITY(1,1) ,
[student_id] int NOT NULL ,
[program_id] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Student_Program]', RESEED, 18)
GO

-- ----------------------------
-- Records of Student_Program
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Student_Program] ON
GO
INSERT INTO [dbo].[Student_Program] ([id], [student_id], [program_id]) VALUES (N'7', N'14', N'1')
GO
GO
INSERT INTO [dbo].[Student_Program] ([id], [student_id], [program_id]) VALUES (N'8', N'14', N'2')
GO
GO
INSERT INTO [dbo].[Student_Program] ([id], [student_id], [program_id]) VALUES (N'9', N'14', N'4')
GO
GO
INSERT INTO [dbo].[Student_Program] ([id], [student_id], [program_id]) VALUES (N'10', N'14', N'3')
GO
GO
INSERT INTO [dbo].[Student_Program] ([id], [student_id], [program_id]) VALUES (N'11', N'14', N'4')
GO
GO
INSERT INTO [dbo].[Student_Program] ([id], [student_id], [program_id]) VALUES (N'12', N'14', N'4')
GO
GO
INSERT INTO [dbo].[Student_Program] ([id], [student_id], [program_id]) VALUES (N'13', N'14', N'3')
GO
GO
SET IDENTITY_INSERT [dbo].[Student_Program] OFF
GO

-- ----------------------------
-- Table structure for Student_Schedule
-- ----------------------------
DROP TABLE [dbo].[Student_Schedule]
GO
CREATE TABLE [dbo].[Student_Schedule] (
[id] int NOT NULL IDENTITY(1,1) ,
[student_id] int NOT NULL ,
[schedule_id] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Student_Schedule]', RESEED, 17)
GO

-- ----------------------------
-- Records of Student_Schedule
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Student_Schedule] ON
GO
INSERT INTO [dbo].[Student_Schedule] ([id], [student_id], [schedule_id]) VALUES (N'6', N'14', N'2')
GO
GO
INSERT INTO [dbo].[Student_Schedule] ([id], [student_id], [schedule_id]) VALUES (N'7', N'14', N'10')
GO
GO
SET IDENTITY_INSERT [dbo].[Student_Schedule] OFF
GO

-- ----------------------------
-- Indexes structure for table Program
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Program
-- ----------------------------
ALTER TABLE [dbo].[Program] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Schedule
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Schedule
-- ----------------------------
ALTER TABLE [dbo].[Schedule] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Student
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Student_Program
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Student_Program
-- ----------------------------
ALTER TABLE [dbo].[Student_Program] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Indexes structure for table Student_Schedule
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table Student_Schedule
-- ----------------------------
ALTER TABLE [dbo].[Student_Schedule] ADD PRIMARY KEY ([id])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Schedule]
-- ----------------------------
ALTER TABLE [dbo].[Schedule] ADD FOREIGN KEY ([program_id]) REFERENCES [dbo].[Program] ([id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Student_Program]
-- ----------------------------
ALTER TABLE [dbo].[Student_Program] ADD FOREIGN KEY ([program_id]) REFERENCES [dbo].[Program] ([id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[Student_Program] ADD FOREIGN KEY ([student_id]) REFERENCES [dbo].[Student] ([id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[Student_Schedule]
-- ----------------------------
ALTER TABLE [dbo].[Student_Schedule] ADD FOREIGN KEY ([schedule_id]) REFERENCES [dbo].[Schedule] ([id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO
ALTER TABLE [dbo].[Student_Schedule] ADD FOREIGN KEY ([student_id]) REFERENCES [dbo].[Student] ([id]) ON DELETE CASCADE ON UPDATE NO ACTION
GO
