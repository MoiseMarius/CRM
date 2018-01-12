BEGIN TRANSACTION;

INSERT INTO [dbo].[Activitati]
VALUES (
	@PersonID
	,@NumeActivitate
	,@CategorieActivitate
	,@ScorActivitate
	);

COMMIT;
