CREATE TABLE [dbo].[tipo_vehiculo] (
    [id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [codigo]      NVARCHAR (25) NOT NULL UNIQUE,
    [descripcion] NVARCHAR (50) NOT NULL,
    [precio]      DECIMAL (18,2) NOT NULL
);
go

CREATE TABLE [dbo].vehiculo
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [matricula] NVARCHAR(15) NOT NULL UNIQUE, 
    [id_tipo_vehiculo] int NOT NULL, 
    CONSTRAINT [FK_vehiculo_tipo_vehiculo] FOREIGN KEY (id_tipo_vehiculo) REFERENCES tipo_vehiculo(id)
);
go

CREATE TABLE [dbo].estancia
(
    [id_vehiculo] INT NOT NULL, 
    [fecha_entrada] DATETIME NOT NULL, 
    [fecha_salida] DATETIME NULL,  
    CONSTRAINT [PK_estancia] PRIMARY KEY ([id_vehiculo], [fecha_entrada]),
    CONSTRAINT [FK_estancia_vehiculo] FOREIGN KEY (id_vehiculo) REFERENCES vehiculo(id)
);
go