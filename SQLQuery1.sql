USE [p2743341]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblSupplier_SelectALL]

SELECT	@return_value as 'Return Value'

GO
