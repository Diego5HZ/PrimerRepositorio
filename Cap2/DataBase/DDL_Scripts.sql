EXEC usp_GetAll 'AERO%'
go

CREATE PROCEDURE usp_GetAll
(
	@filterByName NVARCHAR(100)
)
AS
	BEGIN

		SELECT * FROM Artist
		WHERE NAME like @filterByName
	END
GO

--Create or Alter
CREATE PROCEDURE usp_InsertArtist
@pName NVARCHAR(120)
AS
BEGIN
	
	IF (NOT EXISTS(SELECT ArtistId FROM Artist WHERE Name = @pName))
	BEGIN
		INSERT INTO Artist(Name)
		VALUES (@pName)
		SELECT SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SELECT 0
	END

END

GO


CREATE PROCEDURE usp_UpdateArtist
@pName NVARCHAR(120),
@pId INT
AS
BEGIN
	
	If NOT EXISTS(SELECT ArtistId FROM Artist WHERE Name = @pName)
	BEGIN
		UPDATE Artist SET Name = @pName
		WHERE ArtistId = @pId
	END

END
go

Create PROCEDURE usp_DeleteArtist
@pId Int
AS
BEGIN
	DELETE FROM Artist 
	WHERE ArtistId = @pId
END
GO	

SELECT * FROM Artist ORDER BY ArtistId desc