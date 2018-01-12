CREATE TABLE [dbo].[Person] (
	[ID] INT IDENTITY(1, 1) PRIMARY KEY
	,[Titlu] NCHAR(10) NULL
	,[Nume] NCHAR(25) NULL
	,[Prenume] NCHAR(25) NULL
	,[DataNasterii] DATETIME NULL
	,[Ocupatie] NCHAR(25) NULL
	,[Sex] NCHAR(1) NULL
	)
