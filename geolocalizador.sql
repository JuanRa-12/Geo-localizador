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

/*Inicio de los procedures.*/

/*Procedure para insertar datos*/
DELIMITER //
CREATE PROCEDURE InsertarTienda(
    IN nombreTienda VARCHAR(50),
    IN direccionTienda VARCHAR(100)
)
BEGIN
    INSERT INTO tienda (nombre, direccion) VALUES (nombreTienda, direccionTienda);
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE InsertarRefrigerador(
    IN nuserie INT,
    IN caractRefrigerador VARCHAR(100),
    IN gpsRefrigerador VARCHAR(50),
    IN tiendaId INT
)
BEGIN
    INSERT INTO refrigerador (nuserie, caract, GPS, fkidtienda) VALUES (nuserie, caractRefrigerador, gpsRefrigerador, tiendaId);
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE InsertarGPS(
    IN latitud FLOAT,
    IN longitud FLOAT,
    IN refrigeradorId INT
)
BEGIN
    INSERT INTO gps (latitud, longitud, fkidrefri) VALUES (latitud, longitud, refrigeradorId);
END //
DELIMITER ;
/*Fin del procedure para insertar datos*/

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
/*Fin del procedure para actualizar datos*/

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

SELECT * FROM tienda;
INSERT INTO tienda(nombre,direccion) VALUES('Abarrotes Torres','Calle 5 de mayo');
CALL ConsultarTiendas();
USE geo;






/*Otras cosas*/
/*Procedure para mostrar Tienda*/
delimiter ;;
create procedure showTienda( in _nombre VARCHAR(60)) 

begin 

select * from tienda where nombre like _nombre order by nombre; 

END;; 
/*FIN del Procedure para mostrar Tienda*/

/*Mandar a llamar el Procedure para mostrar Tienda con una tienda con una b en su nombre sin importar donde este*/
CALL showTienda('%b%');