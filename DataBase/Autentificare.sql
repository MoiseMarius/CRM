CREATE PROCEDURE [dbo].[Autentificare] @numeUtilizator NVARCHAR(50) = 0
	,@parolaUtilizator NVARCHAR(50)
AS
RETURN

SELECT [PersonID]
FROM [dbo].[Login]
WHERE [username] = @numeUtilizator
	AND [password] = @parolaUtilizator
