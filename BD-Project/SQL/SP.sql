DROP PROCEDURE AddCharacter;
DROP PROCEDURE EditCharacter;
DROP PROCEDURE DeleteCharacter;

-- Character Stored Procedures
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
        SET IDENTITY_INSERT Characters ON;
        INSERT INTO Characters
        (CharacterID, Attacks, Attributes, DESCRIPTION, Name, Class, Weakness, LocationID, LEVEL)
    VALUES
        (@CharacterID, @Attacks, @Attributes, @DESCRIPTION, @Name, @Class, @Weakness, @LocationID, @LEVEL);
    END TRY
    BEGIN CATCH
        SELECT @error = ERROR_MESSAGE();
        --SET @error = 'Error, could not add character to database. Value added incorrectly.'
        RAISERROR(@error, 16, 1);
    END CATCH
END

GO

CREATE PROCEDURE EditCharacter
    (
    @ID_Character INT,
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
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_CharacterID(@ID_Character));

    IF (@verification = 0)
		BEGIN
        SET @error = 'CharacterID does not exist, please check the ID and try again';
        RAISERROR (@error, 16, 1);
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
					SELECT @error = ERROR_MESSAGE(); 
					SET @error =  'Error, could not edit character in database. Value edited incorrectly.'
					RAISERROR (@error, 16,1);
			END CATCH
    END
END
GO

CREATE PROCEDURE DeleteCharacter (@ID_Character INT)
AS
	BEGIN
		DECLARE @verification INT;
		DECLARE @error VARCHAR(100);
    
		SET @verification = (SELECT dbo.checkID_Character(@ID_Character));
    
		IF (@verification = 0)
		BEGIN
			SET @error = 'CharacterID does not exist, please check the ID and try again!';
			RAISERROR (@error, 16, 1);
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
				SELECT @error = ERROR_MESSAGE();
				SET @error = 'Error, could not delete character from database. Value deleted incorrectly.';
				RAISERROR (@error, 16, 1);
			END CATCH
		END
	END
GO




