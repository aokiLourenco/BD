DROP VIEW IF EXISTS BossView_Table

GO

CREATE VIEW BossView_Table
AS
    SELECT
        Characters.CharacterID AS ID,
        Characters.Name,
        Bosses.Cutscene,
        Characters.DESCRIPTION as Description,
        Characters.Class,
        Characters.Attacks,
        Characters.Attributes,
        Characters.Weakness,
        Characters.LEVEL as Level,
        Locations.Area,
        Locations.Name AS LocationName
    FROM Bosses
        JOIN Characters ON Bosses.CharacterID = Characters.CharacterID
        JOIN Locations ON Characters.LocationID = Locations.LocationID


GO


DROP VIEW IF EXISTS CharactersView_Table
GO

CREATE VIEW CharactersView_Table
AS
    SELECT
        Characters.CharacterID AS ID,
        Characters.Name,
        Characters.DESCRIPTION as Description,
        Characters.Class,
        Characters.Attacks,
        Characters.Attributes,
        Characters.Weakness,
        Characters.LEVEL as Level,
        Locations.Area,
        Locations.Name AS LocationName
    FROM Characters
        JOIN Locations ON Characters.LocationID = Locations.LocationID
GO


DROP VIEW IF EXISTS CraftingMaterials_Table

GO

CREATE VIEW CraftingMaterials_Table
AS
    SELECT
        CraftingMaterials.CraftingMaterialID as ID,
        Items.Name,
        CraftingMaterials.CraftingUse,
        CraftingMaterials.Source,
        CraftingMaterials.Quantity,
        CraftingMaterials.UsedItems as UsedID,
        Items.DESCRIPTION as Description
    FROM Items
        JOIN CraftingMaterials ON Items.ItemID = CraftingMaterials.UsedItems
GO

DROP VIEW IF EXISTS LocationView_Table

GO

CREATE VIEW LocationView_Table
AS
    SELECT
        Locations.LocationID AS ID,
        Locations.Area,
        Locations.Name,
        Locations.PointsOfInterest,
        Locations.DESCRIPTION as Description
    FROM Locations
GO

DROP VIEW IF EXISTS EnemyView_Table
GO

CREATE VIEW EnemyView_Table
AS
    SELECT
        Characters.CharacterID AS ID,
        Characters.Name,
        Characters.DESCRIPTION AS Description,
        Characters.Class,
        Characters.Attacks,
        Characters.Attributes,
        Characters.Weakness,
        Characters.LEVEL,
        Locations.Area,
        Locations.Name AS LocationName
    FROM Enemies
        JOIN Characters ON Enemies.CharacterID = Characters.CharacterID
        JOIN Locations ON Characters.LocationID = Locations.LocationID


GO

DROP VIEW IF EXISTS Items_Table

GO

CREATE VIEW Items_Table
AS
    SELECT
        Items.ItemID AS ID,
        Items.Name,
        Items.DESCRIPTION as Description,
        Items.UseRequisites,
        Characters.Name AS Owner,
        Dungeons.Name AS FoundIn,
        Dungeons.Area AS Area
    FROM Items
        JOIN Characters ON Items.Owner = Characters.CharacterID
        JOIN Dungeons ON Items.Award = Dungeons.DungeonID
GO

DROP VIEW IF EXISTS CraftsView_Table

GO

CREATE VIEW CraftsView_Table
AS
    SELECT
        Items.ItemID AS ID,
        CraftingMaterials.CraftingMaterialID AS CraftingMaterialID,
        Items.Name,
        UsedItems.Name AS UsedItem,
        CraftingMaterials.CraftingUse AS UsedIn,
        CraftingMaterials.quantity,
        CraftingMaterials.Source,
        Items.DESCRIPTION as Description
    FROM Crafts
        JOIN Items ON Crafts.ItemID = Items.ItemID
        JOIN CraftingMaterials ON Crafts.CraftingMaterialID = CraftingMaterials.CraftingMaterialID
        JOIN Items AS UsedItems ON CraftingMaterials.UsedItems = UsedItems.ItemID
        


GO

DROP VIEW IF EXISTS DungeonView_Table

GO

CREATE VIEW DungeonView_Table
AS
    SELECT
        Dungeons.DungeonID AS ID,
        Dungeons.Name,
        Dungeons.MainBoss,
        Dungeons.Area,
        Locations.Area AS LocationArea
    FROM Dungeons
        JOIN Locations ON Dungeons.LocationID = Locations.LocationID

GO

