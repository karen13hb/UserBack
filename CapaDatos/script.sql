
CREATE DATABASE PruebaSD;


USE PruebaSD;


CREATE TABLE Usuario (
    usuID numeric(18,0) NOT NULL,
    nombre varchar(100) NULL,
    apellido varchar(100) NULL
);

INSERT INTO Usuario (usuID, nombre, apellido) VALUES 
(1, 'Juan', 'Pérez'),
(2, 'María', 'González'),
(3, 'Pedro', 'López'),
(4, 'Ana', 'Martínez'),
(5, 'Luis', 'Rodríguez');

select * from Usuario

