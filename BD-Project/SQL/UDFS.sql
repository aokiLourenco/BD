CREATE FUNCTION check_CharacterID (@ID_Character INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter=COUNT(1) FROM Characters WHERE CharacterID=@ID_Character
		RETURN @counter
	END
GO

CREATE FUNCTION check_LocationID (@ID_Location INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter=COUNT(1) FROM Locations WHERE LocationID=@ID_Location
		RETURN @counter
	END
GO

CREATE FUNCTION check_DungeonID (@ID_Dungeon INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter=COUNT(1) FROM Dungeons WHERE DungeonID=@ID_Dungeon
		RETURN @counter
	END

GO

CREATE FUNCTION check_ItemID (@ID_Item INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter=COUNT(1) FROM Items WHERE ItemID=@ID_Item
		RETURN @counter
	END
GO

CREATE FUNCTION check_CraftingMaterialID (@ID_CraftingMaterial INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter=COUNT(1) FROM CraftingMaterials WHERE CraftingMaterialID=@ID_CraftingMaterial
		RETURN @counter
	END

GO

CREATE FUNCTION check_CraftID (@ID_Craft INT) RETURNS INT
AS
	BEGIN
		DECLARE @counter INT
		SELECT @counter=COUNT(1) FROM Crafts WHERE CraftID=@ID_Craft
		RETURN @counter
	END
