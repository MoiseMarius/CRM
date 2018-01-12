CREATE TABLE [dbo].[Activitati] (
	[ID] INT IDENTITY(1, 1) PRIMARY KEY
	,[PersonID] INT NOT NULL
	,FOREIGN KEY ([PersonID]) REFERENCES [Person]([ID])
	,NumeActivitate NVARCHAR(MAX) NULL
	,[CategorieActivitate] INT NOT NULL
	,FOREIGN KEY ([CategorieActivitate]) REFERENCES [TipuriDeActivitati]([ID])
	,[ScorActivitate] REAL NOT NULL
	)
