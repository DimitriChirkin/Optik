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
-- Table structure for table `opr`
--

DROP TABLE IF EXISTS `opr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `opr` (
  `ID_o` tinyint(4) NOT NULL AUTO_INCREMENT,
  `Model_o` char(60) NOT NULL,
  `Proizv_o` char(60) NOT NULL,
  `Price_o` decimal(6,0) NOT NULL,
  `Kol_o` tinyint(4) NOT NULL,
  `Material_o` char(40) NOT NULL,
  PRIMARY KEY (`ID_o`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `opr`
--

LOCK TABLES `opr` WRITE;
/*!40000 ALTER TABLE `opr` DISABLE KEYS */;
INSERT INTO `opr` VALUES (1,'TE-123','ANas',140,20,'Пластик'),(2,'КУ-123','Оправа Бога',234,0,'Золото'),(3,'UI-15','RayBan',56,8,'Пластик'),(4,'UA-15','UkrOP',78,4,'Метало-пластик'),(5,'Pr-325','HRTT',300,3,'Метал'),(6,'Бархат-1322','ДомМОД',600,4,'Дерево'),(7,'CI-88','RITM',250,6,'Пластик'),(8,'PL-103','Plug',180,18,'Пластик'),(9,'tu-12','DimOP',200,12,'Метал');
/*!40000 ALTER TABLE `opr` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-09  3:27:16
