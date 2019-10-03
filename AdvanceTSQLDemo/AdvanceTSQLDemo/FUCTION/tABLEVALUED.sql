USE [Northwind]
GO

/****** Object:  UserDefinedFunction [dbo].[TABLEVALUEeXAMPLE]    Script Date: 9/9/2019 1:52:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[TABLEVALUEeXAMPLE] (@EMPID INT) 
	RETURNS TABLE
AS

RETURN (SELECT EmployeeID,FirstName,LastName 
	FROM Employees WHERE EmployeeID <> @EMPID
		GROUP BY FirstName,EmployeeID,LastName) 


GO


