USE GestionPedidos;
GO

CREATE TABLE empresas (
	id INT IDENTITY(1,1) NOT NULL,
	nombre NVARCHAR(50) NOT NULL DEFAULT 'Nombre Empresa',
	PRIMARY KEY(id)
);

CREATE TABLE empleados (
	id INT IDENTITY(1,1) NOT NULL,
	nombre NVARCHAR(50) NOT NULL,
	apellido NVARCHAR(50) NOT NULL,
	empresaId INT NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (empresaId) REFERENCES empresas(id) ON DELETE CASCADE
);

CREATE TABLE cargos (
	id INT IDENTITY(1,1) NOT NULL,
	name NVARCHAR(50) NOT NULL DEFAULT 'CARGO',
	PRIMARY KEY (id)
);

CREATE TABLE rolesEmpleados (
	id INT IDENTITY(1,1) NOT NULL,
	empleadoId INT NOT NULL,
	cargoId INT NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (empleadoId) REFERENCES empleados(id) ON DELETE CASCADE,
	FOREIGN KEY (cargoId) REFERENCES cargos(id) ON DELETE CASCADE
);

truncate table empresas;