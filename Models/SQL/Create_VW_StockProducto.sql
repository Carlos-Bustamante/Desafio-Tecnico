CREATE VIEW VW_StockProducto AS
SELECT 
    p.ID,
    p.NOMBRE,
    s.CANTIDAD
FROM 
    Productos p
INNER JOIN 
    Stocks s ON p.ID = s.IdProducto;
