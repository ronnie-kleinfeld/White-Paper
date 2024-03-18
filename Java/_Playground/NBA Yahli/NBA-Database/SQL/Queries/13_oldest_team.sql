-- What was the OldestTeamInLeague?

SELECT tm, AVG(age)
FROM players JOIN player_stats ON name = player
GROUP BY tm
ORDER BY AVG(age) DESC
LIMIT 1;