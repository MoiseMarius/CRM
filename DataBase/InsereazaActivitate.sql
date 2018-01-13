CREATE PROCEDURE [dbo].[InsereazaActivitate] @PersonID INT
	,@NumeActivitate NVARCHAR(MAX)
	,@CategorieActivitate INT
	,@ScorActivitate REAL
AS
BEGIN TRANSACTION;

INSERT INTO [dbo].[Activitati]
VALUES (
	@PersonID
	,@NumeActivitate
	,@CategorieActivitate
	,@ScorActivitate
	);

COMMIT;

RETURN 0
