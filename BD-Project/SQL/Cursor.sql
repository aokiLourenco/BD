
CREATE PROCEDURE GetEnemiesWithAttack(@Attack VARCHAR(512), @AttackTotal INT OUTPUT)
AS
BEGIN
    DECLARE @EnemyCount INT

    DECLARE enemyCursor CURSOR FOR
    SELECT COUNT(*) AS EnemyCount
    FROM Enemies e
    JOIN Characters c ON e.CharacterID = c.CharacterID
    WHERE c.Attacks = @Attack

    OPEN enemyCursor
    FETCH NEXT FROM enemyCursor INTO @EnemyCount

    IF @@FETCH_STATUS = 0
    BEGIN
        SET @AttackTotal = @EnemyCount
    END

    CLOSE enemyCursor
    DEALLOCATE enemyCursor
END