-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: database_chess
-- ------------------------------------------------------
-- Server version	8.0.27

--
-- Create the database: database_chess
--

DROP DATABASE IF EXISTS database_chess;
CREATE DATABASE database_chess;

USE database_chess;



--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
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

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
INSERT INTO `persona` VALUES (20,'DuranteMazzi@rhyta.com','Durante','Mazzi','2c18810a571004ce7638e0111c005e404e37c5ec8db4532c564c820efdde52fd',0,'1958-09-12','0319 9106927',1),(21,'DinaPadovano@rhyta.com','Dina','Padovano','7f770e405803ff4ae74b9377ae9741a8ef20df0840738d7a7fbba79359024f2b',1,'2001-11-28','0391 9284804',1),(22,'GuerrinoToscano@jourrapide.com','Guerrino','Toscano','d5ace663088abec6f932022450566c789150b30b9012cd857b7c296d55114db1',0,'1979-11-17','0399 3115202',1),(23,'AlcideRossi@teleworm.uside','Alcide','Rossi','c5bd632fe1efd6ad586c8ac4966dd1e4adf9e840c1b9cd1dfe8ad307da028325',0,'1987-09-04','0353 1973192',1),(24,'RinaSiciliano@rhyta.com','Rina','Siciliano','fde51c3b897cb9d25719921fc444a88203dae8de6d6578590fceddc2cd800d96',1,'1949-10-29','0385 0481785',1),(25,'LinaGenovese@dayrep.com','Lina','Genovese','e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855',1,'1998-04-26','0363 5144619',0),(26,'AdalgisaCremonesi@rhyta.com','Adalgisa','Cremonesi','cc41bda95dae3ab58a1431c8aa6742e7907f809e3c1d4537c9237e4db2fd7d41',1,'1958-06-16','0326 2772121',0),(27,'EgidioNapolitano@teleworm.us','Egidio','Napolitano','115292add7e917f59ee97e5a3a94ae09ec0050dda615312024b7ccc38b210493',0,'1955-03-18','0347 8799982',0),(28,'SettimoLombardo@armyspy.com','Settimo','Lombardo','c09f6e438be5609fb9dbf0f293f66f4c55030950afd22ef446ea6069a69c2e24',0,'1942-01-25','0344 3142598',0),(29,'ValenteMilanesi@teleworm.us','Valente','Milanesi','b096ec27aeb5c3f2cccca4f7d4008a8020fe33bd544809945edbf5c904798658',0,'1990-06-29','0376 9987310',0),(30,'AgataMarcelo@rhyta.com','Agata','Marcelo','51cbf0c719af5aadcd77f4dbe254dd0130ed349b8cc7a6f5377a76e862274cdd',1,'1988-11-15','0325 4532967',0),(31,'OrazioLucciano@dayrep.com','Orazio','Lucciano','51cbf0c719af5aadcd77f4dbe254dd0130ed349b8cc7a6f5377a76e862274cdd',0,'1960-10-16','0346 0776743',2),(32,'LaraManna@rhyta.com','Lara','Manna','b1ee28d5320a3d74f26aa01fface4acf65ce9b5cd2ec4484d00231bdafc1f84f',1,'1975-02-05','0337 8526852',2),(33,'MassimilianoRomani@jourrapide.com','Massimiliano','Romani','659e51e778bce38249c7ef5e08404afa5a416e9a5b63b318f8a7728781c95d28',0,'1956-11-30','0344 4169804',2),(34,'PrudenzioPisano@dayrep.com','Prudenzio','Pisano','5ff8b18a4b2294b9114c519d3b28b8a5a336fce30a4e4048a1cd2b5b00b23cba',0,'1942-03-11','0329 0219697',2),(35,'GinaCosta@rhyta.com','Gina','Costa','2973883985fcbf6c0cd0927759e819bf770fc7b4c49c108b4e5797dc2fb6f1a1',1,'1982-06-14','0337 3554233',2);
UNLOCK TABLES;

--
-- Table structure for table `torneo`
--

DROP TABLE IF EXISTS `torneo`;
CREATE TABLE `torneo` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `QuotaIscrizione` int DEFAULT NULL,
  `Nome` varchar(40) NOT NULL,
  `RatingMinimo` int DEFAULT NULL,
  `RatingMassimo` int DEFAULT NULL,
  `MaxPartecipanti` int DEFAULT NULL,
  PRIMARY KEY (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


--
-- Dumping data for table `torneo`
--

LOCK TABLES `torneo` WRITE;
INSERT INTO `torneo` VALUES (6,8000,'torneo di Spagna',2000,3000,700),(7,1000,'torneo d\'italia',500,4000,500),(8,100000,'torneo di germania',200,3300,50);
UNLOCK TABLES;

--
-- Table structure for table `organizzatore`
--

DROP TABLE IF EXISTS `organizzatore`;

CREATE TABLE `organizzatore` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `CodicePersona` int NOT NULL,
  PRIMARY KEY (`Codice`),
  UNIQUE KEY `ID_ORGAN_PERSO_IND` (`CodicePersona`),
  CONSTRAINT `ID_ORGAN_PERSO_FK` FOREIGN KEY (`CodicePersona`) REFERENCES `persona` (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `organizzatore`
--

LOCK TABLES `organizzatore` WRITE;
INSERT INTO `organizzatore` VALUES (6,20),(7,21),(8,22),(9,23),(10,24);
UNLOCK TABLES;

--
-- Table structure for table `mossa`
--


DROP TABLE IF EXISTS `luogo`;
CREATE TABLE `luogo` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(40) NOT NULL,
  PRIMARY KEY (`Codice`),
  UNIQUE KEY `ID_LUOGO_IND` (`Nome`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


--
-- Dumping data for table `luogo`
--

LOCK TABLES `luogo` WRITE;
INSERT INTO `luogo` VALUES (9,'Australia'),(8,'Cina'),(11,'Egitto'),(10,'Germania'),(7,'Giappone'),(5,'Inghilterra'),(3,'Italia'),(4,'Spagna'),(6,'Svezia');
UNLOCK TABLES;

--
-- Table structure for table `giocatore`
--

DROP TABLE IF EXISTS `giocatore`;
CREATE TABLE `giocatore` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `CodicePersona` int NOT NULL,
  `PartiteVinte` int NOT NULL,
  `Federazione` varchar(40) NOT NULL,
  `Rating` int DEFAULT NULL,
  PRIMARY KEY (`Codice`),
  KEY `ID_GIOCA_PERSO_FK` (`CodicePersona`),
  CONSTRAINT `ID_GIOCA_PERSO_FK` FOREIGN KEY (`CodicePersona`) REFERENCES `persona` (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `giocatore`
--

LOCK TABLES `giocatore` WRITE;
INSERT INTO `giocatore` VALUES (8,25,0,'Federazione scacchistica italiana',1000),(9,26,0,'russa',2500),(10,27,0,'macedone',1100),(11,28,0,'Francese',3200),(12,29,0,'Tedesca',500),(13,30,0,'Macedone',1600);
UNLOCK TABLES;

--
-- Table structure for table `allenatore`
--

DROP TABLE IF EXISTS `allenatore`;
CREATE TABLE `allenatore` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `Federazione` varchar(40) NOT NULL,
  `CodicePersona` int DEFAULT NULL,
  PRIMARY KEY (`Codice`),
  KEY `ID_ALLEN_PERSO_FK` (`CodicePersona`),
  CONSTRAINT `ID_ALLEN_PERSO_FK` FOREIGN KEY (`CodicePersona`) REFERENCES `persona` (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


--
-- Dumping data for table `allenatore`
--

LOCK TABLES `allenatore` WRITE;
INSERT INTO `allenatore` VALUES (6,'macedone',31),(7,'australiana',32),(8,'brasiliano',33),(9,'federazione italiana',34),(10,'federazione italiana',35);
UNLOCK TABLES;

--
-- Table structure for table `allenamento`
--

DROP TABLE IF EXISTS `allenamento`;
CREATE TABLE `allenamento` (
  `CodiceAllenatore` int DEFAULT NULL,
  `CodiceGiocatore` int DEFAULT NULL,
  `Codice` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`Codice`),
  KEY `REF_ALLEN_ALLEN_IND` (`CodiceGiocatore`),
  KEY `REF_ALLEN_ALLEN_FK` (`CodiceAllenatore`),
  CONSTRAINT `ID_ALLEN_GIOCA_FK` FOREIGN KEY (`CodiceGiocatore`) REFERENCES `giocatore` (`Codice`),
  CONSTRAINT `REF_ALLEN_ALLEN_FK` FOREIGN KEY (`CodiceAllenatore`) REFERENCES `allenatore` (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `allenamento`
--

LOCK TABLES `allenamento` WRITE;
INSERT INTO `allenamento` VALUES (6,13,3),(8,12,4),(10,13,5),(6,12,6),(7,13,7),(8,10,8),(9,9,9),(9,10,10),(7,12,11);
UNLOCK TABLES;

--
-- Table structure for table `iscritto`
--

DROP TABLE IF EXISTS `iscritto`;
CREATE TABLE `iscritto` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `CodiceGiocatore` int NOT NULL,
  `CodiceEdizione` int NOT NULL,
  `Data` date NOT NULL,
  PRIMARY KEY (`Codice`),
  CONSTRAINT `REF_ISCRI_GIOCA` FOREIGN KEY (`CodiceGiocatore`) REFERENCES `giocatore` (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `iscritto`
--

LOCK TABLES `iscritto` WRITE;
INSERT INTO `iscritto` VALUES (27,9,16,'2022-07-18'),(28,9,17,'2022-07-18'),(29,11,16,'2022-07-18'),(30,12,16,'2022-07-18'),(31,12,18,'2022-07-18'),(32,13,18,'2022-07-18');
UNLOCK TABLES;


--
-- Table structure for table `edizione`
--

DROP TABLE IF EXISTS `edizione`;
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


--
-- Dumping data for table `edizione`
--

LOCK TABLES `edizione` WRITE;

INSERT INTO `edizione` VALUES (15,25000,'edizione1 Spagna','2023-05-18','2022-07-18',1,2022,6,NULL,8,4),(16,10000,'edizione1 Italia','2023-02-18','2022-07-18',1,2022,7,30,8,3),(17,10500,'edizione2 Spagna','2022-01-28','2023-07-18',2,2022,6,28,10,4),(18,1000000,'edizione1 Germania','2025-07-01','2024-05-12',1,2024,8,31,7,10);
UNLOCK TABLES;

-- add foreign key, this operation could not be done before because of a circular dependency

LOCK TABLES `iscritto` WRITE;
ALTER TABLE `iscritto` ADD UNIQUE KEY `ID_ISCRITTO_IND` (`CodiceGiocatore`,`CodiceEdizione`),
  ADD KEY `REF_ISCRI_EDIZI_FK` (`CodiceEdizione`),
  ADD CONSTRAINT `REF_ISCRI_EDIZI_FK` FOREIGN KEY (`CodiceEdizione`) REFERENCES `edizione` (`Codice`) ON DELETE CASCADE;
  UNLOCK TABLES;
--
-- Table structure for table `partita`
--

DROP TABLE IF EXISTS `partita`;
CREATE TABLE `partita` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `CodiceIscritto1` int DEFAULT NULL,
  `CodiceIscritto2` int DEFAULT NULL,
  `CodiceVincente` int DEFAULT NULL,
  `CodiceEdizione` int DEFAULT NULL,
  `DataInizio` datetime DEFAULT NULL,
  `DataFine` datetime DEFAULT NULL,
  `MinutiPerGiocatore` int DEFAULT NULL,
  PRIMARY KEY (`Codice`),
  KEY `REF_PARTI_ISCRI1_FK` (`CodiceIscritto1`),
  KEY `REF_PARTI_ISCRI2_FK` (`CodiceIscritto2`),
  KEY `REF_PARTI_EDIZI` (`CodiceEdizione`),
  CONSTRAINT `REF_PARTI_EDIZI` FOREIGN KEY (`CodiceEdizione`) REFERENCES `edizione` (`Codice`) ON DELETE CASCADE,
  CONSTRAINT `REF_PARTI_ISCRI1_FK` FOREIGN KEY (`CodiceIscritto1`) REFERENCES `iscritto` (`Codice`) ON DELETE CASCADE ON UPDATE RESTRICT,
  CONSTRAINT `REF_PARTI_ISCRI2_FK` FOREIGN KEY (`CodiceIscritto2`) REFERENCES `iscritto` (`Codice`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


--
-- Dumping data for table `partita`
--

LOCK TABLES `partita` WRITE;
INSERT INTO `partita` VALUES (7,27,29,29,16,'2022-07-20 10:00:00','2022-07-20 10:10:00',5),(8,29,30,30,16,'2022-07-22 15:00:00','2022-07-22 15:15:00',20),(9,31,32,31,18,'2024-05-13 16:00:00','2024-05-13 17:00:00',120);
UNLOCK TABLES;

--
-- Table structure for table `commento`
--

DROP TABLE IF EXISTS `commento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `commento` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `IsVisibile` int NOT NULL,
  `Testo` varchar(50) NOT NULL,
  `CodicePersona` int NOT NULL,
  `CodicePartita` int NOT NULL,
  PRIMARY KEY (`Codice`),
  UNIQUE KEY `ID_COMMENTO_IND` (`Codice`),
  KEY `REF_COMME_PARTI_IND` (`CodicePersona`,`CodicePartita`),
  KEY `REF_COMME_PARTI_FK` (`CodicePartita`),
  CONSTRAINT `REF_COMME_PARTI_FK` FOREIGN KEY (`CodicePartita`) REFERENCES `partita` (`Codice`) ON DELETE CASCADE,
  CONSTRAINT `REF_COMME_PERSO_FK` FOREIGN KEY (`CodicePersona`) REFERENCES `persona` (`Codice`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `commento`
--

LOCK TABLES `commento` WRITE;
INSERT INTO `commento` VALUES (1,1,'testo1',25,7),(2,0,'testo2',27,8),(3,1,'testo3',27,9),(4,0,'testo4',29,8),(5,1,'testo5',29,7);
UNLOCK TABLES;

DROP TABLE IF EXISTS `mossa`;
CREATE TABLE `mossa` (
  `CodicePartita` int DEFAULT NULL,
  `PosPartenzaX` int NOT NULL,
  `PosPartenzaY` int NOT NULL,
  `PosArrivoX` int NOT NULL,
  `PosArrivoY` int NOT NULL,
  `NumMossa` int DEFAULT NULL,
  `TipoMossa` varchar(45) DEFAULT NULL,
  `Pezzo` int NOT NULL,
  UNIQUE KEY `REF_MOSSA_VINC` (`CodicePartita`,`NumMossa`) /*!80000 INVISIBLE */,
  KEY `REF_MOSSA_PARTITA_FK` (`CodicePartita`),
  KEY `MOSSA_ID` (`CodicePartita`,`NumMossa`) /*!80000 INVISIBLE */,
  CONSTRAINT `REF_MOSSA_PARTI` FOREIGN KEY (`CodicePartita`) REFERENCES `partita` (`Codice`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `mossa`
--

LOCK TABLES `mossa` WRITE;
INSERT INTO `mossa` VALUES (7,2,2,2,3,1,'spostamento',1),(8,3,2,3,3,1,'spostamento',1);
UNLOCK TABLES;

--
-- Table structure for table `luogo`
--

--
-- Table structure for table `lezione`
--

DROP TABLE IF EXISTS `lezione`;
CREATE TABLE `lezione` (
  `CodiceAllenatore` int NOT NULL,
  `CodiceGiocatore` int NOT NULL,
  `Data` datetime NOT NULL,
  `Argomento` varchar(40) NOT NULL,
  `Giorno` date DEFAULT NULL,
  UNIQUE KEY `LEZIO_VINC` (`Giorno`,`CodiceGiocatore`,`CodiceAllenatore`),
  KEY `REF_LEZIO_GIOCA` (`CodiceGiocatore`),
  KEY `REF_LEZIO_ALLEN_FK_idx` (`CodiceAllenatore`),
  CONSTRAINT `REF_LEZIO_ALLEN_FK` FOREIGN KEY (`CodiceAllenatore`) REFERENCES `allenatore` (`Codice`),
  CONSTRAINT `REF_LEZIO_GIOCA` FOREIGN KEY (`CodiceGiocatore`) REFERENCES `giocatore` (`Codice`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `lezione`
--

LOCK TABLES `lezione` WRITE;
INSERT INTO `lezione` VALUES (6,8,'2021-06-08 15:00:00','apertura','2021-06-08'),(7,9,'2021-08-08 15:00:00','finali','2021-08-08'),(7,9,'2020-05-08 15:00:00','apertura','2020-05-08'),(8,11,'2020-06-09 16:00:00','finali','2020-06-09');
UNLOCK TABLES;