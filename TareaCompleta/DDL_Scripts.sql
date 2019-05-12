EXEC usp_GetAll 'AERO%'
go

CREATE PROCEDURE usp_GetAll_Album
(
	@filterByName NVARCHAR(100)
)
AS
	BEGIN

		SELECT * FROM Album
		WHERE TITLE like @filterByName
	END
GO

CREATE PROCEDURE usp_GetAll_Genre
(
	@filterByName NVARCHAR(100)
)
AS
	BEGIN

		SELECT * FROM Genre
		WHERE NAME like @filterByName
	END
GO
--Create or Alter
alter PROCEDURE usp_InsertAlbum
(
@pTitle NVARCHAR(160),
@pArtistId INT
)
AS
BEGIN
	
	IF (NOT EXISTS(SELECT AlbumId FROM Album WHERE TITLE = @pTitle))
	BEGIN
		INSERT INTO Album(Title,ArtistId)
		VALUES (@pTitle,@pArtistId)
		SELECT SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SELECT 0
	END

END
GO

CREATE PROCEDURE usp_InsertGenre
@pName NVARCHAR(120)
AS
BEGIN
	
	IF (NOT EXISTS(SELECT GenreId FROM Genre WHERE NAME = @pName))
	BEGIN
		INSERT INTO Genre(NAME)
		VALUES (@pName)
		SELECT SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		SELECT 0
	END

END
GO


CREATE PROCEDURE usp_UpdateAlbum
@pName NVARCHAR(160),
@pId INT
AS
BEGIN
	
	If NOT EXISTS(SELECT AlbumId FROM Album WHERE TITLE = @pName)
	BEGIN
		UPDATE Album SET TiTLE = @pName
		WHERE AlbumId = @pId
	END

END
go

CREATE PROCEDURE usp_UpdateGenre
@pName NVARCHAR(120),
@pId INT
AS
BEGIN
	
	If NOT EXISTS(SELECT GenreId FROM Genre WHERE NAME = @pName)
	BEGIN
		UPDATE Genre SET NAME = @pName
		WHERE GenreId = @pId
	END

END
go

Create PROCEDURE usp_DeleteAlbum
@pId Int
AS
BEGIN
	DELETE FROM Album 
	WHERE AlbumId = @pId
END
GO	

Create PROCEDURE usp_DeleteGenre
@pId Int
AS
BEGIN
	DELETE FROM Genre 
	WHERE GenreId = @pId
END
GO	

SELECT * FROM Album ORDER BY AlbumId desc
SELECT * FROM Genre ORDER BY GenreId asc
SELECT * FROM Artist ORDER BY ArtistId desc