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
-- Table structure for table `spectacles`
--

DROP TABLE IF EXISTS `spectacles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `spectacles` (
  `ID_s` tinyint(4) NOT NULL AUTO_INCREMENT,
  `Model_s` char(60) NOT NULL,
  `Proizv_s` char(60) NOT NULL,
  `Price_s` decimal(6,0) NOT NULL,
  `Kol_s` tinyint(4) NOT NULL,
  `Material_s` char(40) NOT NULL,
  `OsSmesh` tinyint(4) NOT NULL,
  `Categor_s` char(35) NOT NULL,
  `Diopt` char(4) NOT NULL,
  PRIMARY KEY (`ID_s`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spectacles`
--

LOCK TABLES `spectacles` WRITE;
/*!40000 ALTER TABLE `spectacles` DISABLE KEYS */;
INSERT INTO `spectacles` VALUES (2,'VY3101','PR',639,4,'Метал',90,'Антибликовые','-0.3'),(3,'LC14721','DFEN FF',7690,12,'Пластик',90,'Для чтения','0 ,'),(4,'TE-121','DimOP',4000,2,'Пластик',90,'Солнцезащитные 75%','0 ,'),(5,'PO-82','DimOP',500,0,'Метал',90,'Солнцезащитные 25%','0 ,'),(6,'RE-14','DimOP',800,0,'Метал',90,'Для чтения','0'),(7,'RT-138','DimOP',100,19,'Пластик',90,'Солнцезащитные 75%','0'),(8,'WE-123','DOptic',3670,0,'Метало-пластик',90,'Для чтения','+1,6'),(9,'QE-12','DimOP',249,0,'Метал',90,'Для постоянного ношения','+1.3'),(10,'XC-345','RayBan',789,1,'Метало-пластик',90,'Солнцезащитные 50%','0'),(11,'SE-198','RayBan',1200,2,'Пластик',90,'Солнцезащитные 25%','0 ,'),(12,'HN-54','RayBan',5000,4,'Метало-пластик',90,'Солнцезащитные 75%','0 ,'),(13,'PO-99','OP',250,2,'Пластик',90,'Для чтения','0');
/*!40000 ALTER TABLE `spectacles` ENABLE KEYS */;
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
