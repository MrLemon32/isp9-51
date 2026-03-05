SELECT IdOrd, SUM(Qty * Price) AS 'Суммарная стоимость заказа'
FROM OrdItem
GROUP BY IdOrd;