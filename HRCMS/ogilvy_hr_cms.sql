-- MySQL dump 10.13  Distrib 5.5.27, for Win32 (x86)
--
-- Host: localhost    Database: ogilvy_hr_cms
-- ------------------------------------------------------
-- Server version	5.5.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `interviews`
--

DROP TABLE IF EXISTS `interviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `interviews` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `resume_id` int(11) DEFAULT NULL,
  `comment` text,
  `interviewer` text,
  `date` date DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `resume_id` (`resume_id`),
  CONSTRAINT `interviews_ibfk_1` FOREIGN KEY (`resume_id`) REFERENCES `resumes` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `interviews`
--

LOCK TABLES `interviews` WRITE;
/*!40000 ALTER TABLE `interviews` DISABLE KEYS */;
INSERT INTO `interviews` VALUES (1,8,'Mandog','Mando','2013-05-02'),(2,8,'Raymond','RJ','0000-00-00'),(4,8,'Test','Tester','2013-05-02');
/*!40000 ALTER TABLE `interviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `resume_files`
--

DROP TABLE IF EXISTS `resume_files`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `resume_files` (
  `id` int(11) NOT NULL,
  `file` longblob,
  `filename` text,
  `type` text,
  UNIQUE KEY `id` (`id`),
  CONSTRAINT `resume_files_ibfk_1` FOREIGN KEY (`id`) REFERENCES `resumes` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `resume_files`
--

LOCK TABLES `resume_files` WRITE;
/*!40000 ALTER TABLE `resume_files` DISABLE KEYS */;
INSERT INTO `resume_files` VALUES (8,'<?xml version=\"1.0\" encoding=\"UTF-8\" ?>\n<AlcoholImageFileList version=\"1.1\">\n  <ImgFolder id=\"0\">\n    <ImgFile id=\"0\" Description=\"NFSMW_DISC1\" Path=\"F:\\Games\\Need For Speed Most Wanted Black Edition\\CD1\\NFSMW_DISC1.mds\" />\n    <ImgFile id=\"1\" Description=\"NFSMW_DISC2\" Path=\"F:\\Games\\Need For Speed Most Wanted Black Edition\\CD2\\NFSMW_DISC2.mds\" />\n    <ImgFile id=\"2\" Description=\"NFSMW_DISC3\" Path=\"F:\\Games\\Need For Speed Most Wanted Black Edition\\CD3\\NFSMW_DISC3.mds\" />\n    <ImgFile id=\"3\" Description=\"NFSMW_DISC4\" Path=\"F:\\Games\\Need For Speed Most Wanted Black Edition\\CD4\\NFSMW_DISC4.mds\" />\n  </ImgFolder>\n</AlcoholImageFileList>\n','ax_files.xml','text/xml');
/*!40000 ALTER TABLE `resume_files` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `resumes`
--

DROP TABLE IF EXISTS `resumes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `resumes` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `last_name` text,
  `first_name` text,
  `mi` text,
  `birthdate` date DEFAULT NULL,
  `address` text,
  `tel_no` text,
  `cell_no` text,
  `email` text,
  `nationality` text,
  `school` text,
  `course` text,
  `year_graduated` year(4) DEFAULT NULL,
  `skills_interests` text,
  `position` text,
  `org` text,
  `is_interviewed` enum('Y','N') DEFAULT 'N',
  `date_interviewed` date DEFAULT NULL,
  `is_hired` enum('Y','N') DEFAULT 'N',
  `date_hired` date DEFAULT NULL,
  `date_added` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `resumes`
--

LOCK TABLES `resumes` WRITE;
/*!40000 ALTER TABLE `resumes` DISABLE KEYS */;
INSERT INTO `resumes` VALUES (8,'Cruz','Raymond','C','1993-11-13','Cainta','655-0000','09178111111','rjncruz@gmail.com','Filipino','Ateneo de Manila University','BS Management Information Systems',2014,'Cars, Sports','Intern','MISA','Y','0000-00-00','Y','2013-04-10','2013-05-02 16:00:00'),(9,'Valena','Mando','O','1992-02-09','Marikina City','3697520','09166814335','manolo.valena@gmail.com','Fil123','ADMU','MIS',2113,'Men','Helicopter pilot','Dollhouse','Y','2013-01-01','N','2013-01-02','2013-04-19 09:10:01'),(10,'Mallari','Eyana Gail','G','1993-12-30','Pasig','641','09166814335','eyana@gmail.com','Filipino','Ateneo de Manila University','BS Management Information Systems',2015,'being awesome','Digital Producer','MISA','Y','2013-04-02','Y','2013-01-02','2013-04-30 08:06:54');
/*!40000 ALTER TABLE `resumes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `user_type` enum('a','v') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('user','password','v'),('rj','rjcruz','a');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `work_history`
--

DROP TABLE IF EXISTS `work_history`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `work_history` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `resume_id` int(11) NOT NULL,
  `company` text,
  `position` text,
  `duration_start` date DEFAULT NULL,
  `duration_end` date DEFAULT NULL,
  `description` text,
  PRIMARY KEY (`id`),
  KEY `resume_id` (`resume_id`),
  CONSTRAINT `work_history_ibfk_1` FOREIGN KEY (`resume_id`) REFERENCES `resumes` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `work_history`
--

LOCK TABLES `work_history` WRITE;
/*!40000 ALTER TABLE `work_history` DISABLE KEYS */;
INSERT INTO `work_history` VALUES (1,8,'Ateneo de Manila University','Business Process Analyst','2012-06-01','2012-10-00','BPM group project\r\nManly Plastics Inc.'),(2,8,'ClickOne','System Developer','2012-06-00','2013-03-00','SAD class'),(3,9,'Adonis','Customer Relations Officer','2013-04-01','2013-04-30',':)'),(4,9,'Adonis','','2001-08-09','2004-02-19',''),(5,8,'OgilvyOne','Intern','2013-04-16','2013-05-31','Digital production'),(6,10,'OgilvyOne','D','2013-04-01','2013-05-15','m/'),(7,10,'MISA','i','2013-04-15','2013-04-30','Coolest president');
/*!40000 ALTER TABLE `work_history` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-05-07  9:19:39
