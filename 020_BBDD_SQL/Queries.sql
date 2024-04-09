CREATE DATABASE GestionPedidos;
GO

USE GestionPedidos;
GO

CREATE TABLE articulos (
	id INT IDENTITY(1,1) NOT NULL,
	seccion nvarchar(50) NOT NULL,
	nombreArticulo nvarchar(50) NOT NULL DEFAULT 'Articulo',
	precio MONEY NOT NULL DEFAULT 0,
	paisOrigen nvarchar(50) NOT NULL DEFAULT 'Ecuador',
	fecha DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
	PRIMARY KEY (id)
);
--DROP TABLE articulos;

--INSERT INTO articulos (seccion) VALUES ('Deportes'), ('Ferretería'), ('Juguetería'), ('Cerámica'), ('Confección');
--SELECT * FROM articulos;

GO

CREATE TABLE clientes (
	id INT IDENTITY(1,1) NOT NULL,
	nombre nvarchar(50) NOT NULL,
	direccion nvarchar(50) NOT NULL,
	poblacion nvarchar(50) NOT NULL,
	telefono nvarchar(50) NOT NULL,
	PRIMARY KEY (id)
);

--DROP TABLE clientes;

--INSERT INTO clientes (nombre, direccion, poblacion, telefono) VALUES 
--('Beltran', 'Las fuentes 78', 'Madrid', '99887766'),  
--('La Morena', 'La Paloma 123', 'Oviedo', '99887765'),  
--('El Españolito', 'Motores 34', 'Barcelona', '99887764'),  
--('Exportasa', 'Vallecas 34', 'Madrid', '99887754'),  
--('Confecciones Amigas', 'Los Moros 23', 'Gijón', '99887734'),  
--('La Casa Del Juguete', 'América 45', 'Madrid', '99887724')
GO

CREATE TABLE pedidos (
	id INT IDENTITY(1,1) NOT NULL,
	cCliente INT NOT NULL,
	formaPago NVARCHAR(50) NOT NULL DEFAULT 'Efectivo',
	fechaPedido DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	PRIMARY KEY (id),
	FOREIGN KEY (cCliente) REFERENCES clientes(id)
);
--DROP TABLE pedidos;

INSERT INTO pedidos (cCliente, formaPago, fechaPedido) VALUES 
(5, 'Transferencia', '2024-02-06 12:30:00'),
(4, 'Transferencia', '2024-02-06 11:30:00')
--(2, 'Tarjeta', '2023-12-25 00:00:00'),
--(3, 'Aplazado', '2024-08-15 18:45:00'),
--(1, 'Efectivo', '2022-05-01 08:00:00')

GO

