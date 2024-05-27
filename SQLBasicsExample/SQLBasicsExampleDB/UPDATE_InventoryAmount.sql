CREATE PROCEDURE [dbo].[UPDATE_InventoryAmount]
	@InventoryId INT,
	@Amount INT
AS
UPDATE Inventory SET Amount = @Amount  WHERE InventoryId = @InventoryID                                                                          
 

