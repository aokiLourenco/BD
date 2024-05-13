--Query to populate the tables
INSERT INTO Locations (LocationID, Area, DESCRIPTION, Name, PointsOfInterest)
VALUES
(1, 
"Fragment West Limgrave", 
"Limgrave is a lush, expansive section of the Tenebrae Demesne. Golden trees and tall grass and bushes provide plenty of sustenance for the local wildlife, that features boars, sheep, goat and rodents in addition to flying creatures such as eagles and owls.", 
"LIMGRAVE", 
"CHURCH OF DRAGON COMMUNION"),
(2,
"Fragment Weeping Peninsula",
"The peninsula, to Limgrave's south, is named for its unceasing rainfall, redolent of lament.",
"WEEPING PENINSULA",
"CALLU BAPTISMAL CHURCH"),
(3,
"West Region of The Lands Between",
"With its shallow waters and vast wetlands, the region of Liurnia is beset with the gradual sinking of most of its landmass. With its forests perpetually blanketed in fog, eerie sounds of bells can be heard in the distance.",
"LIURNIA OF THE LAKES",
"BELLUM CHURCH"),
(4,
"South-East Region of The Lands Between",
"Caelid, known as the locale of the last battle between General Radahn and Malenia, Blade of Miquella, is a vast land consummately marred by scarlet rot.",
"CAELID",
"MINOR ERDTREE (CAELID)"),
(5,
"North-West Region of The Lands Between",
"NO-DATA",
"ALTUS PLATEAU",
"GOLDEN LINEAGE EVERGAOL")

--

INSERT INTO Dungeons (DungeonID, LocationID, Area, Name, MainBoss)
VALUES 
(1, 1, 'Limgrave', 'Castle of Storms', 'Lord of Lightning'),
(2, 1, 'Limgrave', 'Caelid Castle', 'Queen Marika'),
(3, 1, 'Limgrave', 'Gideons Rise', 'Gideon the Fallen Knight'),
(4, 1, 'Limgrave', 'Raya Lucaria Academy', 'Vice-Admiral Rennala'),
(5, 4, 'Caelid', 'Mountaintops of the Giants', 'The Elden Beast'),
(6, 4, 'Caelid', 'Roundtable Hold', 'Knight of the Roundtable'),
(7, 4, 'Caelid', 'Siofra Riverhead', 'Siofra the Water Wraith'),
(8, 4, 'Caelid', 'Caelid Bluffs', 'Lady of the Recluse'),
(9, 4, 'Caelid', 'Vargalt Castle', 'Vargalt'),
(10, 4, 'Caelid', 'Stormveil Castle', 'King Renn, Lord of Storms'),
(11, 4, 'Caelid', 'Weeping Peninsula', 'Yan-Fang, the Red Dragon'),
(12, 4, 'Caelid', 'Purves Rest', 'Venerable Purver'),
(13, 4, 'Caelid', 'Gornea Gorge', 'The Basilisk of Gornea'),
(14, 4, 'Caelid', 'East of Limgrave', 'Black Knight Telvar'),
(15, 5, 'Altus Plateau', 'Mountaintops of the Giants', 'The Elden Beast'),
(16, 5, 'Altus Plateau', 'Roundtable Hold', 'Knight of the Roundtable'),
(17, 5, 'Altus Plateau', 'Siofra Riverhead', 'Siofra the Water Wraith'),
(18, 5, 'Altus Plateau', 'Caelid Bluffs', 'Lady of the Recluse'),
(19, 5, 'Altus Plateau', 'Vargalt Castle', 'Vargalt'),
(20, 5, 'Altus Plateau', 'Stormveil Castle', 'King Renn, Lord of Storms'),
(21, 5, 'Altus Plateau', 'Weeping Peninsula', 'Yan-Fang, the Red Dragon'),
(22, 5, 'Altus Plateau', 'Purvers Rest', 'Venerable Purver'),
(23, 5, 'Altus Plateau', 'Gornea Gorge', 'The Basilisk of Gornea'),
(24, 5, 'Altus Plateau', 'Limgrave', 'Black Knight Telvar'),
(25, 5, 'Altus Plateau', 'Mountaintops of the Giants', 'The Elden Beast'),
(26, 5, 'Altus Plateau', 'Roundtable Hold', 'Knight of the Roundtable'),
(27, 5, 'Altus Plateau', 'Siofra Riverhead', 'Siofra the Water Wraith'),
(28, 3, 'Liurnia of the Lakes', 'Caelid Bluffs', 'Lady of the Recluse'),
(29, 3, 'Liurnia of the Lakes', 'Vargalt Castle', 'Vargalt'),
(30, 3, 'Liurnia of the Lakes', 'Stormveil Castle', 'King Renn, Lord of Storms')

--

INSERT INTO Characters (CharacterID, Attacks, Attributes, DESCRIPTION, Name, Class, Weakness, LocationID, LEVEL)
VALUES
(),

INSERT INTO IsAt (CharacterID, LocationID)
VALUES
(),

INSERT INTO Bosses (CharacterID, Cutscene)
VALUES
(),

INSERT INTO Enemies (CharacterID)
VALUES
(),

INSERT INTO Items (ItemID, DESCRIPTION, UseRequisites, Name, Owner, Award)
VALUES
(),

INSERT INTO CraftingMaterials (CraftingMaterialID, Quantity, Source, CraftingUse, UsedItems)
VALUES
(),

INSERT INTO Crafts (ItemID, CraftingMaterialID)
VALUES
(),

INSERT INTO Weapons (Name, ItemID, Range, Damage, Abilities, ScallingAttributes)
VALUES
(),

INSERT INTO Armours (Name, ItemID, Weight, MagicDefense, PhysicalDefense, ElementDefense)
VALUES
(),

INSERT INTO Talismans (Name, ItemID, Effect)
VALUES
(),

INSERT INTO Magics (Name, ItemID, Effect, ManaCost, DamageType)
VALUES
(),
