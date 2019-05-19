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
@pName NVARCHAR(160),
@pArtist NVARCHAR(120)
AS
BEGIN
	
	IF (NOT EXISTS(SELECT AlbumId FROM Album WHERE TITLE = @pName))
	BEGIN
		INSERT INTO Album(Title)
		VALUES (@pName)
		SELECT SCOPE_IDENTITY()
		INSERT INTO Artist(NAME)
		VALUES (@pArtist)
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
SELECT * FROM Genre ORDER BY GenreId desc
GO

----------------------------------------------------------------------------
CREATE PROCEDURE usp_GetTracks
(
@trackName NVARCHAR(200)
)
AS BEGIN
--Usar Ctrl+H para remplazar parametro y facilitar la ubicación!!!!!!!--
SELECT			B.TrackId, 
				B.Name AS TrackName,
				A.Title AS AlbumTitle, 
				D.Name AS MediaTypeName, 
				C.Name AS GenreName, 
				B.Composer, 
				B.Milliseconds, 
				B.Bytes,
				B.UnitPrice
FROM            dbo.Album AS A INNER JOIN
                dbo.Track AS B ON A.AlbumId = B.AlbumId INNER JOIN
		         dbo.Genre AS C ON B.GenreId = C.GenreId INNER JOIN
                 dbo.MediaType AS D ON B.MediaTypeId = D.MediaTypeId
WHERE B.Name LIKE @trackName
ORDER BY B.Name

END

GO

--Empieza en
EXEC usp_GetTracks 'A %'
GO
--Termina en
EXEC usp_GetTracks '%LTA'
GO
--Contiene la palabra o letra
EXEC usp_GetTracks '%PRETTY%'
GO

