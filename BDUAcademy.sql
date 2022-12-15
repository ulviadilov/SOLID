CREATE DATABASE BDUAcademy

USE BDUAcademy

CREATE TABLE Teachers
(
	Id INT IDENTITY PRIMARY KEY ,
	Name VARCHAR(20),
	Surname VARCHAR(20),
	Age INT,
	Experience INT
)

USE BDUAcademy
CREATE TABLE Students
(
		Id INT IDENTITY PRIMARY KEY,
		Name NVARCHAR(20),
		Surname NVARCHAR(20),
		Age INT 
)

SELECT * FROM Teachers
INSERT INTO Teachers(Name,Surname,Age,Experience)
VALUES
('Yusif','Guluzada',25,7),
('Khanim','Gurbanli',24,5)
	
SELECT * FROM Students
INSERT INTO Students(Name,Surname,Age)
VALUES
('Ulvi','Adilov',19)
