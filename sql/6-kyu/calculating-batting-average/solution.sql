/* Your Query Here */
SELECT player_name, games, 
CAST(ROUND((CAST(hits as decimal)/CAST(at_bats as decimal)), 3) as varchar) as "batting_average" 
FROM yankees
WHERE at_bats >= 100
ORDER BY "batting_average" DESC