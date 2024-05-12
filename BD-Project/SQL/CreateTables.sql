-- Query to create the tables of the database
DROP TABLE IF EXISTS Magics
DROP TABLE IF EXISTS Talismans
DROP TABLE IF EXISTS Armours
DROP TABLE IF EXISTS Weapons
DROP TABLE IF EXISTS Crafts
DROP TABLE IF EXISTS CraftingMaterials
DROP TABLE IF EXISTS Items
DROP TABLE IF EXISTS Enemies
DROP TABLE IF EXISTS Bosses
DROP TABLE IF EXISTS IsAt
DROP TABLE IF EXISTS Characters
DROP TABLE IF EXISTS Dungeons
DROP TABLE IF EXISTS Locations
GO

CREATE TABLE Locations (
    LocationID INT NOT NULL IDENTITY PRIMARY KEY,
    Area VARCHAR(50) NOT NULL,
    DESCRIPTION VARCHAR(100) NOT NULL,
    Name VARCHAR(50) NOT NULL,
    PointsOfInterest VARCHAR(100) NOT NULL,
)
GO

CREATE TABLE Dungeons (  -- Needs Locations
    DungeonID INT NOT NULL IDENTITY PRIMARY KEY,
    LocationID INT NOT NULL FOREIGN KEY REFERENCES Locations(LocationID),
    Area VARCHAR(50) NOT NULL,
    Name VARCHAR(50) NOT NULL,
    MainBoss VARCHAR(50) NOT NULL,
)
GO

CREATE TABLE Characters (  -- Needs Locations
    CharacterID INT NOT NULL IDENTITY PRIMARY KEY,
    Attacks VARCHAR(50) NOT NULL,
    Attributes VARCHAR(50) NOT NULL,
    DESCRIPTION VARCHAR(100) NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Class VARCHAR(50) NOT NULL,
    Weakness VARCHAR(50) NOT NULL,
    LocationID INT NOT NULL FOREIGN KEY REFERENCES Locations(LocationID),
    LEVEL INT NOT NULL,
)
GO

CREATE TABLE IsAt (  -- Needs Locations and Characters
    CharacterID INT NOT NULL FOREIGN KEY REFERENCES Characters(CharacterID),
    LocationID INT NOT NULL FOREIGN KEY REFERENCES Locations(LocationID),
    PRIMARY KEY (CharacterID, LocationID),
)
GO

CREATE TABLE Bosses (   -- Needs Characters
    CharacterID INT NOT NULL FOREIGN KEY REFERENCES Characters(CharacterID),
    Cutscene VARCHAR(50) NOT NULL,
)
GO

CREATE TABLE Enemies (  -- Needs Characters
    CharacterID INT NOT NULL FOREIGN KEY REFERENCES Characters(CharacterID),
)
GO

CREATE TABLE Items (  -- Needs Dungeons
    ItemID INT NOT NULL IDENTITY PRIMARY KEY,
    DESCRIPTION VARCHAR(100) NOT NULL,
    UseRequisites INT,
    Name VARCHAR(50) NOT NULL,
    Owner INT NOT NULL FOREIGN KEY REFERENCES Characters(CharacterID),
    Award INT NOT NULL FOREIGN KEY REFERENCES Dungeons(DungeonID),
)
GO

CREATE TABLE CraftingMaterials (  -- Needs Locations and Items
    CraftingMaterialID INT NOT NULL IDENTITY PRIMARY KEY,
    Quantity INT NOT NULL,
    Source VARCHAR(50) NOT NULL,
    CraftingUse VARCHAR(50) NOT NULL,
    UsedItems INT NOT NULL FOREIGN KEY REFERENCES Items(ItemID),
)
GO

CREATE TABLE Crafts (  -- Needs Items and CraftingMaterials
    ItemID INT NOT NULL FOREIGN KEY REFERENCES Items(ItemID),
    CraftingMaterialID INT NOT NULL FOREIGN KEY REFERENCES CraftingMaterials(CraftingMaterialID),
    PRIMARY KEY (ItemID, CraftingMaterialID),
)
GO

CREATE TABLE Weapons (  -- Needs Items
    Name VARCHAR(50) NOT NULL PRIMARY KEY,
    ItemID INT NOT NULL FOREIGN KEY REFERENCES Items(ItemID),
    Range INT NOT NULL,
    Damage INT NOT NULL,
    Abilities VARCHAR(50) NOT NULL,
    ScallingAttributes VARCHAR(50) NOT NULL,
)
GO

CREATE TABLE Armours (  -- Needs Items
    Name VARCHAR(50) NOT NULL PRIMARY KEY,
    ItemID INT NOT NULL FOREIGN KEY REFERENCES Items(ItemID),
    Weight INT NOT NULL,
    MagicDefense INT NOT NULL,
    PhysicalDefense INT NOT NULL,
    ElementResistance VARCHAR(50) NOT NULL,
)
GO

CREATE TABLE Talismans (  -- Needs Items
    Name VARCHAR(50) NOT NULL PRIMARY KEY,
    ItemID INT NOT NULL FOREIGN KEY REFERENCES Items(ItemID),
    Effect VARCHAR(50) NOT NULL,
)
GO

CREATE TABLE Magics (  -- Needs Items
    Name VARCHAR(50) NOT NULL PRIMARY KEY,
    ItemID INT NOT NULL FOREIGN KEY REFERENCES Items(ItemID),
    Effect VARCHAR(50) NOT NULL,
    ManaCost INT NOT NULL,
    DamageType VARCHAR(50) NOT NULL,
)
GO
