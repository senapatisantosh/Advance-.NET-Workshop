USE [Northwind]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeRecord]    Script Date: 9/6/2019 5:44:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetEmployeeRecord]
(
	
	@EMPID INT = 9, -- INPUT PARAMETER WITH A DEFAULT
	@SHOWMESSAGE BIT,
	@FName  nvarchar(MAX) = NULL OUTPUT
)  
AS
BEGIN
	DECLARE @I INT
	SET @I = 0
	IF @SHOWMESSAGE = 1
	BEGIN
		SELECT @FName= FirstName FROM 
		[Northwind].[dbo].[Employees] WHERE EmployeeID = @EMPID
		WHILE @I<5
		BEGIN
			PRINT @FName
			SET @I = @I+1
		END
	END
	RETURN 1
END
GO

