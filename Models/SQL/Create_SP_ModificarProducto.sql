CREATE PROCEDURE sp_ModificarProducto
    @ProductoID INT,
    @IdTipoProducto INT,
    @Nombre NVARCHAR(50),
    @Precio REAL,
    @Cantidad INT
AS
BEGIN
    -- Inicia una transacción
    BEGIN TRANSACTION;

    -- Se intenta realizar las actualizaciones
    BEGIN TRY
        -- Se actualiza el producto
        UPDATE Productos
        SET IdTipoProducto = @IdTipoProducto, NOMBRE = @Nombre, PRECIO = @Precio
        WHERE ID = @ProductoID;

        -- Actualizacion del stock
        UPDATE Stocks
        SET CANTIDAD = @Cantidad
        WHERE IdProducto = @ProductoID;

        -- Confirmacion de la transacción
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Si hay un error, se revierte la transacción
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END
