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

CREATE PROCEDURE DeleteCharacter
    (@ID_Character INT)
AS
BEGIN
    DECLARE @verification INT;
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_CharacterID(@ID_Character));

    IF (@verification = 0)
		BEGIN
        SET @error = 'CharacterID does not exist, please check the ID and try again!';
        RAISERROR (@error, 16, 1);
    END
		ELSE
		BEGIN
        BEGIN TRY
				BEGIN TRAN
                    DELETE FROM Bosses WHERE CharacterID = @ID_Character;
                    DELETE FROM Enemies WHERE CharacterID = @ID_Character;
                    DELETE FROM IsAt WHERE CharacterID = @ID_Character;
                    DELETE FROM Characters WHERE CharacterID = @ID_Character;
        		COMMIT TRAN
			END TRY
			BEGIN CATCH
				ROLLBACK TRAN
				SELECT @error = ERROR_MESSAGE();
				--SET @error = 'Error, could not delete character from database. Value deleted incorrectly.';
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

CREATE PROCEDURE DeleteLocation
    (@ID_Location INT)
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
                    DELETE FROM IsAt WHERE LocationID = @ID_Location;
                    DELETE FROM Dungeons WHERE LocationID = @ID_Location;
                    DELETE FROM Characters WHERE LocationID = @ID_Location;
                    DELETE FROM Locations WHERE LocationID = @ID_Location;
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

CREATE PROCEDURE DeleteDungeon
    (@ID_Dungeon INT)
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

CREATE PROCEDURE DeleteItem
    (@ID_Item INT)
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

GO

DROP PROCEDURE AddBoss;
GO

CREATE PROCEDURE AddBoss
    (
    @CharacterID INT,
    @Cutscene VARCHAR(512)
)
AS
BEGIN
    DECLARE @error VARCHAR(512);
    BEGIN TRY
        INSERT INTO Bosses
        (CharacterID, Cutscene)
    VALUES
        (@CharacterID, @Cutscene);
    END TRY
    BEGIN CATCH
        SELECT @error = ERROR_MESSAGE();
        --SET @error = 'Error, could not add boss to database. Value added incorrectly.'
        RAISERROR(@error, 16, 1);
    END CATCH
END 

GO

DROP PROCEDURE EditBoss;

GO

CREATE PROCEDURE EditBoss
    (
    @ID_Boss INT,
    @Cutscene VARCHAR(512),
    @Name VARCHAR(512),
    @Attacks VARCHAR(512),
    @Attributes VARCHAR(512),
    @DESCRIPTION VARCHAR(512),
    @Class VARCHAR(512),
    @Weakness VARCHAR(512),
    @LEVEL INT

    )
AS
BEGIN
    DECLARE @verification INT;
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_CharacterID(@ID_Boss));

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

                    UPDATE Bosses 
                    SET
                        Cutscene = @Cutscene
                    WHERE
                        CharacterID = @ID_Boss;
                    UPDATE Characters
                    SET
                        Name = @Name,
                        Attacks = @Attacks,
                        Attributes = @Attributes,
                        DESCRIPTION = @DESCRIPTION,
                        Class = @Class,
                        Weakness = @Weakness,
                        LEVEL = @LEVEL
                    WHERE
                        CharacterID = @ID_Boss;
                
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                    Rollback TRAN
                    SELECT @error = ERROR_MESSAGE(); 
                    SET @error =  'Error, could not edit boss in database. Value edited incorrectly.'
                    RAISERROR (@error, 16,1);
            END CATCH
    END
END

GO

DROP PROCEDURE DeleteBoss;
GO

CREATE PROCEDURE DeleteBoss
    (@ID_Boss INT)
AS
BEGIN
    DECLARE @verification INT;
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_CharacterID(@ID_Boss));

    IF (@verification = 0)
        BEGIN
        SET @error = 'BossID does not exist, please check the ID and try again!';
        RAISERROR (@error, 16, 1);
    END
        ELSE
        BEGIN
        BEGIN TRY
                BEGIN TRAN
                    DELETE FROM Bosses WHERE CharacterID = @ID_Boss;
                    DELETE FROM Characters WHERE CharacterID = @ID_Boss;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                ROLLBACK TRAN
                SELECT @error = ERROR_MESSAGE();
                --.SET @error = 'Error, could not delete boss from database. Value deleted incorrectly.';
                RAISERROR (@error, 16, 1);
            END CATCH
    END
END

GO

DROP PROCEDURE AddCraftingMaterial;
GO

CREATE PROCEDURE AddCraftingMaterial(@Quantity INT, @Source VARCHAR(512), @CraftingUse VARCHAR(512), @UsedItems INT)
AS
BEGIN
    DECLARE @CraftingMaterialID INT;
    DECLARE @error VARCHAR(512);
    SET @CraftingMaterialID = (SELECT MAX(CraftingMaterialID)
    FROM CraftingMaterials) + 1;
    BEGIN TRY
        SET IDENTITY_INSERT CraftingMaterials ON;
        INSERT INTO CraftingMaterials
        (CraftingMaterialID, Quantity, Source, CraftingUse, UsedItems)
    VALUES
        (@CraftingMaterialID, @Quantity, @Source, @CraftingUse, @UsedItems);
    END TRY
    BEGIN CATCH
        SELECT @error = ERROR_MESSAGE();
        --SET @error = 'Error, could not add crafting material to database. Value added incorrectly.'
        RAISERROR(@error, 16, 1);
    END CATCH
END

GO

DROP PROCEDURE EditCraftingMaterial;

GO
CREATE PROCEDURE EditCraftingMaterial(@ID_CraftingMaterial INT, @Quantity INT, @Source VARCHAR(512), @CraftingUse VARCHAR(512), @UsedItems INT)

AS

BEGIN
    DECLARE @verification INT;
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_CraftingMaterialID(@ID_CraftingMaterial));

    IF (@verification = 0)
        BEGIN
        SET @error = 'CraftingMaterialID does not exist, please check the ID and try again';
        RAISERROR (@error, 16, 1);
    END
    ELSE
        SET NOCOUNT ON;
    BEGIN
        BEGIN TRY
                BEGIN TRAN

                    UPDATE CraftingMaterials 
                    SET
                        Quantity = @Quantity,
                        Source = @Source,
                        CraftingUse = @CraftingUse,
                        UsedItems = @UsedItems
                    WHERE
                        CraftingMaterialID = @ID_CraftingMaterial;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                    Rollback TRAN
                    SELECT @error = ERROR_MESSAGE(); 
                    SET @error =  'Error, could not edit crafting material in database. Value edited incorrectly.'
                    RAISERROR (@error, 16,1);
            END CATCH
    END
END

GO

DROP PROCEDURE DeleteCraftingMaterial;

GO

CREATE PROCEDURE DeleteCraftingMaterial(@ID_CraftingMaterial INT)

AS

BEGIN
    DECLARE @verification INT;
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_CraftingMaterialID(@ID_CraftingMaterial));

    IF (@verification = 0)
        BEGIN
        SET @error = 'CraftingMaterialID does not exist, please check the ID and try again!';
        RAISERROR (@error, 16, 1);
    END
        ELSE
        BEGIN
        BEGIN TRY
                BEGIN TRAN
                    DELETE FROM Crafts WHERE CraftingMaterialID = @ID_CraftingMaterial;
                    DELETE FROM CraftingMaterials WHERE CraftingMaterialID = @ID_CraftingMaterial;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                ROLLBACK TRAN
                SELECT @error = ERROR_MESSAGE();
                SET @error = 'Error, could not delete crafting material from database. Value deleted incorrectly.';
                RAISERROR (@error, 16, 1);
            END CATCH
    END
END

GO

DROP PROCEDURE AddCraft;

GO

CREATE PROCEDURE AddCraft(@ItemID INT, @CraftingMaterialID INT)
AS
BEGIN
    DECLARE @error VARCHAR(512);
    BEGIN TRY
        INSERT INTO Crafts
        (ItemID, CraftingMaterialID)
    VALUES
        (@ItemID, @CraftingMaterialID);
    END TRY
    BEGIN CATCH
        SELECT @error = ERROR_MESSAGE();
        --SET @error = 'Error, could not add craft to database. Value added incorrectly.'
        RAISERROR(@error, 16, 1);
    END CATCH
END

GO

DROP PROCEDURE EditCraft;

GO

CREATE PROCEDURE EditCraft(@ItemID INT, @CraftingMaterialID INT)

AS

BEGIN
    DECLARE @verification INT;
    DECLARE @verification2 INT;
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_ItemID(@ItemID));
    SET @verification2 = (SELECT dbo.check_CraftingMaterialID(@CraftingMaterialID));


    IF (@verification = 0 OR @verification2 = 0)
        BEGIN
        SET @error = 'Craft does not exist, please check the ID and try again';
        RAISERROR (@error, 16, 1);
    END
    ELSE
        SET NOCOUNT ON;
    BEGIN
        BEGIN TRY
                BEGIN TRAN

                    UPDATE Crafts 
                    SET
                        ItemID = @ItemID,
                        CraftingMaterialID = @CraftingMaterialID
                    WHERE
                        ItemID = @ItemID;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                    Rollback TRAN
                    SELECT @error = ERROR_MESSAGE(); 
                    SET @error =  'Error, could not edit craft in database. Value edited incorrectly.'
                    RAISERROR (@error, 16,1);
            END CATCH
    END
END

GO

DROP PROCEDURE DeleteCraft;

GO

CREATE PROCEDURE DeleteCraft(@ItemID INT, @CraftingMaterialID INT)

AS

BEGIN
    DECLARE @verification INT;
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_ItemID(@ItemID));

    IF (@verification = 0)
        BEGIN
        SET @error = 'Craft does not exist, please check the ID and try again!';
        RAISERROR (@error, 16, 1);
    END
        ELSE
        BEGIN
        BEGIN TRY
                BEGIN TRAN
                    DELETE FROM Crafts WHERE ItemID = @ItemID AND CraftingMaterialID = @CraftingMaterialID;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                ROLLBACK TRAN
                SELECT @error = ERROR_MESSAGE();
                SET @error = 'Error, could not delete craft from database. Value deleted incorrectly.';
                RAISERROR (@error, 16, 1);
            END CATCH
    END
END

GO

DROP PROCEDURE AddEnemy;

GO

CREATE PROCEDURE AddEnemy
    (
    @CharacterID INT
)
AS
BEGIN
    DECLARE @error VARCHAR(512);
    BEGIN TRY
        INSERT INTO Enemies
        (CharacterID)
    VALUES
        (@CharacterID);
    END TRY
    BEGIN CATCH
        SELECT @error = ERROR_MESSAGE();
        SET @error = 'Error, could not add enemy to database. Value added incorrectly.'
        RAISERROR(@error, 16, 1);
    END CATCH
END

GO

DROP PROCEDURE DeleteEnemy;

GO

CREATE PROCEDURE DeleteEnemy
    (@ID_Enemy INT)
AS
BEGIN
    DECLARE @verification INT;
    DECLARE @error VARCHAR(100);

    SET @verification = (SELECT dbo.check_CharacterID(@ID_Enemy));

    IF (@verification = 0)
        BEGIN
        SET @error = 'EnemyID does not exist, please check the ID and try again!';
        RAISERROR (@error, 16, 1);
    END
        ELSE
        BEGIN
        BEGIN TRY
                BEGIN TRAN
                    DELETE FROM Enemies WHERE CharacterID = @ID_Enemy;
                COMMIT TRAN
            END TRY
            BEGIN CATCH
                ROLLBACK TRAN
                SELECT @error = ERROR_MESSAGE();
                SET @error = 'Error, could not delete enemy from database. Value deleted incorrectly.';
                RAISERROR (@error, 16, 1);
            END CATCH
    END
END


