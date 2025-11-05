CREATE TABLE [dbo].[alumnos]
(
	[IdAlumno] INT NOT NULL PRIMARY KEY, 
    [codigo] NCHAR(10) NOT NULL, 
    [nombre] NCHAR(75) NOT NULL, 
    [direccion] NCHAR(100) NOT NULL, 
    [telefono] NCHAR(10) NULL
)
