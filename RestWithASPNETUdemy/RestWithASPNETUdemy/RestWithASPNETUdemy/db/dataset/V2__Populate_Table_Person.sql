
LOCK TABLES `person` WRITE;
/*!40000 ALTER TABLE `person` DISABLE KEYS */;
INSERT INTO `person` VALUES (1,'Joao','Ryff','Canada','Male'),(2,'Jessica','Velasco','Brasil','Female'),(3,'Leonardo','da Vince','Italia','Male'),(4,'Mahatma','Gandhi','India','Male'),(5,'Luiz','Mariano','Brasil','Male');
/*!40000 ALTER TABLE `person` ENABLE KEYS */;
UNLOCK TABLES;