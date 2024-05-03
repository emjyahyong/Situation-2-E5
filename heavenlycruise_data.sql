SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";
CREATE DATABASE heavenlycruise_data;

CREATE TABLE `categorie` (
  `code` int(11) NOT NULL AUTO_INCREMENT,
  `libelle` varchar(50) DEFAULT NULL,
  `exemple` varchar(50) DEFAULT NULL,
  `photo` varchar(50) DEFAULT NULL,
  `tarifJournalier` decimal(10,2) DEFAULT NULL,
  `estReserve` int(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`code`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

CREATE TABLE `client` (
  `id` smallint(6) NOT NULL AUTO_INCREMENT,
  `civilite` varchar(50) DEFAULT NULL,
  `nom` varchar(50) DEFAULT NULL,
  `prenom` varchar(50) DEFAULT NULL,
  `adrRue` varchar(50) DEFAULT NULL,
  `adrVille` varchar(50) DEFAULT NULL,
  `adrCp` varchar(50) DEFAULT NULL,
  `telephone` int(10) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

CREATE TABLE `reservation` (
  `numero` smallint(6) NOT NULL AUTO_INCREMENT,
  `idClient` smallint(6) NOT NULL,
  `codeCategorie` int(11) DEFAULT NULL,
  `dateDepart` date DEFAULT NULL,
  `dateRetour` date DEFAULT NULL,
  PRIMARY KEY (`numero`, `idClient`, `codeCategorie`),
  KEY `i_fk_reservation_client` (`idClient`),
  KEY `i_fk_reservation_categorie` (`codeCategorie`),
  CONSTRAINT `fk_reservation_client` FOREIGN KEY (`idClient`) REFERENCES `client` (`id`),
  CONSTRAINT `fk_reservation_categorie` FOREIGN KEY (`codeCategorie`) REFERENCES `categorie` (`code`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

CREATE TABLE `tourisme` (
  `code` int(11) NOT NULL,
  `climatisation` varchar(50) DEFAULT NULL,
  `nbPortes` smallint(1) DEFAULT NULL,
  `nbPassagersTransportables` smallint(1) DEFAULT NULL,
  `nbBagagesCoffre` smallint(2) DEFAULT NULL,
  PRIMARY KEY (`code`),
  CONSTRAINT `fk_tourisme_categorie` FOREIGN KEY (`code`) REFERENCES `categorie` (`code`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

CREATE TABLE `utilitaire` (
  `code` int(11) NOT NULL,
  `volume` decimal(10,2) DEFAULT NULL,
  `chargeUtile` decimal(10,2) DEFAULT NULL,
  `longueur` decimal(10,2) DEFAULT NULL,
  `largeur` decimal(10,2) DEFAULT NULL,
  `hauteur` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`code`),
  CONSTRAINT `fk_utilitaire_categorie` FOREIGN KEY (`code`) REFERENCES `categorie` (`code`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

COMMIT;