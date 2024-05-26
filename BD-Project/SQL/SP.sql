CREATE PROCEDURE EldenVault.AddCharacter (
    @Attacks VARCHAR(512),
    @Attributes VARCHAR(512),
    @DESCRIPTION VARCHAR(1024),
    @Name VARCHAR(512),
    @Class VARCHAR(512),
    @Weakness VARCHAR(512),
    @LocationID INT,
    @LEVEL INT
)   AS

BEGIN 
    DECLARE @CharacterID INT;
    DECLARE @error VARCHAR(512);
    SET @CharacterID = (SELECT MAX(CharacterID) FROM Characters) + 1;
    BEGIN TRY
        INSERT INTO Characters (CharacterID, Attacks, Attributes, DESCRIPTION, Name, Class, Weakness, LocationID, LEVEL)
        VALUES (@CharacterID, @Attacks, @Attributes, @DESCRIPTION, @Name, @Class, @Weakness, @LocationID, @LEVEL);
    END TRY
    BEGIN CATCH
        SELECT @error = ERROR_MESSAGE();
        SET @erro = "Error, could not add character to database. Value added incorrectly."
        RAISERROR(@error, 16, 1);
    END CATCH
END