CREATE DATABASE geo;/*Creación de la BD para el geolocalizador*/
USE geo;/*Uso de la BD*/


/*Creacion de tablas para la BD ------------------------------------------------------------------*/

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
fkidgps int,
fkidtienda INT,
FOREIGN KEY(fkidtienda) REFERENCES tienda(idtienda),
FOREIGN KEY(fkidgps) REFERENCES gps(idgps));
/*Fin de la tabla de refrigerador*/

/*Tabla de GPS*/
CREATE TABLE gps(
idgps INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
nombre VARCHAR(50),
latitud FLOAT,
longitud FLOAT);
SELECT * FROM gps
/*Fin de la tabla de GPS*/
/*Fin de creación de tablas------------------------------------------------------------------------*/


/*Inicio de los procedures.--------------------------------------------------------------------*/
/*+++++++++++++++++++++++++++ Procedures para insertar Datos*/
/*Procedure para insertar datos en tienda*/
DELIMITER //
drop PROCEDURE if EXISTS InsertarTienda;
CREATE PROCEDURE InsertarTienda(
    IN nombreTienda VARCHAR(50),
    IN direccionTienda VARCHAR(100)
)
BEGIN
    INSERT INTO tienda (nombre, direccion) VALUES (nombreTienda, direccionTienda);
END //
/*FIN de Procedure para insertar datos en tienda*/

/*Procedure para insertar datos en refrigerador*/
DELIMITER //
DROP PROCEDURE if EXISTS InsertarRefrigerador;
CREATE PROCEDURE InsertarRefrigerador(
    IN nuserie INT,
    IN caractRefrigerador VARCHAR(100),
    IN gpsRefrigerador INT,
    IN tiendaId INT
)
BEGIN
    INSERT INTO refrigerador (nuserie, caract, fkidgps, fkidtienda) VALUES (nuserie, caractRefrigerador, gpsRefrigerador, tiendaId);
END //
DELIMITER ;
/*FIN de Procedure para insertar datos en refrigerador*/

/*Procedure para insertar datos en GPS*/
DELIMITER //
DROP PROCEDURE IF EXISTS InsertarGPS;
CREATE PROCEDURE InsertarGPS(
    IN nombre VARCHAR(50),
     IN latitud FLOAT,
    IN longitud FLOAT
)
BEGIN
    INSERT INTO gps(nombre, latitud, longitud) VALUES(nombre, latitud, longitud);
END //
DELIMITER ;
/*FIN de Procedure para insertar datos en GPS*/
/*+++++++++++++++++++++++++++ FIN de Procedures para insertar Datos*/

/*+++++++++++++++++++++++++++ Procedures para consultar Datos*/
/*Incio del procedure para consultar datos*/
DELIMITER //
CREATE PROCEDURE ConsultarTiendas()
BEGIN
    SELECT * FROM tienda;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE ConsultarRefrigeradoresPorTienda(
    IN tiendaId INT
)
BEGIN
    SELECT * FROM refrigerador WHERE fkidtienda = tiendaId;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE ConsultarUbicacionGPS(
    IN refrigeradorId INT
)
BEGIN
    SELECT latitud, longitud FROM gps WHERE fkidrefri = refrigeradorId;
END //
DELIMITER ;
/*Fin del procedure para consultar datos*/

/*Procedure para mostrar Tienda*/
delimiter ;;
create procedure showTienda( in _nombre VARCHAR(60)) 

begin 

select * from tienda where nombre like _nombre order by idtienda; 

END;; 
/*FIN del Procedure para mostrar Tienda*/

/*Procedure para mostrar refrigerador*/
delimiter ;;
create procedure showRefrigerador( in _caract VARCHAR(100)) 

begin 

select * from refrigerador where caract like _caract ORDER by nuserie;

END;; 
/*FIN del Procedure para mostrar refrigerador*/
/*+++++++++++++++++++++++++++ FIN de Procedures para consultar Datos*/

/*+++++++++++++++++++++++++++ inicio de Procedures para actualizar Datos*/
/*Inicio del procedure para actualizar datos*/
DELIMITER //
CREATE PROCEDURE ActualizarDireccionTienda(
    IN tiendaId INT,
    IN nuevaDireccion VARCHAR(100)
)
BEGIN
    UPDATE tienda SET direccion = nuevaDireccion WHERE idtienda = tiendaId;
END //
DELIMITER ;
/*FIN del procedure para actualizar datos*/
/*+++++++++++++++++++++++++++ FIN de Procedures para actualizar Datos*/

/*+++++++++++++++++++++++++++ inicio de Procedures para Eliminar Datos*/
/*Inicio del procedure para elimirar refrigeradores*/
DELIMITER //
CREATE PROCEDURE EliminarRefrigerador(
    IN refrigeradorId INT
)
BEGIN
    DELETE FROM refrigerador WHERE idrefri = refrigeradorId;
END //
DELIMITER ;
/*Fin del procedure para eliminar refrigeradores*/
/*+++++++++++++++++++++++++++ FIN de Procedures para Eliminar Datos*/
/*FIN de los procedures.--------------------------------------------------------------------*/


/*Otras cosas--------------------------------------------------------------------------------*/

USE geo; /**/

/*mmmmmmmmmmmmmmmmmmmmmmmmmmmmm     Inicio de Tabla y procedures de tienda*/
SELECT * FROM tienda;

INSERT INTO tienda(nombre,direccion) VALUES('Abarrotes Torres','Calle 5 de mayo'); 
call InsertarTienda('Minisuper el Camaron','Avenida Guadalajara'); 
CALL ConsultarTiendas();
CALL showTienda('%');

/*mmmmmmmmmmmmmmmmmmmmmmmmmmmmm      FIN de Tabla y procedures de tienda*/

/*mmmmmmmmmmmmmmmmmmmmmmmmmmmmm     Inicio de Tabla y procedures de refrigerador*/
SELECT * FROM refrigerador;

INSERT INTO refrigerador VALUES (NULL,1073,'Refrigerador de doble puerta con cocacolas',1,1);
call InsertarRefrigerador(1345,'Refrigerador simple de jugos',1,1); 
CALL showRefrigerador('%');
/*mmmmmmmmmmmmmmmmmmmmmmmmmmmmm      FIN de Tabla y procedures de tienda*/

/*mmmmmmmmmmmmmmmmmmmmmmmmmmmmm     Inicio de Tabla y procedures de GPS*/
INSERT INTO gps VALUES (NULL, 'gps 2', -100000, 100000);
call InsertarGPS();
SELECT * FROM gps;
/*mmmmmmmmmmmmmmmmmmmmmmmmmmmmm     FIN de Tabla y procedures de GPS*/


