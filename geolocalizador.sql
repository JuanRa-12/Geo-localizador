CREATE DATABASE geo;/*Creación de la BD para el geolocalizador*/
USE geo;/*Uso de la BD*/

/*Creacion de tablas para la BD*/

/*Tabla de tienda*/
CREATE TABLE tienda(
idtienda INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
nombre VARCHAR(50),
direccion VARCHAR(100));
/*Fin de la tabla de tienda*/

/*Tabla de refrigerador*/
CREATE TABLE refrigerador(
idrefri INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
nuserie INT,
caract VARCHAR(100),
GPS VARCHAR(50),
fkidtienda INT,
FOREIGN KEY(fkidtienda) REFERENCES tienda(idtienda));
/*Fin de la tabla de refrigerador*/

/*Tabla de GPS*/
CREATE TABLE gps(
idgps INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
latitud FLOAT,
longitud FLOAT,
fkidrefri INT,
FOREIGN KEY(fkidrefri) REFERENCES refrigerador(idrefri));
/*Fin de la tabla de GPS*/


/*Fin de creación de tablas*/

