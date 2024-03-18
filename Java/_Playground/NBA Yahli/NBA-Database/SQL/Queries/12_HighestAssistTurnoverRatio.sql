-- Which PlayerHighestAssistToTurnoverRatio?

SELECT player, ast, tov, CAST(ast as FLOAT)/CAST(tov as FLOAT) as astTovRatio
FROM player_stats
WHERE tov > 0 AND ast > 0
ORDER BY astTovRatio DESC
LIMIT 1;
