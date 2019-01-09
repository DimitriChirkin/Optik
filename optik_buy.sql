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
-- Table structure for table `buy`
--

DROP TABLE IF EXISTS `buy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `buy` (
  `ID_b` tinyint(4) NOT NULL AUTO_INCREMENT,
  `ID_l` tinyint(4) DEFAULT NULL,
  `ID_o` tinyint(4) DEFAULT NULL,
  `ID_e` tinyint(4) NOT NULL,
  `ID_c` tinyint(4) DEFAULT NULL,
  `Data_or` date DEFAULT NULL,
  `Prodano` tinyint(2) DEFAULT NULL,
  PRIMARY KEY (`ID_b`),
  KEY `ID_e` (`ID_e`),
  KEY `ID_c` (`ID_c`),
  KEY `ID_l` (`ID_l`),
  KEY `ID_o` (`ID_o`),
  CONSTRAINT `buy_ibfk_1` FOREIGN KEY (`ID_e`) REFERENCES `employes` (`ID_e`),
  CONSTRAINT `buy_ibfk_2` FOREIGN KEY (`ID_c`) REFERENCES `clients` (`ID_C`),
  CONSTRAINT `buy_ibfk_3` FOREIGN KEY (`ID_l`) REFERENCES `linzi` (`ID_l`),
  CONSTRAINT `buy_ibfk_4` FOREIGN KEY (`ID_o`) REFERENCES `opr` (`ID_o`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `buy`
--

LOCK TABLES `buy` WRITE;
/*!40000 ALTER TABLE `buy` DISABLE KEYS */;
INSERT INTO `buy` VALUES (2,2,1,3,2,'2017-04-26',1),(3,3,2,3,3,'2017-03-19',1),(4,4,2,3,4,'2017-05-07',1),(5,5,2,3,5,'2017-09-12',1),(7,7,4,3,4,'2017-05-13',1),(8,8,4,3,3,'2018-04-03',1),(9,9,4,3,2,'2018-03-12',1),(10,4,5,3,1,'2018-01-09',1),(11,4,5,3,1,'2018-02-23',1),(15,5,6,2,2,'2023-05-20',1),(16,3,3,1,2,'2024-05-20',1),(17,3,5,2,3,'2024-05-20',1),(19,4,7,2,1,'2024-05-20',1),(21,3,4,1,3,'2025-05-20',1),(22,6,5,4,3,'2025-05-20',1),(23,3,4,4,3,'2025-05-20',0),(24,5,2,1,1,'2020-11-20',1);
/*!40000 ALTER TABLE `buy` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-09  3:27:15
