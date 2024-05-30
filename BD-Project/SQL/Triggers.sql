DROP TRIGGER IF EXISTS trg_RemoveLowLevelCharacter
GO

CREATE TRIGGER trg_RemoveLowLevelCharacter
ON Bosses
AFTER INSERT
AS
BEGIN
    -- Delete rows where the character's level is less than 100
    DELETE b
    FROM Bosses b
    JOIN Characters c ON b.CharacterID = c.CharacterID
    WHERE c.Level < 100;
    RAISERROR ('The Boss LVL(level) cannot be lower than 100.', 16, 1);
    RETURN;
END;
GO