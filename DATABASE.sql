CREATE DATABASE bovinet;

USE bovinet;

CREATE TABLE Usuario (nombre_usuario VARCHAR(50), contraseña VARCHAR(50), tipo BOOLEAN, identificacion VARCHAR(15) NOT NULL, FOREIGN KEY (identificacion) REFERENCES Propietario(identificacion));

CREATE TABLE Propietario (identificacion VARCHAR(15) NOT NULL, nombre VARCHAR(50), correo VARCHAR(100), telefono VARCHAR(15), direccion VARCHAR(100), PRIMARY KEY (identificacion));

CREATE TABLE Animal (codigo VARCHAR(50) NOT NULL, raza VARCHAR(50), peso FLOAT, estado BOOLEAN, fecha_nacimiento DATE, tipo VARCHAR(50), produccion_promedio FLOAT, PRIMARY KEY (codigo), identificacion VARCHAR(15) NOT NULL, FOREIGN KEY (identificacion) REFERENCES Propietario(identificacion));

CREATE TABLE Produccion (fecha DATE, cantidad INT, costo_dia FLOAT, codigo VARCHAR(50) NOT NULL, FOREIGN KEY (codigo) REFERENCES Animal(codigo));

INSERT INTO Propietario VALUES ('1066285875', 'Mario Mendoza', 'mendoza@outlook.es', '3507083407', 'cl 11 # 21 - 04');

INSERT INTO Usuario VALUES ('ememendozar', 'mendoza', 1, '1066285875');

INSERT INTO Animal VALUES ('001', 'Raza', 235.2, 0, '2022-02-11', 'Propio', 0, '1066285875');