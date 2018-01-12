CREATE PROCEDURE [dbo].[Autentificare] @numeUtilizator NVARCHAR(50)
	,@parolaUtilizator NVARCHAR(50)
	,@IDUtilizator INT OUTPUT
AS
BEGIN
	SET @IDUtilizator = (
			SELECT [PersonID]
			FROM [dbo].[Login]
			WHERE [username] = @numeUtilizator
				AND [password] = @parolaUtilizator
			)

	RETURN @IDUtilizator
END
