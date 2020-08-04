CREATE DATABASE HotelDB;
GO

USE HotelDB;
Go

CREATE TABLE tblManager(
    ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(50),
	Surname nvarchar(50),
	DateOfBirth date,
	Email nvarchar(20),
	Username nvarchar(20),
	Password nvarchar(20),
	Floor nvarchar(10),
	Experience int,
	Qualifications nvarchar(5)
);