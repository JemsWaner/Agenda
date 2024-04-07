CREATE DATABASE AgendaDB;

USE AgendaDB;

CREATE TABLE Contactos (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    ID_contacto varchar(15),
    Nombre VARCHAR(255) NOT NULL,
    Telefono VARCHAR(20),
    Email VARCHAR(100)
);
INSERT INTO Contactos (ID_contacto,Nombre, Telefono, Email) VALUES
('234-0987553','Juan Perez', '123456789', 'juan@example.com'),
('398-44444','Maria Lopez', '987654321', 'maria@example.com'),
('377-4464321','Martinez Pozo', '809654321', 'Martinez@gmail.com');

select * from Contactos;
-- drop database AgendaDB;