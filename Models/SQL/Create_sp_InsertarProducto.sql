CREATE PROCEDURE sp_InsertarProducto
    @IdTipoProducto INT,
    @Nombre NVARCHAR(50),
    @Precio REAL,
    @Cantidad INT
AS
BEGIN
    -- Inicia una transacci�n
    BEGIN TRANSACTION;

    -- Seguimiento de error, intenta realizar las inserciones
    BEGIN TRY
        -- Inserta el producto
        INSERT INTO Productos (IdTipoProducto, NOMBRE, PRECIO)
        VALUES (@IdTipoProducto, @Nombre, @Precio);

        -- Se obtiene el ID del producto reci�n insertado para insertar el stock
        DECLARE @ProductoID INT;
        SET @ProductoID = SCOPE_IDENTITY();

        -- Insercion en el stock abiendo obtenido el ID
        INSERT INTO Stocks (IdProducto, CANTIDAD)
        VALUES (@ProductoID, @Cantidad);

        -- Confirmacion de la transacci�n
        COMMIT TRANSACTION;
    END TRY

    BEGIN CATCH
        -- Si hay un error, rollback para revertir la transacci�n
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END
