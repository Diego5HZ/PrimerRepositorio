CREATE DATABASE DBProyecto
Go

USE DBProyecto
Go

CREATE TABLE dbo.Usuario
	(
	IdUsuario	INT IDENTITY PRIMARY KEY,
	Username	VARCHAR(50) not null,
	Nombre		VARCHAR(50) not null,
	Apellidos	VARCHAR(50) not null,
	Email		VARCHAR(100) not null,
	Contraseña	VARBINARY(50) not null,
	FK_TarjetaCredito	INT FOREIGN KEY REFERENCES dbo.TarjetaCredito(TarjetaCredito) not null
	) 
GO

CREATE TABLE dbo.Inventario
	(
	IdProducto	Int IDENTITY PRIMARY KEY,
	Nombre		VARCHAR(30) not null,
	Cantidad	INT,
	Precio		DECIMAL
	)
GO

CREATE TABLE dbo.Pedido
	(
	IdPedido		INT IDENTITY PRIMARY KEY,
	FK_Usuario		INT FOREIGN KEY REFERENCES dbo.Usuario(Usuario) not null,
	FK_Producto		INT FOREIGN KEY REFERENCES dbo.Inventario(Producto) not null,
	Cantidad		INT,
	PagoSubTotal	DECIMAL,
	FechaPedido		DATE
	)
GO

CREATE TABLE dbo.CarritoCompras
	(
	IdCarritoCompras	INT IDENTITY PRIMARY KEY,
	FK_Usuario			INT FOREIGN KEY REFERENCES dbo.Usuario(Usuario) not null,
	FK_Producto			INT FOREIGN KEY REFERENCES dbo.Inventario(Producto) not null,
	Cantidad			INT,
	PagoSubTotal		DECIMAL
	)
GO

CREATE TABLE dbo.TarjetaCredito
	(
	IdTarjetaCredito INT IDENTITY PRIMARY KEY,
	NumeroTarjeta		INT(16) not null,
	Nombres				VARCHAR(50) not null,
	Apellidos			VARCHAR(50) not null,
	FechaVencimiento	DATE not null,
	CodigoSeguridad		INT not null
	)
GO

DROP TABLE dbo.Usuario
DROP TABLE dbo.Inventario
DROP TABLE dbo.Pedido
DROP TABLE dbo.CarritoCompras


SELECT * FROM dbo.Usuario ORDER BY IdUsuario desc