SELECT IdCust, COUNT(*) AS 'Количество заказов'
FROM [Order]
WHERE OrdDate >= '2010-09-01' AND OrdDate < '2010-10-01'
GROUP BY IdCust
HAVING COUNT(*) > 3;