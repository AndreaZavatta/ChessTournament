-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: database_chess
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `persona` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `Email` varchar(45) DEFAULT NULL,
  `Nome` varchar(45) DEFAULT NULL,
  `Cognome` varchar(45) DEFAULT NULL,
  `Password` varchar(100) DEFAULT NULL,
  `Genere` tinyint DEFAULT NULL,
  `DataNascita` date DEFAULT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `Tipo` int NOT NULL,
  PRIMARY KEY (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (20,'DuranteMazzi@rhyta.com','Durante','Mazzi','2c18810a571004ce7638e0111c005e404e37c5ec8db4532c564c820efdde52fd',0,'1958-09-12','0319 9106927',1),(21,'DinaPadovano@rhyta.com','Dina','Padovano','7f770e405803ff4ae74b9377ae9741a8ef20df0840738d7a7fbba79359024f2b',1,'2001-11-28','0391 9284804',1),(22,'GuerrinoToscano@jourrapide.com','Guerrino','Toscano','d5ace663088abec6f932022450566c789150b30b9012cd857b7c296d55114db1',0,'1979-11-17','0399 3115202',1),(23,'AlcideRossi@teleworm.uside','Alcide','Rossi','c5bd632fe1efd6ad586c8ac4966dd1e4adf9e840c1b9cd1dfe8ad307da028325',0,'1987-09-04','0353 1973192',1),(24,'RinaSiciliano@rhyta.com','Rina','Siciliano','fde51c3b897cb9d25719921fc444a88203dae8de6d6578590fceddc2cd800d96',1,'1949-10-29','0385 0481785',1),(25,'LinaGenovese@dayrep.com','Lina','Genovese','e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855',1,'1998-04-26','0363 5144619',0),(26,'AdalgisaCremonesi@rhyta.com','Adalgisa','Cremonesi','cc41bda95dae3ab58a1431c8aa6742e7907f809e3c1d4537c9237e4db2fd7d41',1,'1958-06-16','0326 2772121',0),(27,'EgidioNapolitano@teleworm.us','Egidio','Napolitano','115292add7e917f59ee97e5a3a94ae09ec0050dda615312024b7ccc38b210493',0,'1955-03-18','0347 8799982',0),(28,'SettimoLombardo@armyspy.com','Settimo','Lombardo','c09f6e438be5609fb9dbf0f293f66f4c55030950afd22ef446ea6069a69c2e24',0,'1942-01-25','0344 3142598',0),(29,'ValenteMilanesi@teleworm.us','Valente','Milanesi','b096ec27aeb5c3f2cccca4f7d4008a8020fe33bd544809945edbf5c904798658',0,'1990-06-29','0376 9987310',0),(30,'AgataMarcelo@rhyta.com','Agata','Marcelo','51cbf0c719af5aadcd77f4dbe254dd0130ed349b8cc7a6f5377a76e862274cdd',1,'1988-11-15','0325 4532967',0),(31,'OrazioLucciano@dayrep.com','Orazio','Lucciano','51cbf0c719af5aadcd77f4dbe254dd0130ed349b8cc7a6f5377a76e862274cdd',0,'1960-10-16','0346 0776743',2),(32,'LaraManna@rhyta.com','Lara','Manna','b1ee28d5320a3d74f26aa01fface4acf65ce9b5cd2ec4484d00231bdafc1f84f',1,'1975-02-05','0337 8526852',2),(33,'MassimilianoRomani@jourrapide.com','Massimiliano','Romani','659e51e778bce38249c7ef5e08404afa5a416e9a5b63b318f8a7728781c95d28',0,'1956-11-30','0344 4169804',2),(34,'PrudenzioPisano@dayrep.com','Prudenzio','Pisano','5ff8b18a4b2294b9114c519d3b28b8a5a336fce30a4e4048a1cd2b5b00b23cba',0,'1942-03-11','0329 0219697',2),(35,'GinaCosta@rhyta.com','Gina','Costa','2973883985fcbf6c0cd0927759e819bf770fc7b4c49c108b4e5797dc2fb6f1a1',1,'1982-06-14','0337 3554233',2);
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-18  2:34:23
