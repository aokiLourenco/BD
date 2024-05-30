CREATE TRIGGER LEVEL ON Bosses
AFTER INSERT
AS
BEGIN
    DELETE FROM BossView_Table
    WHERE Characters.LEVEL < 100;
    RAISERROR ('The Boss LVL(level) cannot be lower 100.', 16, 1);
    RETURN;
END;
GO