﻿CREATE TABLE [dbo].[Login] (
	[ID] INT IDENTITY(1, 1) PRIMARY KEY
	,[PersonID] INT NOT NULL UNIQUE
	,FOREIGN KEY ([PersonID]) REFERENCES [Person]([ID])
	,[username] NVARCHAR(50) NULL
	,[password] NVARCHAR(MAX) NULL
	)
