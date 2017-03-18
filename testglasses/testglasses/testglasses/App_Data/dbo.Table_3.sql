CREATE TABLE [dbo].[perfil]
(
	[cod_perfil] INT NOT NULL PRIMARY KEY, 
    [nome] NCHAR(50) NOT NULL, 
    [principal] BIT NOT NULL, 
    [cod_usuario] INT NOT NULL, 
    [foto] IMAGE NOT NULL
)
