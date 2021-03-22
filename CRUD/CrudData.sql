USE DemoCRUD

CREATE TABLE tbl_Employee(
	Sr_no INT PRIMARY KEY IDENTITY(1,1),
	Emp_name NVARCHAR(500) NOT NULL,
	City NVARCHAR(500),
	STATE NVARCHAR(500),
	Country NVARCHAR(500),
	Department NVARCHAR(500),
	flag NVARCHAR(500)
)

SELECT * FROM tbl_Employee
CREATE PROC	Sp_Employee
@Sr_no int, @Emp_name nvarchar(500),
@City nvarchar(500), @STATE nvarchar(500),
@Country nvarchar(500), @Department nvarchar(500),
@flag nvarchar(50)
AS 
BEGIN
   	IF (@flag = 'insert')
	BEGIN
		INSERT INTO tbl_Employee (Emp_name, City, STATE, Country, Department)
		VALUES (@Emp_name, @City, @STATE, @Country, @Department)
	END
	ELSE IF (@flag = 'update')
	BEGIN
		UPDATE dbo.tbl_Employee SET
			Emp_name = @Emp_name, City = @City,
			STATE = @STATE, Country = @Country,
			Department = @Department
		WHERE Sr_no = @Sr_no
	END
	ELSE IF (@flag = 'delete')
	BEGIN
		DELETE FROM	dbo.tbl_Employee
		WHERE Sr_no = @Sr_no
	END
	ELSE IF	(@flag = 'getid')
	BEGIN
		SELECT * FROM dbo.tbl_Employee
		WHERE Sr_no = @Sr_no
	END
	ELSE IF (@flag = 'get')
	BEGIN
		SELECT * FROM dbo.tbl_Employee
	END
END
