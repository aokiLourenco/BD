GO
CREATE PROCEDURE AddCharacter
    (
    @Attacks VARCHAR(512),
    @Attributes VARCHAR(512),
    @DESCRIPTION VARCHAR(1024),
    @Name VARCHAR(512),
    @Class VARCHAR(512),
    @Weakness VARCHAR(512),
    @LocationID INT,
    @LEVEL INT
)
AS

BEGIN
    DECLARE @CharacterID INT;
    DECLARE @error VARCHAR(512);
    SET @CharacterID = (SELECT MAX(CharacterID)
    FROM Characters) + 1;
    BEGIN TRY
        INSERT INTO Characters
        (CharacterID, Attacks, Attributes, DESCRIPTION, Name, Class, Weakness, LocationID, LEVEL)
    VALUES
        (@CharacterID, @Attacks, @Attributes, @DESCRIPTION, @Name, @Class, @Weakness, @LocationID, @LEVEL);
    END TRY
    BEGIN CATCH
        SELECT @error = ERROR_MESSAGE();
        SET @erro = "Error, could not add character to database. Value added incorrectly."
        RAISERROR(@error, 16, 1);
    END CATCH
END


GO
CREATE PROCEDURE EditCharacter
    (
    @CharacterID INT,
    @Attacks VARCHAR(512),
    @Attributes VARCHAR(512),
    @DESCRIPTION VARCHAR(1024),
    @Name VARCHAR(512),
    @Class VARCHAR(512),
    @Weakness VARCHAR(512),
    @LocationID INT,
    @LEVEL INT
)
AS

BEGIN
    DECLARE @verification INT;
    DECLARE @erro VARCHAR(100);

    SET @verification = (SELECT check_CharacterID(@ID_Character));

    IF (@verification = 0)
		BEGIN
        SET @erro = 'O ID do Character não existe, verifique o ID e tente novamente!';
        RAISERROR (@erro, 16, 1);
        END
	ELSE
		SET NOCOUNT ON;
        BEGIN
            BEGIN TRY
                BEGIN TRAN
                    UPDATE Characters 
                    SET
                        Attacks = @Attacks,
                        Attributes = @Attributes,
                        DESCRIPTION = @DESCRIPTION,
                        Name = @Name,
                        Class = @Class,
                        Weakness = @Weakness,
                        LocationID = @LocationID,
                        LEVEL = @LEVEL
                    WHERE
                        CharacterID = @ID_Character;
                COMMIT TRAN
            END TRY
			BEGIN CATCH
					Rollback TRAN
					SELECT @erro = ERROR_MESSAGE(); 
					SET @erro =  'Error, could not edit character in database. Value edited incorrectly.'
					RAISERROR (@erro, 16,1);
			END CATCH
    END
END


GO

CREATE PROCEDURE DeleteCharacter (@ID_Character INT)
AS
	BEGIN
		DECLARE @verification INT;
		DECLARE @erro VARCHAR(100);
    
		SET @verification = (SELECT dbo.checkID_Festival(@ID_Character));
    
		IF (@verification = 0)
		BEGIN
			SET @erro = 'CharacterID does not exist, please check the ID and try again!';
			RAISERROR (@erro, 16, 1);
		END
		ELSE
		BEGIN
			BEGIN TRY
				BEGIN TRAN
                    DELETE FROM Characters WHERE CharacterID = @ID_Character;
                    DELETE FROM IsAt WHERE CharacterID = @ID_Character;
                    DELETE FROM Enemies WHERE CharacterID = @ID_Character;
                    DELETE FROM Bosses WHERE CharacterID = @ID_Character;
        		COMMIT TRAN
			END TRY
			BEGIN CATCH
				ROLLBACK TRAN
				SELECT @erro = ERROR_MESSAGE();
				SET @erro = 'Error, could not delete character from database. Value deleted incorrectly.';
				RAISERROR (@erro, 16, 1);
			END CATCH
		END
	END
GO

CREATE PROCEDURE AddLocation
    (
    @Area VARCHAR(512),
    @DESCRIPTION VARCHAR(1024),
    @Name VARCHAR(512),
    @PointsOfInterest VARCHAR(1024)
)
AS

BEGIN
    DECLARE @LocationID INT;
    DECLARE @error VARCHAR(512);
    SET @LocationID = (SELECT MAX(LocationID)
    FROM Locations) + 1;
    BEGIN TRY
        INSERT INTO Locations
        (LocationID, Area, DESCRIPTION, Name, PointsOfInterest)
    VALUES
        (@LocationID, @Area, @DESCRIPTION, @Name, @PointsOfInterest);
    END TRY
    BEGIN CATCH
        SELECT @error = ERROR_MESSAGE();
        SET @erro = "Error, could not add location to database. Value added incorrectly."
        RAISERROR(@error, 16, 1);
    END CATCH
END

GO