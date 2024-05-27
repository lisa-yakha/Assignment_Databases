CREATE PROCEDURE [dbo].[DELETE_Product_by_Title]
	@Title NVARCHAR(50)
AS
DELETE FROM Products WHERE Title = @Title
