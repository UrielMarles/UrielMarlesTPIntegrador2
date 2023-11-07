DROP TABLE animatronicos
DROP TABLE fiestas

CREATE TABLE animatronicos (
id INT IDENTITY(1,1) PRIMARY KEY,
nombre VARCHAR(50) not null,
descripcion VARCHAR(200) not null,
activo BIT not null,
cantidadUsos int not null
)

CREATE TABLE fiestas(
id INT IDENTITY(1,1) PRIMARY KEY,
lugar VARCHAR(100) not null,
precio INT not null,
activo BIT not null,
nombreCliente VARCHAR(50) not null,
telefonoCliente VARCHAR(50) not null,
correoCliente VARCHAR(50) not null,
fecha DATE not null
)
CREATE TABLE valoresGenerales(
id INT IDENTITY(1,1) PRIMARY KEY,
cantidad INT not null,
nombre VARCHAR(50) UNIQUE not null
)
CREATE TABLE animatronicosFiesta(
fiestaId INT not null,
animatronicoId INT not null,
fechaFiesta DATE not null
FOREIGN KEY (fiestaId) REFERENCES fiestas(Id),
FOREIGN KEY (animatronicoId) REFERENCES animatronicos(Id)
)

DELETE FROM animatronicos;
DBCC CHECKIDENT('animatronicos', RESEED, 0);

DELETE FROM fiestas;
DBCC CHECKIDENT('fiestas', RESEED, 0);

INSERT INTO animatronicos (nombre,activo,cantidadUsos) VALUES ('freddy','1','23')
INSERT INTO animatronicos (nombre,activo,cantidadUsos) VALUES ('chica','1','13')
INSERT INTO animatronicos (nombre,activo,cantidadUsos) VALUES ('bonnie','1','14')
INSERT INTO fiestas (lugar,precio,activo,nombreCliente,telefonoCliente,correoCliente,fecha) VALUES ('','')
SELECT * FROM animatronicos
SELECT * FROM fiestas
SELECT * FROM valoresGenerales
SELECT * FROM animatronicosFiesta
