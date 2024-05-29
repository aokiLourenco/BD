DROP PROCEDURE AddCharacter;
DROP PROCEDURE EditCharacter;
DROP PROCEDURE DeleteCharacter;


GO
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


-- Locations


DROP PROCEDURE AddLocation;
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
        SET IDENTITY_INSERT Locations ON;
        INSERT INTO Locations
        (LocationID, Area, DESCRIPTION, Name, PointsOfInterest)
    VALUES
        (@LocationID, @Area, @DESCRIPTION, @Name, @PointsOfInterest);
    END TRY
    BEGIN CATCH
        SELECT @error = ERROR_MESSAGE();
        --SET @error = 'Error, could not add location to database. Value added incorrectly.'
        RAISERROR(@error, 16, 1);
    END CATCH
END

GO

DROP PROCEDURE EditLocation;
GO

CREATE PROCEDURE EditLocation
    (
    @ID_Location INT,
    @Area VARCHAR(512),
    @DESCRIPTION VARCHAR(1024),
    @Name VARCHAR(512),
    @PointsOfInterest VARCHAR(1024)
    )

AS

BEGIN
    DECLARE @verification INT;
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_LocationID(@ID_Location));

    IF (@verification = 0)
        BEGIN
        SET @error = 'LocationID does not exist, please check the ID and try again';
        RAISERROR (@error, 16, 1);
        END
    ELSE
        SET NOCOUNT ON;
        BEGIN
            BEGIN TRY
                BEGIN TRAN

                    UPDATE Locations 
                    SET
                        Area = @Area,
                        DESCRIPTION = @DESCRIPTION,
                        Name = @Name,
                        PointsOfInterest = @PointsOfInterest
                    WHERE
                        LocationID = @ID_Location;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                    Rollback TRAN
                    SELECT @error = ERROR_MESSAGE(); 
                    SET @error =  'Error, could not edit location in database. Value edited incorrectly.'
                    RAISERROR (@error, 16,1);
            END CATCH
    END
END

GO

DROP PROCEDURE DeleteLocation;
GO

CREATE PROCEDURE DeleteLocation (@ID_Location INT)
AS
    BEGIN
        DECLARE @verification INT;
        DECLARE @error VARCHAR(100);
    
        SET @verification = (SELECT dbo.check_LocationID(@ID_Location));
    
        IF (@verification = 0)
        BEGIN
            SET @error = 'LocationID does not exist, please check the ID and try again!';
            RAISERROR (@error, 16, 1);
        END
        ELSE
        BEGIN
            BEGIN TRY
                BEGIN TRAN
                    DELETE FROM Locations WHERE LocationID = @ID_Location;
                    DELETE FROM Characters WHERE LocationID = @ID_Location;
                    DELETE FROM Dungeons WHERE LocationID = @ID_Location;
                    DELETE FROM IsAt WHERE LocationID = @ID_Location;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                ROLLBACK TRAN
                SELECT @error = ERROR_MESSAGE();
                SET @error = 'Error, could not delete location from database. Value deleted incorrectly.';
                RAISERROR (@error, 16, 1);
            END CATCH
        END
    END
GO

--Dungeons

DROP PROCEDURE AddDungeon;
GO

CREATE PROCEDURE AddDungeon
    (
    @LocationID INT,
    @Area VARCHAR(512),
    @Name VARCHAR(512),
    @MainBoss VARCHAR(512)
    )
AS
BEGIN
    DECLARE @DungeonID INT;
    DECLARE @error VARCHAR(512);
    SET @DungeonID = (SELECT MAX(DungeonID)
    FROM Dungeons) + 1;
    BEGIN TRY
        SET IDENTITY_INSERT Dungeons ON;
        INSERT INTO Dungeons
        (DungeonID, LocationID, Area, Name, MainBoss)
    VALUES
        (@DungeonID, @LocationID, @Area, @Name, @MainBoss);
    END TRY
    BEGIN CATCH
        SELECT @error = ERROR_MESSAGE();
        --SET @error = 'Error, could not add dungeon to database. Value added incorrectly.'
        RAISERROR(@error, 16, 1);
    END CATCH
END

GO

DROP PROCEDURE EditDungeon;
GO

CREATE PROCEDURE EditDungeon
    (
    @ID_Dungeon INT,
    @LocationID INT,
    @Area VARCHAR(512),
    @Name VARCHAR(512),
    @MainBoss VARCHAR(512)
    )

AS

BEGIN
    DECLARE @verification INT;
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_DungeonID(@ID_Dungeon));

    IF (@verification = 0)
        BEGIN
        SET @error = 'DungeonID does not exist, please check the ID and try again';
        RAISERROR (@error, 16, 1);
        END
    ELSE
        SET NOCOUNT ON;
        BEGIN
            BEGIN TRY
                BEGIN TRAN

                    UPDATE Dungeons 
                    SET
                        LocationID = @LocationID,
                        Area = @Area,
                        Name = @Name,
                        MainBoss = @MainBoss
                    WHERE
                        DungeonID = @ID_Dungeon;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                    Rollback TRAN
                    SELECT @error = ERROR_MESSAGE(); 
                    SET @error =  'Error, could not edit dungeon in database. Value edited incorrectly.'
                    RAISERROR (@error, 16,1);
            END CATCH
    END
END

GO


DROP PROCEDURE DeleteDungeon;

GO

CREATE PROCEDURE DeleteDungeon (@ID_Dungeon INT)
AS
    BEGIN
        DECLARE @verification INT;
        DECLARE @error VARCHAR(100);
    
        SET @verification = (SELECT dbo.check_DungeonID(@ID_Dungeon));
    
        IF (@verification = 0)
        BEGIN
            SET @error = 'DungeonID does not exist, please check the ID and try again!';
            RAISERROR (@error, 16, 1);
        END
        ELSE
        BEGIN
            BEGIN TRY
                BEGIN TRAN
                    DELETE FROM Items WHERE Award = @ID_Dungeon;
                    DELETE FROM Dungeons WHERE DungeonID = @ID_Dungeon;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                ROLLBACK TRAN
                SELECT @error = ERROR_MESSAGE();
                SET @error = 'Error, could not delete dungeon from database. Value deleted incorrectly.';
                RAISERROR (@error, 16, 1);
            END CATCH
        END
    END


Go 

DROP PROCEDURE AddItem;
GO
CREATE PROCEDURE AddItem
    (
    @DESCRIPTION VARCHAR(1024),
    @UseRequisites VARCHAR(36),
    @Name VARCHAR(512),
    @Owner INT,
    @Award INT
    )
AS
BEGIN
    DECLARE @ItemID INT;
    DECLARE @error VARCHAR(512);
    SET @ItemID = (SELECT MAX(ItemID)
    FROM Items) + 1;
    BEGIN TRY
        SET IDENTITY_INSERT Items ON;
        INSERT INTO Items
        (ItemID, DESCRIPTION, UseRequisites, Name, Owner, Award)
    VALUES
        (@ItemID, @DESCRIPTION, @UseRequisites, @Name, @Owner, @Award);
    END TRY
    BEGIN CATCH
        SELECT @error = ERROR_MESSAGE();
        --SET @error = 'Error, could not add item to database. Value added incorrectly.'
        RAISERROR(@error, 16, 1);
    END CATCH
END

GO

DROP PROCEDURE EditItem;

GO

CREATE PROCEDURE EditItem
    (
    @ID_Item INT,
    @DESCRIPTION VARCHAR(1024),
    @UseRequisites VARCHAR(36),
    @Name VARCHAR(512),
    @Owner INT,
    @Award INT
    )
AS
BEGIN
    DECLARE @verification INT;
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_ItemID(@ID_Item));

    IF (@verification = 0)
        BEGIN
        SET @error = 'ItemID does not exist, please check the ID and try again';
        RAISERROR (@error, 16, 1);
        END
    ELSE
        SET NOCOUNT ON;
        BEGIN
            BEGIN TRY
                BEGIN TRAN

                    UPDATE Items 
                    SET
                        DESCRIPTION = @DESCRIPTION,
                        UseRequisites = @UseRequisites,
                        Name = @Name,
                        Owner = @Owner,
                        Award = @Award
                    WHERE
                        ItemID = @ID_Item;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                    Rollback TRAN
                    SELECT @error = ERROR_MESSAGE(); 
                    SET @error =  'Error, could not edit item in database. Value edited incorrectly.'
                    RAISERROR (@error, 16,1);
            END CATCH
    END
END
GO

DROP PROCEDURE DeleteItem;
GO

CREATE PROCEDURE DeleteItem (@ID_Item INT)
AS
    BEGIN
        DECLARE @verification INT;
        DECLARE @error VARCHAR(100);
    
        SET @verification = (SELECT dbo.check_ItemID(@ID_Item));
    
        IF (@verification = 0)
        BEGIN
            SET @error = 'ItemID does not exist, please check the ID and try again!';
            RAISERROR (@error, 16, 1);
        END
        ELSE
        BEGIN
            BEGIN TRY
                BEGIN TRAN
                    DELETE FROM Items WHERE ItemID = @ID_Item;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                ROLLBACK TRAN
                SELECT @error = ERROR_MESSAGE();
                SET @error = 'Error, could not delete item from database. Value deleted incorrectly.';
                RAISERROR (@error, 16, 1);
            END CATCH
        END
    END