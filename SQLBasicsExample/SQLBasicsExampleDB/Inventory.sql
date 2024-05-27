CREATE TABLE [dbo].[Inventory]
(
	[InventoryId] INT IDENTITY(1,1) PRIMARY KEY,
    [ProductReference] UNIQUEIDENTIFIER NOT NULL, 
    [Amount] INT NOT NULL, 
    [DateUpdated] DATETIME NOT NULL,
    CONSTRAINT FK_ProductReference FOREIGN KEY (ProductReference) REFERENCES Products(Id)
)
