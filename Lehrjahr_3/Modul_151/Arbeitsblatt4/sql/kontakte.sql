
CREATE DATABASE IF NOT EXISTS `kontakte` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
USE `kontakte`;


CREATE TABLE IF NOT EXISTS `kontakte` (
  `kid` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `nachname` varchar(50) COLLATE utf8_german2_ci NOT NULL,
  `vorname` varchar(50) COLLATE utf8_german2_ci DEFAULT NULL,
  `strasse` varchar(100) COLLATE utf8_german2_ci DEFAULT NULL,
  `oid` int(11) DEFAULT NULL,
  `email` varchar(100) COLLATE utf8_german2_ci NOT NULL,
  `tel` varchar(20) COLLATE utf8_german2_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_german2_ci;


CREATE TABLE IF NOT EXISTS `orte` (
  `oid` int(11) NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `plz` int(11) NOT NULL,
  `ort` varchar(50) COLLATE utf8_german2_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_german2_ci;


INSERT INTO `orte` (`oid`, `plz`, `ort`) VALUES
(1, 3000, 'Bern'),
(2, 2500, 'Biel'),
(3, 3600, 'Thun'),
(4, 3400, 'Burgdorf');
