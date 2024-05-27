CREATE PROCEDURE [dbo].[INSERT_Product]
	@Title NVARCHAR(250),
	@Price float,
	@DateAdded DATETIME,
	@Description NVARCHAR(250),
	@DiscountPrice float,
	@IsSold BIT
AS
INSERT INTO Products
(Id, Title, Price ,DateAdded, Description, DiscountPrice, IsSold)
values
(NEWID(), @Title, @Price ,SYSUTCDATETIME(), @Description, @DiscountPrice, @IsSold)