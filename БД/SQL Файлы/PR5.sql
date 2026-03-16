USE [Практическая_3]
GO

/*выведите заказы и их суммарную стоимость*/

SELECT IdOrd, SUM(Qty * Price) AS 'Суммарная стоимость заказа'
FROM OrdItem
GROUP BY IdOrd
GO

SELECT [Description], InStock
FROM Product
WHERE [Description] LIKE '%монитор%';

SELECT COUNT(DISTINCT IdCity) AS 'Количество различных городов'
FROM Customer;

SELECT SUM(Qty * Price) AS 'Суммарная стоимость всех заказов'
FROM OrdItem;

SELECT *
FROM [Order]
WHERE OrdDate >= '2010-09-01' AND OrdDate < '2010-10-01'
ORDER BY OrdDate;

SELECT IdCust, COUNT(*) AS 'Количество заказов'
FROM [Order]
WHERE OrdDate >= '2010-09-01' AND OrdDate < '2010-10-01'
GROUP BY IdCust
HAVING COUNT(*) > 3;