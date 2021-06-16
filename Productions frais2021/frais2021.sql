-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Mer 16 Juin 2021 à 23:38
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `frais2021`
--

-- --------------------------------------------------------

--
-- Structure de la table `adherents`
--

CREATE TABLE IF NOT EXISTS `adherents` (
  `id_adherent` int(11) NOT NULL AUTO_INCREMENT,
  `nom_adherent` varchar(50) CHARACTER SET latin1 NOT NULL,
  `prenom_adherent` varchar(50) CHARACTER SET latin1 NOT NULL,
  `dateNaissance_adherent` date NOT NULL,
  `adresse_adherent` varchar(100) CHARACTER SET latin1 NOT NULL,
  `cp_adherent` varchar(5) CHARACTER SET latin1 NOT NULL,
  `ville_adherent` varchar(60) CHARACTER SET latin1 NOT NULL,
  `tel_adherent` varchar(10) CHARACTER SET latin1 NOT NULL,
  `email_adherent` varchar(60) CHARACTER SET latin1 NOT NULL,
  `mdp_adherent` char(255) CHARACTER SET latin1 NOT NULL,
  `role_id` int(11) NOT NULL,
  PRIMARY KEY (`id_adherent`),
  KEY `Adherents_Roles_FK` (`role_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Contenu de la table `adherents`
--

INSERT INTO `adherents` (`id_adherent`, `nom_adherent`, `prenom_adherent`, `dateNaissance_adherent`, `adresse_adherent`, `cp_adherent`, `ville_adherent`, `tel_adherent`, `email_adherent`, `mdp_adherent`, `role_id`) VALUES
(1, 'Administrateur', '', '0000-00-00', '', '', '', '', 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 1);

-- --------------------------------------------------------

--
-- Structure de la table `adherer`
--

CREATE TABLE IF NOT EXISTS `adherer` (
  `id_adherent` int(11) NOT NULL,
  `idClub` int(11) NOT NULL,
  `Licence` varchar(30) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`id_adherent`,`idClub`),
  KEY `Adherer_Clubs0_FK` (`idClub`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `clubs`
--

CREATE TABLE IF NOT EXISTS `clubs` (
  `idClub` int(11) NOT NULL AUTO_INCREMENT,
  `nom_club` varchar(50) CHARACTER SET latin1 NOT NULL,
  `adresse_club` varchar(100) CHARACTER SET latin1 NOT NULL,
  `cp_club` varchar(5) CHARACTER SET latin1 NOT NULL,
  `ville_club` varchar(100) CHARACTER SET latin1 NOT NULL,
  `tel_club` varchar(10) CHARACTER SET latin1 NOT NULL,
  `email_club` varchar(60) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`idClub`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Contenu de la table `clubs`
--

INSERT INTO `clubs` (`idClub`, `nom_club`, `adresse_club`, `cp_club`, `ville_club`, `tel_club`, `email_club`) VALUES
(1, 'PRVB ', 'Place woking', '92350', 'Le plessis robinson', '0142356989', 'prvb@gmail'),
(2, 'TCPR', 'Parc des sports', '92350', 'Le plessis robinson', '0145897563', 'tcpr@gmail.com'),
(3, 'Boxe', '1 rue de la boxe ', '92350', 'Le plessis robinson', '0299756989', 'boxe@gmail.com'),
(4, 'Ping Pong', '1 rue du ping pong', '92350', 'Le plessis robinson', '0256878569', 'pingpong@gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table `faire_partie`
--

CREATE TABLE IF NOT EXISTS `faire_partie` (
  `idLigue` int(11) NOT NULL,
  `idClub` int(11) NOT NULL,
  PRIMARY KEY (`idLigue`,`idClub`),
  KEY `faire_partie_Clubs0_FK` (`idClub`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `frais`
--

CREATE TABLE IF NOT EXISTS `frais` (
  `id_frais` int(11) NOT NULL AUTO_INCREMENT,
  `motif_frais` varchar(100) CHARACTER SET latin1 NOT NULL,
  `id_adherent` int(11) NOT NULL,
  `idLigue` int(11) NOT NULL,
  PRIMARY KEY (`id_frais`),
  KEY `Frais_Adherents_FK` (`id_adherent`),
  KEY `Frais_Ligues0_FK` (`idLigue`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `ligues`
--

CREATE TABLE IF NOT EXISTS `ligues` (
  `idLigue` int(11) NOT NULL AUTO_INCREMENT,
  `nom_ligue` varchar(70) CHARACTER SET latin1 NOT NULL,
  `adresse_ligue` varchar(100) CHARACTER SET latin1 NOT NULL,
  `cp_ligue` varchar(5) CHARACTER SET latin1 NOT NULL,
  `ville_ligue` varchar(100) CHARACTER SET latin1 NOT NULL,
  `tel_ligue` varchar(10) CHARACTER SET latin1 NOT NULL,
  `email_ligue` varchar(60) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`idLigue`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `ligues`
--

INSERT INTO `ligues` (`idLigue`, `nom_ligue`, `adresse_ligue`, `cp_ligue`, `ville_ligue`, `tel_ligue`, `email_ligue`) VALUES
(2, 'FFT', '1 rue du tennis ', '75016', 'Paris', '0145789563', 'fft@gmail.com'),
(3, 'Boxe', '1 rue de la boxe', '75000', 'Paris', '0452315647', 'boxe@gmail.com');

-- --------------------------------------------------------

--
-- Structure de la table `motifs`
--

CREATE TABLE IF NOT EXISTS `motifs` (
  `idMotif` varchar(4) CHARACTER SET latin1 NOT NULL,
  `nomMotif` varchar(40) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`idMotif`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `motifs`
--

INSERT INTO `motifs` (`idMotif`, `nomMotif`) VALUES
('FRKM', 'Frais kilométriques'),
('PEAG', 'Frais de péage'),
('REPS', 'Repas');

-- --------------------------------------------------------

--
-- Structure de la table `roles`
--

CREATE TABLE IF NOT EXISTS `roles` (
  `role_id` int(11) NOT NULL AUTO_INCREMENT,
  `role_nom` varchar(30) CHARACTER SET latin1 NOT NULL,
  `role_role` varchar(30) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`role_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Contenu de la table `roles`
--

INSERT INTO `roles` (`role_id`, `role_nom`, `role_role`) VALUES
(1, 'Administrateur', 'ADM'),
(2, 'Membre', 'MEM'),
(3, 'Responsable', 'RES');

-- --------------------------------------------------------

--
-- Structure de la table `valide`
--

CREATE TABLE IF NOT EXISTS `valide` (
  `id_frais` int(11) NOT NULL,
  `idValideur` int(11) NOT NULL,
  `date_validation` date NOT NULL,
  PRIMARY KEY (`id_frais`,`idValideur`),
  KEY `valide_Valideur0_FK` (`idValideur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `valideur`
--

CREATE TABLE IF NOT EXISTS `valideur` (
  `idValideur` int(11) NOT NULL AUTO_INCREMENT,
  `nom_valideur` varchar(30) CHARACTER SET latin1 NOT NULL,
  `prenom_valideur` varchar(30) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`idValideur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `adherents`
--
ALTER TABLE `adherents`
  ADD CONSTRAINT `Adherents_Roles_FK` FOREIGN KEY (`role_id`) REFERENCES `roles` (`role_id`);

--
-- Contraintes pour la table `adherer`
--
ALTER TABLE `adherer`
  ADD CONSTRAINT `Adherer_Adherents_FK` FOREIGN KEY (`id_adherent`) REFERENCES `adherents` (`id_adherent`),
  ADD CONSTRAINT `Adherer_Clubs0_FK` FOREIGN KEY (`idClub`) REFERENCES `clubs` (`idClub`);

--
-- Contraintes pour la table `faire_partie`
--
ALTER TABLE `faire_partie`
  ADD CONSTRAINT `faire_partie_Clubs0_FK` FOREIGN KEY (`idClub`) REFERENCES `clubs` (`idClub`),
  ADD CONSTRAINT `faire_partie_Ligues_FK` FOREIGN KEY (`idLigue`) REFERENCES `ligues` (`idLigue`);

--
-- Contraintes pour la table `frais`
--
ALTER TABLE `frais`
  ADD CONSTRAINT `Frais_Adherents_FK` FOREIGN KEY (`id_adherent`) REFERENCES `adherents` (`id_adherent`),
  ADD CONSTRAINT `Frais_Ligues0_FK` FOREIGN KEY (`idLigue`) REFERENCES `ligues` (`idLigue`);

--
-- Contraintes pour la table `valide`
--
ALTER TABLE `valide`
  ADD CONSTRAINT `valide_Frais_FK` FOREIGN KEY (`id_frais`) REFERENCES `frais` (`id_frais`),
  ADD CONSTRAINT `valide_Valideur0_FK` FOREIGN KEY (`idValideur`) REFERENCES `valideur` (`idValideur`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
