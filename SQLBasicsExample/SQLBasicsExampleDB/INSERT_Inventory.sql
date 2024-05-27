CREATE PROCEDURE [dbo].[INSERT_Inventory]
	@ProductReference UNIQUEIDENTIFIER,
	@Amount INT,
	@DateUpdated DATETIME
AS
INSERT INTO Inventory
(ProductReference, Amount, DateUpdated)
values
( @ProductReference, @Amount ,SYSUTCDATETIME())