SELECT c.customer_id, c.email, 
  COUNT(p.*) AS "payments_count", SUM(CAST(p.amount AS float)) AS "total_amount" 
FROM customer c INNER JOIN payment p
  ON c.customer_id = p.customer_id 
GROUP BY c.customer_id, c.email
ORDER BY SUM(p.amount) DESC
OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY