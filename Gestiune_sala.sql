CREATE DATABASE  IF NOT EXISTS `gestiune_sala` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `gestiune_sala`;
-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: gestiune_sala
-- ------------------------------------------------------
-- Server version	8.0.17

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
-- Table structure for table `bonuri`
--

DROP TABLE IF EXISTS `bonuri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bonuri` (
  `Id_bon` int(11) NOT NULL AUTO_INCREMENT,
  `Cod` varchar(20) NOT NULL,
  `Data_bon` date NOT NULL,
  PRIMARY KEY (`Id_bon`),
  KEY `fk_servicii_bonuri_idx` (`Cod`),
  CONSTRAINT `fk_servicii_bonuri` FOREIGN KEY (`Cod`) REFERENCES `servicii` (`Cod`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bonuri`
--

LOCK TABLES `bonuri` WRITE;
/*!40000 ALTER TABLE `bonuri` DISABLE KEYS */;
INSERT INTO `bonuri` VALUES (1,'AB30D','2021-06-29'),(2,'AB30D','2021-06-06'),(3,'AB30D','2021-06-02'),(4,'PRBT','2021-05-14'),(5,'PRPC','2021-05-28'),(6,'PRPC','2021-06-24'),(7,'PRHW','2021-05-10'),(8,'AB90D','2021-04-09'),(9,'PRPC','2021-06-26'),(10,'AB30F','2021-07-07');
/*!40000 ALTER TABLE `bonuri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client_servicii`
--

DROP TABLE IF EXISTS `client_servicii`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client_servicii` (
  `Id_client` int(10) unsigned NOT NULL,
  `Cod` varchar(20) NOT NULL,
  KEY `client_servicii_ibfk_1` (`Id_client`),
  KEY `client_servicii_ibfk_2` (`Cod`),
  CONSTRAINT `client_servicii_ibfk_1` FOREIGN KEY (`Id_client`) REFERENCES `clienti` (`Id_client`),
  CONSTRAINT `client_servicii_ibfk_2` FOREIGN KEY (`Cod`) REFERENCES `servicii` (`Cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client_servicii`
--

LOCK TABLES `client_servicii` WRITE;
/*!40000 ALTER TABLE `client_servicii` DISABLE KEYS */;
INSERT INTO `client_servicii` VALUES (2,'PRBT'),(6,'AB30D'),(3,'PRPC'),(5,'PRPC'),(4,'AB30D'),(1,'PRPC'),(8,'PRHW'),(3,'AB90D'),(3,'PRPC'),(9,'AB30F');
/*!40000 ALTER TABLE `client_servicii` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clienti`
--

DROP TABLE IF EXISTS `clienti`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clienti` (
  `Id_client` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nume` varchar(50) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `Telefon` varchar(20) NOT NULL,
  PRIMARY KEY (`Id_client`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clienti`
--

LOCK TABLES `clienti` WRITE;
/*!40000 ALTER TABLE `clienti` DISABLE KEYS */;
INSERT INTO `clienti` VALUES (1,'Popa Alin','popa_alin@gmail.com','0745852412'),(2,'Popescu Flavia','popescu_flavia@yahoo.com','0723564744'),(3,'Andreescu Victor','andreescu_victor@gmail.com','0788526123'),(4,'Picovici Andreea','picovici_adreea@gmail.com','0744532141'),(5,'Ionescu Mihaela','ionescu_mihaela@yahoo.com','0744536125'),(6,'Dinu Cornel','dinu_cornel@yahoo.com','0754673823'),(8,'Popa Ana','ana@yahoo.com','0789456123'),(9,'Popovici Marius','marius.popovici@yahoo.com','0745698412');
/*!40000 ALTER TABLE `clienti` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `data_expirare`
--

DROP TABLE IF EXISTS `data_expirare`;
/*!50001 DROP VIEW IF EXISTS `data_expirare`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `data_expirare` AS SELECT 
 1 AS `Nume`,
 1 AS `Cod`,
 1 AS `Nr.zile`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `data_expirare_azi`
--

DROP TABLE IF EXISTS `data_expirare_azi`;
/*!50001 DROP VIEW IF EXISTS `data_expirare_azi`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `data_expirare_azi` AS SELECT 
 1 AS `Nume`,
 1 AS `Cod`,
 1 AS `Nr.zile valabile`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `servicii`
--

DROP TABLE IF EXISTS `servicii`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `servicii` (
  `Cod` varchar(20) NOT NULL,
  `Denumire` varchar(200) NOT NULL,
  `Pret` int(10) NOT NULL,
  `Valabilitate` int(10) NOT NULL,
  `Descriere` varchar(200) NOT NULL,
  PRIMARY KEY (`Cod`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicii`
--

LOCK TABLES `servicii` WRITE;
/*!40000 ALTER TABLE `servicii` DISABLE KEYS */;
INSERT INTO `servicii` VALUES ('AB30D','Day 30',70,30,'Abonament 30 de zile'),('AB30F','Full 30',110,30,'Abonament 30 zile cu acces la saună și piscină'),('AB90D','Day 90',200,90,'Abonament 90 zile '),('AB90F','Full 90',300,90,'Abonament 90 zile cu acces la saună și piscină'),('ABDP','Day Pass',15,1,'Abonament valabil o zi '),('PRBT','Booty Perfection',300,56,''),('PRHW','Home Workout',350,63,''),('PRPC','Pro Challenge',400,84,''),('PRTT','Tone & Thighten',300,56,'');
/*!40000 ALTER TABLE `servicii` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utilizatori`
--

DROP TABLE IF EXISTS `utilizatori`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `utilizatori` (
  `Id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `NumePrenume` varchar(50) NOT NULL,
  `NumarTelefon` varchar(50) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `NumeUtilizator` varchar(50) NOT NULL,
  `Parola` varchar(50) NOT NULL,
  `Rol` varchar(50) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utilizatori`
--

LOCK TABLES `utilizatori` WRITE;
/*!40000 ALTER TABLE `utilizatori` DISABLE KEYS */;
INSERT INTO `utilizatori` VALUES (1,'Plotuna Maria Magdalena','0743608889','magdalena_plotuna@yahoo.com','Admin','050692','Admin'),(2,'Popa Andrei','0785412554','andrei_popa@yahoo.com','andrei123','050692','User'),(4,'Antal Valentin','0745963123','antal_valentin@yahoo.com','Vali123','050692','User');
/*!40000 ALTER TABLE `utilizatori` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `valoare_totala`
--

DROP TABLE IF EXISTS `valoare_totala`;
/*!50001 DROP VIEW IF EXISTS `valoare_totala`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `valoare_totala` AS SELECT 
 1 AS `nume`,
 1 AS `cod`,
 1 AS `Valoare Totala`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'gestiune_sala'
--

--
-- Dumping routines for database 'gestiune_sala'
--
/*!50003 DROP FUNCTION IF EXISTS `f_data_scadenta_bon` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `f_data_scadenta_bon`(id_b int,data_b date,c text,val int) RETURNS int(11)
    DETERMINISTIC
begin
select data_bon into @data_b
from bonuri
where Id_bon=id_b;
select Valabilitate into @val
from servicii
where servicii.Cod=c ;
set @data_val= date_add(@data_b,interval @val day);
set @data_scadenta_bon= datediff(@data_val,curdate());
return @data_scadenta_bon;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `rol_login` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `rol_login`(nume varchar(50),parola varchar(50))
BEGIN
select * from gestiune_sala.utilizatori where NumeUtilizator=nume and Parola=parola;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `data_expirare`
--

/*!50001 DROP VIEW IF EXISTS `data_expirare`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `data_expirare` AS select `clienti`.`Nume` AS `Nume`,`servicii`.`Cod` AS `Cod`,`f_data_scadenta_bon`(`bonuri`.`Id_bon`,`bonuri`.`Data_bon`,`servicii`.`Cod`,`servicii`.`Valabilitate`) AS `Nr.zile` from (((`bonuri` join `servicii` on((`bonuri`.`Cod` = `servicii`.`Cod`))) join `client_servicii` on((`servicii`.`Cod` = `client_servicii`.`Cod`))) join `clienti` on((`client_servicii`.`Id_client` = `clienti`.`Id_client`))) where ((`f_data_scadenta_bon`(`bonuri`.`Id_bon`,`bonuri`.`Data_bon`,`servicii`.`Cod`,`servicii`.`Valabilitate`) <= 7) and (`f_data_scadenta_bon`(`bonuri`.`Id_bon`,`bonuri`.`Data_bon`,`servicii`.`Cod`,`servicii`.`Valabilitate`) > 0)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `data_expirare_azi`
--

/*!50001 DROP VIEW IF EXISTS `data_expirare_azi`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `data_expirare_azi` AS select `clienti`.`Nume` AS `Nume`,`servicii`.`Cod` AS `Cod`,`f_data_scadenta_bon`(`bonuri`.`Id_bon`,`bonuri`.`Data_bon`,`servicii`.`Cod`,`servicii`.`Valabilitate`) AS `Nr.zile valabile` from (((`bonuri` join `servicii` on((`bonuri`.`Cod` = `servicii`.`Cod`))) join `client_servicii` on((`servicii`.`Cod` = `client_servicii`.`Cod`))) join `clienti` on((`client_servicii`.`Id_client` = `clienti`.`Id_client`))) where (`f_data_scadenta_bon`(`bonuri`.`Id_bon`,`bonuri`.`Data_bon`,`servicii`.`Cod`,`servicii`.`Valabilitate`) = 0) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `valoare_totala`
--

/*!50001 DROP VIEW IF EXISTS `valoare_totala`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `valoare_totala` AS select `clienti`.`Nume` AS `nume`,`servicii`.`Cod` AS `cod`,sum(`servicii`.`Pret`) AS `Valoare Totala` from (((`bonuri` join `servicii` on((`bonuri`.`Cod` = `servicii`.`Cod`))) join `client_servicii` on((`servicii`.`Cod` = `client_servicii`.`Cod`))) join `clienti` on((`client_servicii`.`Id_client` = `clienti`.`Id_client`))) group by `clienti`.`Id_client` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-07-14 13:03:29
