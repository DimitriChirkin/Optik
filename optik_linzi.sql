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
-- Table structure for table `linzi`
--

DROP TABLE IF EXISTS `linzi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `linzi` (
  `ID_l` tinyint(4) NOT NULL AUTO_INCREMENT,
  `Model_l` char(60) NOT NULL,
  `Proizv_l` char(60) NOT NULL,
  `Price_l` decimal(6,0) NOT NULL,
  `Kol_l` tinyint(4) NOT NULL,
  `Material_l` char(40) NOT NULL,
  `OsSmesh` tinyint(4) NOT NULL,
  `Categor_l` char(35) NOT NULL,
  `Diopt` char(4) NOT NULL,
  PRIMARY KEY (`ID_l`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `linzi`
--

LOCK TABLES `linzi` WRITE;
/*!40000 ALTER TABLE `linzi` DISABLE KEYS */;
INSERT INTO `linzi` VALUES (1,'RT-122','PR',57,9,'Стекло',92,'Для чтения','+1.5'),(2,'WQ-34','DImOP',60,10,'Стекло-пластик',95,'Солнцезащитные 25%','0'),(3,'12-34','DimOP',1200,11,'Пластик',90,'Солнцезащитные 75%','0 ,'),(4,'TR-145','UFK',130,33,'Стекло-пластик',90,'Для компьютера','0'),(5,'QE-44','GRi',75,12,'Пластик',94,'Для чтения','-1.8'),(6,'RE-89','GH',78,11,'Стекло',91,'Фотохромные','0'),(7,'ЦЕ-12','Глаза Бога',100,1,'Стекло',90,'Антибликовые','+1.1'),(8,'UL-1488','TRREH',110,20,'Стекло',93,'Для постоянного ношения','+1.1'),(9,'PO-12','Oculus',100,24,'Стекло',90,'Для чтения','-1.5'),(10,'qweqw','qwe',1231,19,'Стекло-пластик',0,'Для компьютера, антибликовые',' 0,');
/*!40000 ALTER TABLE `linzi` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-01-09  3:27:17
