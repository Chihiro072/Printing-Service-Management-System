CREATE TABLE Users (
    Username VARCHAR(50),
    Password VARCHAR(50),
    Role VARCHAR(50),
	DOB date,
	Gender VARCHAR(50),
	Email VARCHAR(50),
	Address VARCHAR(100)
);

INSERT INTO Users (Username, Password, Role, DOB, Gender, Email, Address)
VALUES
    ('admin', 'admin123', 'admin', '15 Dec 1999', 'Male', 'admin.hahaway@gmail.com', 'Parkhill Residence Block C'),
    ('bryan', 'bryan123', 'student', '2 Apr 2003', 'Male', 'bryan.pradibta@gmail.com', 'Parkhill Residence Block D'),
    ('manager', 'manager123', 'manager', '15 Jun 2003', 'Male', 'he.haowei@gmail.com', 'Shan_Hi'),
    ('student', 'student123', 'student', '11 Oct 2002', 'Male', 'majharul.ruhit@gmail.com', 'Endah Parade'),
    ('worker', 'worker123', 'worker', '19 Feb 2002', 'Male', 'chai.changxing@gmail.com', 'Melacca'),
    ('worker2', 'worker123', 'worker', '18 Nov 2004', 'Female', 'fiona.vanessa@gmail.com', 'Twin Tower');


CREATE TABLE worker (
    workerID INT IDENTITY (1,1) PRIMARY KEY,
    worker NVARCHAR(50)
);
INSERT INTO worker (worker)
VALUES 
('nobody'),
('worker'),
('worker2');

CREATE TABLE OrderHistory (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50),
    Service NVARCHAR(50),
    Quantity INT,
    UnitPrice DECIMAL(10,2),
    Subtotal DECIMAL(10,2),
    RequestDate DATE,
    Status NVARCHAR(50),
	Urgent BIT,
    WorkerID INT,
    FOREIGN KEY (workerID) REFERENCES worker(workerID)
);

INSERT INTO OrderHistory (Username, Service, Quantity, UnitPrice, Subtotal, RequestDate, Status,Urgent,workerID) 
VALUES
('student', 'Banner', 1, 10, 10, '15 Aug 2023', 'Completed', 0, 2),
('bryan', 'Printing A4 - Color', 6, 2.5, 15, '17 Aug 2023', 'Completed', 0, 2),
('student', 'Binding - Comb Binding', 1, 5, 5, '31 Oct 2023', 'Working In Progress', 0, 2),
('bryan', 'Binding - Comb Binding', 1, 5, 5, '31 Oct 2023', 'Working In Progress', 0, 2),
('student', 'Printing A4 - Black and White', 5, 0.8, 4, '31 Oct 2023', 'Working In Progress', 0, 2);

CREATE TABLE PaymentInfo (
    PaymentID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(255) NOT NULL,
	Quantity INT NOT NULL,
    Price DECIMAL(18, 2) NOT NULL,
    Service NVARCHAR(255) NOT NULL,
    CompletionMonth NVARCHAR(2) NOT NULL

); 

INSERT INTO PaymentInfo (Username, Quantity, Price, Service, CompletionMonth)
VALUES
('student', 1, 10.00, 'Banner', '08'),
('bryan', 6, 15.00, 'Printing A4 - Color', '08');

CREATE TABLE Services (
    No INT,
    Service_Type VARCHAR(255),
    Fees DECIMAL(10,2),
	MesaureUnit VARCHAR(255)
);

INSERT INTO Services (No, Service_Type, Fees, MesaureUnit)
VALUES 
    (1, 'Printing A4 每 Black and White', 0.8, 'page'),
    (2, 'Printing A4 每 Color', 2.50,  'page'),
    (3, 'Binding 每 Comb Binding', 5, 'book'),
    (4, 'Binding 每 Thick Cover', 15, 'book'),
    (5, 'Poster printing (A0 每 A3)', 3, 'page'),
    (6, 'Banner', 10, 'banner');


