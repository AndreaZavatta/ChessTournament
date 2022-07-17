DROP DATABASE IF EXISTS database_chess;
CREATE DATABASE database_chess;

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
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `allenatore`;
CREATE TABLE `allenatore` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `Federazione` varchar(40) NOT NULL,
  `CodicePersona` int DEFAULT NULL,
  PRIMARY KEY (`Codice`),
  KEY `ID_ALLEN_PERSO_FK` (`CodicePersona`),
  CONSTRAINT `ID_ALLEN_PERSO_FK` FOREIGN KEY (`CodicePersona`) REFERENCES `persona` (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `commento`;
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `iscritto`;
CREATE TABLE `iscritto` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `CodiceGiocatore` int NOT NULL,
  `CodiceEdizione` int NOT NULL,
  `Data` date NOT NULL,
  PRIMARY KEY (`Codice`),
  UNIQUE KEY `ID_ISCRITTO_IND` (`CodiceGiocatore`,`CodiceEdizione`),
  KEY `REF_ISCRI_EDIZI_FK` (`CodiceEdizione`),
  CONSTRAINT `REF_ISCRI_EDIZI_FK` FOREIGN KEY (`CodiceEdizione`) REFERENCES `edizione` (`Codice`) ON DELETE CASCADE,
  CONSTRAINT `REF_ISCRI_GIOCA` FOREIGN KEY (`CodiceGiocatore`) REFERENCES `giocatore` (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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

DROP TABLE IF EXISTS `luogo`;
CREATE TABLE `luogo` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `Nome` varchar(40) NOT NULL,
  PRIMARY KEY (`Codice`),
  UNIQUE KEY `ID_LUOGO_IND` (`Nome`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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

DROP TABLE IF EXISTS `organizzatore`;
CREATE TABLE `organizzatore` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `CodicePersona` int NOT NULL,
  PRIMARY KEY (`Codice`),
  UNIQUE KEY `ID_ORGAN_PERSO_IND` (`CodicePersona`),
  CONSTRAINT `ID_ORGAN_PERSO_FK` FOREIGN KEY (`CodicePersona`) REFERENCES `persona` (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

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
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `torneo`;
CREATE TABLE `torneo` (
  `Codice` int NOT NULL AUTO_INCREMENT,
  `QuotaIscrizione` int DEFAULT NULL,
  `Nome` varchar(40) NOT NULL,
  `RatingMinimo` int DEFAULT NULL,
  `RatingMassimo` int DEFAULT NULL,
  `MaxPartecipanti` int DEFAULT NULL,
  PRIMARY KEY (`Codice`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;