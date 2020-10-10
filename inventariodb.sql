CREATE DATABASE inventariodb;
USE inventariodb;

CREATE TABLE TipoInventario(
	IdTipoInventario INT PRIMARY KEY IDENTITY(1,1),
	Descripcion VARCHAR(50) NOT NULL,
	CuentaContable VARCHAR(50) NOT NULL,
	Estado BIT DEFAULT(0) NOT NULL
);

CREATE TABLE Articulo (
	IdArticulo INT PRIMARY KEY IDENTITY(1,1),
	Descripcion VARCHAR(50) NOT NULL,
	Existencia INT NOT NULL,
	CostoUnitario DECIMAL(10,2) NOT NULL,
	Estado BIT DEFAULT(0) NOT NULL,
	IdTipoInventario INT,
	CONSTRAINT FK_Articulo_Tipoinventario
	FOREIGN KEY(IdTipoInventario) REFERENCES TipoInventario(IdTipoInventario)
);

CREATE TABLE Almacen (
	IdAlmacen INT PRIMARY KEY IDENTITY(1,1),
	Descripcion VARCHAR(50) NOT NULL,
	Estado BIT DEFAULT(0) NOT NULL
);

CREATE TABLE TipoTransaccion (
	IdTipoTransaccion INT PRIMARY KEY IDENTITY(1,1),
	Descripcion VARCHAR(50) NOT NULL,
	Estado BIT DEFAULT(0) NOT NULL
);

CREATE TABLE Transaccion (
	IdTransaccion INT PRIMARY KEY IDENTITY(1,1),
	TipoTransaccion VARCHAR(20) NOT NULL,
	Fecha DATE NOT NULL,
	Cantidad INT NOT NULL,
	IdArticulo INT,
	IdTipoTransaccion INT,
	CONSTRAINT FK_Transaccion_Articulo
	FOREIGN KEY(IdArticulo) REFERENCES Articulo(IdArticulo),
	CONSTRAINT FK_Transaccion_TipoTransaccion
	FOREIGN KEY(IdTipoTransaccion) REFERENCES TipoTransaccion(IdTipoTransaccion)
);

CREATE TABLE ExistenciaAlmacen (
	IdAlmacen INT,
	IdArticulo INT,
	Cantidad INT NOT NULL,
	CONSTRAINT FK_Existencia_Almacen
	FOREIGN KEY(IdAlmacen) REFERENCES Almacen(IdAlmacen),
	CONSTRAINT FK_Existencia_Articulo
	FOREIGN KEY(IdArticulo) REFERENCES Articulo(IdArticulo)
);