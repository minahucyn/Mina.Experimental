CREATE PROCEDURE [dbo].[usp_UpdatePerson]
	@Id INT,
	@FirstName VARCHAR(100) ,
	@LastName VARCHAR(100) ,
	@Birthdate DATE,
	@IsAsian bit
AS
BEGIN
SET NOCOUNT ON;
	UPDATE dbo.Person
	SET FirstName = @FirstName,
		LastName = @LastName,
		Birthdate = @Birthdate,
		IsAsian = @IsAsian
		WHERE Id = @Id;
END