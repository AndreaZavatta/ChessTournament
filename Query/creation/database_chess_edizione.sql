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
-- Table structure for table `edizione`
--

DROP TABLE IF EXISTS `edizione`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `edizione` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `PremioVincita` int DEFAULT NULL,
  `Descrizione` varchar(50) NOT NULL,
  `DataFine` date DEFAULT NULL,
  `DataInizio` date DEFAULT NULL,
  `NumEdizione` int DEFAULT NULL,
  `Anno` int NOT NULL,
  `CodiceTorneo` int NOT NULL,
  `CodiceVincitore` int DEFAULT NULL,
  `CodiceOrganizzatore` int DEFAULT NULL,
  `CodiceLuogo` int DEFAULT NULL,
  PRIMARY KEY (`Codice`),
  UNIQUE KEY `REF_EDIZI_VINC` (`NumEdizione`,`CodiceTorneo`),
  KEY `REF_EDIZI_LUOGO_FK` (`CodiceLuogo`),
  KEY `REF_EDIZI_TORNE` (`CodiceTorneo`),
  KEY `REF_EDIZI_ORGAN_FK` (`CodiceOrganizzatore`),
  KEY `REF_EDIZI_GIOCA_FK` (`CodiceVincitore`) /*!80000 INVISIBLE */,
  CONSTRAINT `REF_EDIZI_ISCRI_FK` FOREIGN KEY (`CodiceVincitore`) REFERENCES `iscritto` (`Codice`),
  CONSTRAINT `REF_EDIZI_LUOGO_FK` FOREIGN KEY (`CodiceLuogo`) REFERENCES `luogo` (`Codice`),
  CONSTRAINT `REF_EDIZI_ORGAN_FK` FOREIGN KEY (`CodiceOrganizzatore`) REFERENCES `organizzatore` (`Codice`),
  CONSTRAINT `REF_EDIZI_TORNE` FOREIGN KEY (`CodiceTorneo`) REFERENCES `torneo` (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `edizione`
--

LOCK TABLES `edizione` WRITE;
/*!40000 ALTER TABLE `edizione` DISABLE KEYS */;
INSERT INTO `edizione` VALUES (15,25000,'edizione1 Spagna','2023-05-18','2022-07-18',1,2022,6,NULL,8,4),(16,10000,'edizione1 Italia','2023-02-18','2022-07-18',1,2022,7,30,8,3),(17,10500,'edizione2 Spagna','2022-01-28','2023-07-18',2,2022,6,28,10,4),(18,1000000,'edizione1 Germania','2025-07-01','2024-05-12',1,2024,8,31,7,10);
/*!40000 ALTER TABLE `edizione` ENABLE KEYS */;
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
