CREATE TABLE [dbo].[usuario]
(
	[cod_usuario] INT NOT NULL PRIMARY KEY, 
    [nome_completo] NCHAR(100) NOT NULL, 
    [email] NCHAR(100) NOT NULL, 
    [senha] NCHAR(100) NOT NULL
)
