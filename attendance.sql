use EmployeeDB;
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(50) NOT NULL,
    Role VARCHAR(20) NOT NULL
);
CREATE TABLE Employees (
    EmployeeID VARCHAR(10) PRIMARY KEY,
    FullName VARCHAR(100) NOT NULL,
    NIC VARCHAR(20) UNIQUE NOT NULL,
    Address VARCHAR(200),
    ContactNo VARCHAR(15),
    Email VARCHAR(100),
    JobRole VARCHAR(50),
    Salary DECIMAL(10,2)
);
CREATE TABLE Attendance (
    AttendanceID INT IDENTITY(1,1) PRIMARY KEY,
    EmployeeID VARCHAR(10) NOT NULL,
    AttendanceDate DATE NOT NULL,
    TimeIn TIME NULL,
    TimeOut TIME NULL,

    CONSTRAINT FK_Attendance_Employee
    FOREIGN KEY (EmployeeID)
    REFERENCES Employees(EmployeeID)
);
SELECT * FROM Employees;
SELECT * FROM Attendance;
SELECT * FROM Users;


