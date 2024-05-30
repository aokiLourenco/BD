CREATE INDEX IX_Locations_Id ON Locations(LocationID, Name);
GO
CREATE INDEX IX_Dungeons_Id ON Dungeons(DungeonID, Name);
GO
CREATE INDEX IX_Characters_Id ON Characters(CharacterID, Name);
GO
CREATE INDEX IX_CraftingMaterials_Id ON CraftingMaterials(CraftingMaterialID, Name);