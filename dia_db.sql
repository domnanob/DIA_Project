-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Szerver verzió:               5.7.33 - MySQL Community Server (GPL)
-- Szerver OS:                   Win64
-- HeidiSQL Verzió:              11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Adatbázis struktúra mentése a dia_db.
CREATE DATABASE IF NOT EXISTS `dia_db` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `dia_db`;

-- Struktúra mentése tábla dia_db. answers
CREATE TABLE IF NOT EXISTS `answers` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TaskID` int(11) NOT NULL,
  `Answer` text NOT NULL,
  `Correct` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`) USING BTREE,
  KEY `FK_answers_tasks` (`TaskID`) USING BTREE,
  CONSTRAINT `FK_answers_tasks` FOREIGN KEY (`TaskID`) REFERENCES `tasks` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=57 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.answers: ~56 rows (hozzávetőleg)
/*!40000 ALTER TABLE `answers` DISABLE KEYS */;
INSERT INTO `answers` (`ID`, `TaskID`, `Answer`, `Correct`) VALUES
	(1, 1, '<dl>', 0),
	(2, 1, '<ol>', 1),
	(3, 1, '<list>', 0),
	(4, 1, '<ul> ', 1),
	(5, 2, '.picture{float:right}', 0),
	(6, 2, '#picture{text-align:right}', 0),
	(7, 2, '#picture{float:right}', 1),
	(8, 2, '.picture{text-align:right}', 0),
	(9, 3, 'A h2 címsort dőltre állítja', 1),
	(10, 3, 'A h2 címsort olaszra állítja', 0),
	(11, 3, 'Hibás utasítás', 0),
	(12, 3, 'A címsort h2-re állítja.', 0),
	(13, 4, 'body {text-family:Arial;}', 0),
	(14, 4, 'body {font-family:Arial;}', 1),
	(15, 4, 'text {font-family:Arial;}', 0),
	(16, 4, 'body {text-style:Arial;}', 0),
	(17, 5, 'for (i <= 5; i++)', 0),
	(18, 5, 'for (i = 0; i <= 5; i++)', 1),
	(19, 5, 'for (i = 0; i <= 5)', 0),
	(20, 5, 'for i = 1 to 5', 0),
	(21, 6, 'Mikrofon', 1),
	(22, 6, 'Hangkártya', 1),
	(23, 6, 'RAM', 0),
	(24, 6, 'CPU (Central Processing Unit)', 0),
	(25, 7, 'a monitor sok színt tud kezelni.', 0),
	(26, 7, 'a monitor képátlója 15”, vagy annál nagyobb.', 0),
	(27, 7, ' a monitor képfrissítése: 70 Hz, vagy több.', 0),
	(28, 7, 'a monitor képpontjainak száma nagy.', 1),
	(29, 8, 'BMP', 1),
	(30, 8, 'WMF', 0),
	(31, 8, 'CDR', 0),
	(32, 8, 'SWF', 0),
	(33, 9, '2 m', 0),
	(34, 9, '5 m', 0),
	(35, 9, '10 m', 0),
	(36, 9, '100 m ', 1),
	(37, 10, 'Írható-olvasható.', 1),
	(38, 10, 'Csak olvasható', 0),
	(39, 10, 'Soros elérésű.', 0),
	(40, 10, 'Olyan memória, amely kikapcsolás után is megőrzi tartalmát.', 0),
	(41, 11, '2,2 kHz', 0),
	(42, 11, '2,2 MHz', 0),
	(43, 11, '2,2 GHz', 1),
	(44, 11, '2,2 THz', 0),
	(45, 12, 'ütközés megelőzés', 0),
	(46, 12, 'ütközés elkerülés', 0),
	(47, 12, 'ütközés figyelés', 1),
	(48, 12, 'vivő érzékelés', 0),
	(49, 13, 'HTTP', 1),
	(50, 13, 'ICMP', 0),
	(51, 13, 'UDP', 0),
	(52, 13, 'FTP ', 1),
	(53, 14, 'DB6 helyett 0DB6-ot kell írni, így nem érvényes a cím.', 0),
	(54, 14, 'Két helyen van benne dupla kettőspont.', 1),
	(55, 14, 'Nem FE80-al kezdődik.', 0),
	(56, 14, 'Mindenhol dupla kettőspontnak kellene szerepelnie.', 0);
/*!40000 ALTER TABLE `answers` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. classes
CREATE TABLE IF NOT EXISTS `classes` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(5) NOT NULL DEFAULT '',
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.classes: ~9 rows (hozzávetőleg)
/*!40000 ALTER TABLE `classes` DISABLE KEYS */;
INSERT INTO `classes` (`ID`, `Name`) VALUES
	(1, '9/A'),
	(2, '9/B'),
	(3, '10/A'),
	(4, '10/B'),
	(5, '11/A'),
	(6, '11/B'),
	(7, '12/A'),
	(8, '12/B'),
	(9, '13/A');
/*!40000 ALTER TABLE `classes` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. positions
CREATE TABLE IF NOT EXISTS `positions` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TeacherID` varchar(15) NOT NULL DEFAULT '',
  `ClassID` int(11) NOT NULL,
  `SubjectID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_positions_teachers` (`TeacherID`),
  KEY `FK_positions_classes` (`ClassID`),
  KEY `FK_positions_subjects` (`SubjectID`),
  CONSTRAINT `FK_positions_classes` FOREIGN KEY (`ClassID`) REFERENCES `classes` (`ID`),
  CONSTRAINT `FK_positions_subjects` FOREIGN KEY (`SubjectID`) REFERENCES `subjects` (`ID`),
  CONSTRAINT `FK_positions_teachers` FOREIGN KEY (`TeacherID`) REFERENCES `teachers` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.positions: ~15 rows (hozzávetőleg)
/*!40000 ALTER TABLE `positions` DISABLE KEYS */;
INSERT INTO `positions` (`ID`, `TeacherID`, `ClassID`, `SubjectID`) VALUES
	(1, 'NagyE', 3, 4),
	(2, 'NagyE', 3, 1),
	(3, 'VargaG', 7, 5),
	(4, 'VargaG', 8, 5),
	(5, 'NagyE', 7, 1),
	(6, 'NagyE', 7, 4),
	(7, 'NagyE', 8, 1),
	(8, 'NagyE', 5, 1),
	(10, 'NagyE', 6, 4),
	(11, 'NagyE', 6, 1),
	(12, 'NagyE', 1, 1),
	(13, 'NagyE', 1, 4),
	(14, 'NagyE', 2, 4),
	(15, 'NagyE', 2, 1),
	(16, 'BalicsG', 9, 5);
/*!40000 ALTER TABLE `positions` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. purchases
CREATE TABLE IF NOT EXISTS `purchases` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UserID` varchar(15) NOT NULL,
  `JavL` int(11) NOT NULL DEFAULT '0',
  `HaziF` int(11) NOT NULL DEFAULT '0',
  `KesesI` int(11) NOT NULL DEFAULT '0',
  `Jeles` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  KEY `FK_purchases_users` (`UserID`),
  CONSTRAINT `FK_purchases_users` FOREIGN KEY (`UserID`) REFERENCES `users` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.purchases: ~14 rows (hozzávetőleg)
/*!40000 ALTER TABLE `purchases` DISABLE KEYS */;
INSERT INTO `purchases` (`ID`, `UserID`, `JavL`, `HaziF`, `KesesI`, `Jeles`) VALUES
	(4, 'domnanob', 1, 1, 0, 0),
	(5, 'bagom', 0, 0, 0, 0),
	(6, 'baloghm', 1, 0, 0, 0),
	(7, 'kocsism', 0, 1, 0, 0),
	(8, 'takacsb', 0, 0, 0, 0),
	(9, 'szakacsg', 0, 1, 1, 1),
	(12, 'czapkoa', 0, 0, 0, 0),
	(14, 'antald', 0, 0, 0, 0),
	(15, 'becst', 0, 0, 0, 0),
	(16, 'mudrab', 0, 1, 0, 0),
	(17, 'nemethd', 0, 0, 0, 0),
	(18, 'simonp', 0, 0, 0, 0),
	(19, 'nemethg', 0, 0, 0, 0),
	(20, 'giglerk', 0, 0, 0, 0);
/*!40000 ALTER TABLE `purchases` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. registrationtokens
CREATE TABLE IF NOT EXISTS `registrationtokens` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Token` text NOT NULL,
  `ClassID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__classes` (`ClassID`),
  CONSTRAINT `FK__classes` FOREIGN KEY (`ClassID`) REFERENCES `classes` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.registrationtokens: ~2 rows (hozzávetőleg)
/*!40000 ALTER TABLE `registrationtokens` DISABLE KEYS */;
INSERT INTO `registrationtokens` (`ID`, `Token`, `ClassID`) VALUES
	(4, '7S2-Q07', 7),
	(10, 'X1W-909', 9);
/*!40000 ALTER TABLE `registrationtokens` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. roles
CREATE TABLE IF NOT EXISTS `roles` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(15) NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.roles: ~2 rows (hozzávetőleg)
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` (`ID`, `Name`) VALUES
	(1, 'admin'),
	(3, 'diak');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. subjects
CREATE TABLE IF NOT EXISTS `subjects` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.subjects: ~6 rows (hozzávetőleg)
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
INSERT INTO `subjects` (`ID`, `Name`) VALUES
	(1, 'Magyar nyelv és irodalom'),
	(2, 'Angol nyelv'),
	(3, 'Matematika'),
	(4, 'Történelem'),
	(5, 'Programozás'),
	(6, 'Német nyelv');
/*!40000 ALTER TABLE `subjects` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. tasks
CREATE TABLE IF NOT EXISTS `tasks` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `TestID` int(11) NOT NULL,
  `Task` text NOT NULL,
  `Points` int(11) NOT NULL,
  `TypeID` int(11) NOT NULL,
  PRIMARY KEY (`ID`) USING BTREE,
  KEY `FK_tasks_tests` (`TestID`) USING BTREE,
  KEY `FK_tasks_tasktypes` (`TypeID`),
  CONSTRAINT `FK_tasks_tasktypes` FOREIGN KEY (`TypeID`) REFERENCES `tasktypes` (`ID`),
  CONSTRAINT `FK_tasks_tests` FOREIGN KEY (`TestID`) REFERENCES `tests` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.tasks: ~14 rows (hozzávetőleg)
/*!40000 ALTER TABLE `tasks` DISABLE KEYS */;
INSERT INTO `tasks` (`ID`, `TestID`, `Task`, `Points`, `TypeID`) VALUES
	(1, 1, 'Melyik HTML utasításokkal készíthetünk felsorolást?', 4, 1),
	(2, 1, 'Melyik CSS utasítás igazítja jobbra a picture azonosítójú képet?', 2, 1),
	(3, 1, 'Mit lát el a következő CSS utasítás: h2 {font-style:italic;}?', 2, 1),
	(4, 1, 'Melyik CSS utasítással állíthatjuk a teljes weboldal betűtípusát Arialra?', 2, 1),
	(5, 1, ' Hogyan épül fel a számlálós ciklus ciklusfeje JavaScriptben?', 4, 1),
	(6, 2, 'A felsorolt eszközök közül melyek perifériák?', 4, 1),
	(7, 2, 'A nagyfelbontású monitor azt jelenti, hogy… ', 4, 1),
	(8, 2, 'Melyik pixelgrafikus fájlformátum az alábbiak közül?', 4, 1),
	(9, 2, 'Mekkora a Class 1 Bluetooth maximális hatótávolsága?', 4, 1),
	(10, 2, 'Melyik állítás igaz a RAM-ra?', 4, 1),
	(11, 2, 'Melyik a processzor órajel lehetséges értéke napjainkban asztali számítógépek esetén?', 4, 1),
	(12, 3, 'Mit jelent a CSMA/CD csatorna hozzáférési mód esetén a CD kifejezés?', 4, 1),
	(13, 3, 'Melyek alkalmazási rétegbeli protokollok a felsoroltak közül?', 4, 1),
	(14, 3, 'Mi a hiba a következő IPv6-címmel: 2001:DB6:85a3::1319:8a2e::7348?', 4, 1);
/*!40000 ALTER TABLE `tasks` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. tasktypes
CREATE TABLE IF NOT EXISTS `tasktypes` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.tasktypes: ~3 rows (hozzávetőleg)
/*!40000 ALTER TABLE `tasktypes` DISABLE KEYS */;
INSERT INTO `tasktypes` (`ID`, `Name`) VALUES
	(1, 'Feleletválasztós'),
	(2, 'Saját válasz (Coming Soon)'),
	(3, 'Igaz/Hamis (Coming Soon)');
/*!40000 ALTER TABLE `tasktypes` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. teachers
CREATE TABLE IF NOT EXISTS `teachers` (
  `Username` varchar(15) NOT NULL,
  `Password` text NOT NULL,
  `Name` text NOT NULL,
  `Enable` int(1) DEFAULT '1',
  `Email` text NOT NULL,
  `LastLogon` datetime NOT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.teachers: ~3 rows (hozzávetőleg)
/*!40000 ALTER TABLE `teachers` DISABLE KEYS */;
INSERT INTO `teachers` (`Username`, `Password`, `Name`, `Enable`, `Email`, `LastLogon`) VALUES
	('BalicsG', '$MYHASH$V1$10000$CK2Z+iE03L/JUxtJrddhmL5O9h4IoJDocpWdlo3eWs8tvjvH', 'Balics Gábor', 1, 'balics.gabor@gmail.com', '2022-03-31 16:54:00'),
	('NagyE', '$MYHASH$V1$10000$ccjHvRfTNvc55dqbGGOqgLkEvl3Moa9daKfmBx9UujirHmm/', 'Nagy Erika', 1, 'nagy.erika@gmail.com', '2022-03-13 16:58:10'),
	('VargaG', '$MYHASH$V1$10000$8wcWq41P7Fy+9CuA/XGMMKxvRZXx6a9LCOOmCci3NnzQR3he', 'Varga Gábor', 1, 'oktatas@vargasol.hu', '2022-01-22 10:40:22');
/*!40000 ALTER TABLE `teachers` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. tests
CREATE TABLE IF NOT EXISTS `tests` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  `TeacherID` varchar(15) NOT NULL,
  `SubjectID` int(11) NOT NULL,
  `ClassID` int(11) NOT NULL,
  `MaxPoints` int(11) NOT NULL,
  `Locked` int(11) NOT NULL DEFAULT '0',
  `FinishDate` datetime NOT NULL,
  `StartDate` datetime NOT NULL,
  `InternetAllowed` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`) USING BTREE,
  KEY `FK_tests_subjects` (`SubjectID`),
  KEY `FK_tests_teachers` (`TeacherID`),
  KEY `FK_tests_classes` (`ClassID`),
  CONSTRAINT `FK_tests_classes` FOREIGN KEY (`ClassID`) REFERENCES `classes` (`ID`),
  CONSTRAINT `FK_tests_subjects` FOREIGN KEY (`SubjectID`) REFERENCES `subjects` (`ID`),
  CONSTRAINT `FK_tests_teachers` FOREIGN KEY (`TeacherID`) REFERENCES `teachers` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.tests: ~3 rows (hozzávetőleg)
/*!40000 ALTER TABLE `tests` DISABLE KEYS */;
INSERT INTO `tests` (`ID`, `Name`, `TeacherID`, `SubjectID`, `ClassID`, `MaxPoints`, `Locked`, `FinishDate`, `StartDate`, `InternetAllowed`) VALUES
	(1, 'Webes alapok dolgozat', 'BalicsG', 5, 9, 14, 0, '2022-03-14 11:41:49', '2022-03-12 11:26:16', 1),
	(2, 'Információtechnológiai alapok', 'BalicsG', 5, 9, 24, 0, '2022-04-01 16:55:16', '2022-03-12 11:26:16', 0),
	(3, 'Hálózatok dolgozat', 'BalicsG', 5, 9, 12, 0, '2022-04-01 16:59:28', '2022-03-12 11:26:16', 0);
/*!40000 ALTER TABLE `tests` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. useranswer
CREATE TABLE IF NOT EXISTS `useranswer` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UserTestID` int(11) NOT NULL,
  `AnswerID` int(11) NOT NULL,
  `TaskID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_useranswer_usertests` (`UserTestID`) USING BTREE,
  KEY `FK_useranswer_answers` (`AnswerID`),
  KEY `FK_useranswer_tasks` (`TaskID`),
  CONSTRAINT `FK_useranswer_answers` FOREIGN KEY (`AnswerID`) REFERENCES `answers` (`ID`),
  CONSTRAINT `FK_useranswer_tasks` FOREIGN KEY (`TaskID`) REFERENCES `tasks` (`ID`),
  CONSTRAINT `FK_useranswer_usertests` FOREIGN KEY (`UserTestID`) REFERENCES `usertests` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.useranswer: ~22 rows (hozzávetőleg)
/*!40000 ALTER TABLE `useranswer` DISABLE KEYS */;
INSERT INTO `useranswer` (`ID`, `UserTestID`, `AnswerID`, `TaskID`) VALUES
	(1, 4, 3, 1),
	(2, 4, 18, 5),
	(3, 4, 14, 4),
	(4, 4, 9, 3),
	(5, 4, 7, 2),
	(6, 2, 11, 3),
	(7, 2, 19, 5),
	(8, 2, 16, 4),
	(9, 2, 8, 2),
	(10, 2, 4, 1),
	(15, 1, 9, 3),
	(16, 1, 15, 4),
	(17, 1, 18, 5),
	(18, 1, 4, 1),
	(19, 1, 7, 2),
	(20, 8, 36, 9),
	(21, 8, 29, 8),
	(22, 8, 28, 7),
	(23, 8, 43, 11),
	(24, 8, 37, 10),
	(25, 8, 22, 6),
	(26, 8, 21, 6);
/*!40000 ALTER TABLE `useranswer` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. users
CREATE TABLE IF NOT EXISTS `users` (
  `Username` varchar(15) NOT NULL,
  `Password` text NOT NULL,
  `Name` text NOT NULL,
  `Enable` int(1) DEFAULT NULL,
  `LastLogon` datetime DEFAULT NULL,
  `Money` int(11) NOT NULL DEFAULT '0',
  `ClassID` int(11) DEFAULT NULL,
  `Email` text,
  `RoleID` int(11) NOT NULL DEFAULT '3',
  PRIMARY KEY (`Username`) USING BTREE,
  KEY `class` (`ClassID`) USING BTREE,
  KEY `FK_users_roles` (`RoleID`),
  CONSTRAINT `FK_users_roles` FOREIGN KEY (`RoleID`) REFERENCES `roles` (`ID`),
  CONSTRAINT `class` FOREIGN KEY (`ClassID`) REFERENCES `classes` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.users: ~15 rows (hozzávetőleg)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`Username`, `Password`, `Name`, `Enable`, `LastLogon`, `Money`, `ClassID`, `Email`, `RoleID`) VALUES
	('admin', '$MYHASH$V1$10000$6qMikG4CtM52xcCieEl8nDR+ZGkUUwhiNOPUDlQlbRLnLtQ4', 'Tulajdonos', 1, '2022-03-29 12:44:24', 0, NULL, 'admin@admin.net', 1),
	('antald', '$MYHASH$V1$10000$y+vTVPFCV1jbnQCUxQBFeguRSGvLlKnDs4LXGvP5q+i+PtP1', 'Antalovits Dóra', 1, '2022-02-28 22:01:43', 50, 5, 'antalovits.dori@gmail.com', 3),
	('bagom', '$MYHASH$V1$10000$7VOMnbbHchw0mKklloeHYNidcthIBkgfN8wyDBpBFK53KwQV', 'Bagó Márton', 1, '2022-01-22 17:41:01', 50, 1, 'bagomarton00@gmail.com', 3),
	('baloghm', '$MYHASH$V1$10000$8NN5CuHeK2T3lZVizv2g3PQk4z8wcp/HOeXcLisEhtaYChlB', 'Balogh Martin Gábor', 1, '2022-01-22 17:42:13', 50, 6, 'balogh.martin@gmail.com', 3),
	('becst', '$MYHASH$V1$10000$Sv8zbJe73MTlXvqoWYxKwUb5JE4GHhH0Ej0X6sOTtfYqInTo', 'Bécs Tamara', 1, '2022-02-28 22:03:33', 50, 5, 'becs.tamara@gmail.com', 3),
	('czapkoa', '$MYHASH$V1$10000$O9tOneqhb3xQLywUhTc8eUs5tpw27uqxxmSWXGjJky/yuldh', 'Czapkó Attila', 1, '2022-03-01 14:39:10', 50, 3, 'atiscapy@gmail.com', 3),
	('domnanob', '$MYHASH$V1$10000$eMI5l+ZE5CIEqhuAe15Y2LJkftHKvh+6fApZ+h+H3oaw8FCA', 'Domnánovich Bálint', 1, '2022-03-31 17:02:59', 40, 9, 'domnanob@gmail.com', 3),
	('giglerk', '$MYHASH$V1$10000$ZrqDi4M46O7/mRAtodG+tLp2XqYdmlw42Q+Q5XYlpP62vluS', 'Gigler Krisztián', 1, '2022-03-06 08:33:51', 50, 9, 'gigler.krisztian@gmail.com', 3),
	('kocsism', '$MYHASH$V1$10000$nrJh+9T/F13Ki0vxDUeRjHGhQ2QcHi89HsJaE250mIxxC6XT', 'Kocsis Mihály', 1, '2022-01-22 17:47:16', 50, 6, 'kocsis.mihaly@gmail.com', 3),
	('mudrab', '$MYHASH$V1$10000$Q0AS2L9X0EYj2/8Nh8gkAhDZ7INCNWJbl/5zzA0C1Afh4lep', 'Mudra Bence', 1, '2022-03-17 15:03:22', 52, 9, 'mudra.bence@gmail.com', 3),
	('nemethd', '$MYHASH$V1$10000$aYzyyaJsT8cmmJRSdsRtectUDYhEOFygtX3l0QsHl0V16Qx5', 'Németh Dávid', 1, '2022-03-17 14:59:25', 70, 9, 'nemeth.david@gmail.com', 3),
	('nemethg', '$MYHASH$V1$10000$OIaeY55oe0hdswXnh2zc4h+1C+pZ/AL1SIVhVlQgbSdRWCDJ', 'Németh Gergő', 1, '2022-03-06 08:32:54', 50, 4, 'nemeth.gergo@gmail.com', 3),
	('simonp', '$MYHASH$V1$10000$JrccJsl/wUnzXbHrGlSMW42PYQQc3lq1EZfnz9yTW9+ZxKUl', 'Simon Patrik', 1, '2022-03-13 11:41:13', 50, 8, 'simon.patrik@gmail.com', 3),
	('szakacsg', '$MYHASH$V1$10000$Q+HTF/qGC3Pjc7FF7Xx2ywluzIotP4gwYGMJPDVb5LP4BMU2', 'Szakács Gergő', 1, '2022-01-22 17:41:38', 50, 8, 'szagacs.gergo@gmail.com', 3),
	('takacsb', '$MYHASH$V1$10000$eMI5l+ZE5CIEqhuAe15Y2LJkftHKvh+6fApZ+h+H3oaw8FCA', 'Takács Bálint', 1, '2022-01-22 17:46:21', 50, 7, 'takacs.balint@gmail.com', 3);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

-- Struktúra mentése tábla dia_db. usertests
CREATE TABLE IF NOT EXISTS `usertests` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `UserID` varchar(15) NOT NULL,
  `TestID` int(11) NOT NULL,
  `Completed` int(11) NOT NULL DEFAULT '0',
  `Points` double NOT NULL DEFAULT '0',
  `CorrectState` int(11) NOT NULL DEFAULT '0',
  `FinishDate` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK__users` (`UserID`),
  KEY `FK__tests` (`TestID`),
  CONSTRAINT `FK__tests` FOREIGN KEY (`TestID`) REFERENCES `tests` (`ID`),
  CONSTRAINT `FK__users` FOREIGN KEY (`UserID`) REFERENCES `users` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- Tábla adatainak mentése dia_db.usertests: ~12 rows (hozzávetőleg)
/*!40000 ALTER TABLE `usertests` DISABLE KEYS */;
INSERT INTO `usertests` (`ID`, `UserID`, `TestID`, `Completed`, `Points`, `CorrectState`, `FinishDate`) VALUES
	(1, 'nemethd', 1, 1, 10, 1, '2022-03-17 14:58:44'),
	(2, 'mudrab', 1, 1, 2, 1, '2022-03-17 14:43:52'),
	(3, 'giglerk', 1, 0, 0, 0, NULL),
	(4, 'domnanob', 1, 1, 10, 1, '2022-03-12 11:56:48'),
	(5, 'nemethd', 2, 0, 0, 0, NULL),
	(6, 'mudrab', 2, 0, 0, 0, NULL),
	(7, 'giglerk', 2, 0, 0, 0, NULL),
	(8, 'domnanob', 2, 1, 0, 0, '2022-03-31 17:03:32'),
	(9, 'nemethd', 3, 0, 0, 0, NULL),
	(10, 'mudrab', 3, 0, 0, 0, NULL),
	(11, 'giglerk', 3, 0, 0, 0, NULL),
	(12, 'domnanob', 3, 0, 0, 0, NULL);
/*!40000 ALTER TABLE `usertests` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
