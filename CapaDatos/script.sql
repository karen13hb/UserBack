
CREATE DATABASE PruebaSD;


USE PruebaSD;


CREATE TABLE Usuario (
    usuID numeric(18,0) NOT NULL,
    nombre varchar(100) NULL,
    apellido varchar(100) NULL
);

INSERT INTO Usuario (usuID, nombre, apellido) VALUES 
(1, 'Juan', 'P�rez'),
(2, 'Mar�a', 'Gonz�lez'),
(3, 'Pedro', 'L�pez'),
(4, 'Ana', 'Mart�nez'),
(5, 'Luis', 'Rodr�guez');

select * from Usuario

