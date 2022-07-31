/*
	Usando los comandos vistos en clase seguir los siguientes pasos:

	1- Crear una base de datos con nombre "CursoNet".

	2- Dentro de la base generada crear una tabla llamada "Instructores" que contenga los campos:
		Id		=> Clave principal auto incremental
		Nombre
		Apellido

	3- Cargar en la tabla todos los instructores de este curso.

	4- Consultar la lista completa de instructores.

	Compartir todos los comandos utilizados.
*/

CREATE DATABASE CursoNet;

USE CursoNet;

CREATE TABLE Instructores(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL
);

INSERT INTO Instructores (Nombre, Apellido) VALUES('Eugenio','Serrano');
INSERT INTO Instructores (Nombre, Apellido) VALUES('Joaqu�n Eduardo','Mateos');
INSERT INTO Instructores (Nombre, Apellido) VALUES('Ruben','Benegas');
INSERT INTO Instructores (Nombre, Apellido) VALUES('Ezequiel','Etchecoin');
INSERT INTO Instructores (Nombre, Apellido) VALUES('Carlos','Cornejo');

SELECT * FROM Instructores;