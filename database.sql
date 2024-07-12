create database HotelManagement
go

use HotelManagement
go

CREATE TABLE Employees (
    EmployeeID VARCHAR(20) PRIMARY KEY, --Số CCCD
    FullName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    PhoneNumber NVARCHAR(20) UNIQUE,
    Email NVARCHAR(100) UNIQUE,
    Position NVARCHAR(50) NOT NULL,  -- Vị trí công việc (VD: Quản lý, Lễ tân, Phục vụ)
    DateHired DATE NOT NULL DEFAULT GETDATE(), --Ngày vào làm
    Status NVARCHAR(20) NOT NULL, -- Tình trạng (VD: Đang làm việc, Đã nghỉ việc)
    Notes NVARCHAR(MAX) -- Ghi chú thêm nếu cần
);

CREATE TABLE Customers (
    CustomerID VARCHAR(20) PRIMARY KEY ,-- Số chứng minh nhân dân hoặc hộ chiếu
    FullName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NOT NULL,
    Gender NVARCHAR(10) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    PhoneNumber NVARCHAR(20) UNIQUE,
    Email NVARCHAR(100) UNIQUE,
    DateJoined DATE NOT NULL DEFAULT GETDATE(), -- Ngày bắt đầu làm khách hàng
    Notes NVARCHAR(MAX) -- Ghi chú thêm nếu cần
);

CREATE TABLE Rooms (
    RoomID NVARCHAR(10) PRIMARY KEY, --Số phòng
    RoomType NVARCHAR(50) NOT NULL, -- Loại phòng (VD: Standard, Deluxe, Suite)
    Capacity INT NOT NULL, -- Sức chứa (số người)
    Price DECIMAL(18, 2) NOT NULL, -- Giá phòng mỗi đêm
    Status NVARCHAR(20) NOT NULL, -- Tình trạng phòng (VD: Trống, Đã đặt, Đang bảo trì)
    Description NVARCHAR(MAX), -- Mô tả thêm nếu cần
);

CREATE TABLE RoomBookings (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID VARCHAR(20) NOT NULL,
    RoomID NVARCHAR(10) NOT NULL,
    CheckInDate DATE NOT NULL,
    CheckOutDate DATE NOT NULL,
    NumberOfGuests INT NOT NULL,
    TotalPrice DECIMAL(18, 2) NOT NULL,
    BookingStatus NVARCHAR(20) NOT NULL, -- Tình trạng đặt phòng (VD: Đã đặt, Đã hủy, Đã hoàn thành)
    Notes NVARCHAR(MAX), -- Ghi chú thêm nếu cần
    CONSTRAINT FK_RoomBookings_Customers FOREIGN KEY (CustomerID)
        REFERENCES Customers(CustomerID),
    CONSTRAINT FK_RoomBookings_Rooms FOREIGN KEY (RoomID)
        REFERENCES Rooms(RoomID)
);

-- Tạo bảng Invoices (Hóa đơn)
CREATE TABLE Invoices (
    InvoiceID INT PRIMARY KEY IDENTITY(1,1),
    BookingID INT NOT NULL,
    InvoiceDate DATE NOT NULL,
    TotalAmount DECIMAL(18, 2) NOT NULL, --Tổng tiền
    PaidAmount DECIMAL(18, 2) NOT NULL, -- số tiền đã thanh toán
    PaymentStatus NVARCHAR(20) NOT NULL, -- Tình trạng thanh toán (VD: Chưa thanh toán, Đã thanh toán)
    Notes NVARCHAR(MAX), -- Ghi chú thêm nếu cần
    CONSTRAINT FK_Invoices_RoomBookings FOREIGN KEY (BookingID)
        REFERENCES RoomBookings(BookingID)
);


