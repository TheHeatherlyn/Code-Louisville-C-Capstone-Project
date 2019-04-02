 CREATE TABLE [dbo].[Table]
(
    [Name] NVARCHAR(50) NOT NULL, 
    [Phone] NVARCHAR(50) NULL, 
    [Street] NVARCHAR(MAX) NULL, 
    [City] NVARCHAR(50) NULL, 
    [State] NVARCHAR(50) NULL, 
    [Zip] NVARCHAR(50) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Name])
)
