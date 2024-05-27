CREATE TABLE [dbo].[Products]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Price] FLOAT NOT NULL, 
    [DateAdded] DATETIME NOT NULL,
    [Description] NVARCHAR(2000), 
    [DiscountPrice] FLOAT NOT NULL, 
    [IsSold] BIT NOT NULL
)
