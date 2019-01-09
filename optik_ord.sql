-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: optik
-- ------------------------------------------------------
-- Server version	5.5.23

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
-- Table structure for table `ord`
--

DROP TABLE IF EXISTS `ord`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ord` (
  `ID_or` tinyint(4) NOT NULL AUTO_INCREMENT,
  `ID_s` tinyint(4) NOT NULL,
  `ID_e` tinyint(4) NOT NULL,
  `ID_c` tinyint(4) DEFAULT NULL,
  `Data_or` char(10) NOT NULL,
  PRIMARY KEY (`ID_or`),
  KEY `ID_e` (`ID_e`),
  KEY `ID_c` (`ID_c`),
  KEY `ID_s` (`ID_s`),
  CONSTRAINT `ord_ibfk_2` FOREIGN KEY (`ID_e`) REFERENCES `employes` (`ID_e`),
  CONSTRAINT `ord_ibfk_3` FOREIGN KEY (`ID_c`) REFERENCES `clients` (`ID_C`),
  CONSTRAINT `ord_ibfk_4` FOREIGN KEY (`ID_s`) REFERENCES `spectacles` (`ID_s`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ord`
--

LOCK TABLES `ord` WRITE;
/*!40000 ALTER TABLE `ord` DISABLE KEYS */;
INSERT INTO `ord` VALUES (2,3,3,3,'2018-03-04'),(3,2,3,2,'2017-03-04'),(5,4,3,5,'2017-03-04'),(6,2,3,4,'2017-03-04'),(7,4,3,5,'2017-03-04'),(9,6,3,1,'2017-03-04'),(10,7,3,2,'2017-03-04'),(11,8,3,2,'2017-03-04'),(12,8,3,5,'2017-02-21'),(13,9,2,2,'2022-05-20'),(14,12,1,1,'2022-05-20'),(15,12,1,1,'2022-05-20'),(16,7,1,1,'2022-05-20'),(24,11,1,1,'2022-05-20'),(25,11,1,1,'2022-05-20'),(26,10,3,3,'24.05.2018'),(27,10,2,3,'24.05.2018'),(28,10,2,4,'24.05.2018'),(29,10,2,2,'24.05.2018'),(30,12,2,2,'24.05.2018'),(31,10,2,2,'24.05.2018'),(32,12,2,2,'24.05.2018'),(33,10,2,2,'24.05.2018'),(34,13,2,2,'24.05.2018'),(35,7,2,2,'24.05.2018'),(36,10,1,1,'24.05.2018'),(37,7,1,6,'24.05.2018'),(38,7,1,6,'24.05.2018'),(39,7,1,5,'25.05.2018'),(40,7,2,2,'06.06.2018'),(41,4,1,3,'20.11.2018');
/*!40000 ALTER TABLE `ord` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-09  3:27:18
