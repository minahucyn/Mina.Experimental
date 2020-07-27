CREATE PROCEDURE dbo.usp_InsertPerson
	@FirstName VARCHAR(100) ,
	@LastName VARCHAR(100) ,
	@Birthdate DATE,
	@IsAsian BIT

AS
BEGIN
SET NOCOUNT ON;
	INSERT INTO dbo.Person (FirstName, LastName,Birthdate,IsAsian)
	VALUES (@Firstname, @LastName,@Birthdate,@IsAsian);
END