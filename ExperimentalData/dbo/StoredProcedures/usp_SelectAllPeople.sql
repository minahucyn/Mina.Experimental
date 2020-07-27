CREATE PROCEDURE [dbo].[usp_SelectAllPeople]
AS
	SELECT Id,FirstName,LastName,Birthdate, IsAsian
	FROM dbo.Person;
RETURN 0
