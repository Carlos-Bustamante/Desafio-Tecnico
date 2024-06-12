CREATE PROCEDURE sp_EliminarProducto
    @ProductoID INT
AS
BEGIN
    -- Inicia una transacci�n
    BEGIN TRANSACTION;

    -- Intenta realizar la eliminacion
    BEGIN TRY
        -- Eliminar del stock
        DELETE FROM Stocks
        WHERE IdProducto = @ProductoID;

        -- Eliminar el producto
        DELETE FROM Productos
        WHERE ID = @ProductoID;

        -- Confirmar la transacci�n
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Si hay un error revierte la transacci�n
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END
