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
	Role NVARCHAR(50) NOT NULL, -- Phân quyền:Admin/Nhân viên
    Position NVARCHAR(50) NOT NULL,  -- Vị trí công việc
    DateHired DATE NOT NULL DEFAULT GETDATE(), --Ngày vào làm
    Status NVARCHAR(20) NOT NULL, -- Tình trạng (VD: Đang làm việc, Đã nghỉ việc)
    Notes NVARCHAR(MAX) -- Ghi chú thêm nếu cần
);
GO

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
GO

CREATE TABLE Rooms (
    RoomID NVARCHAR(10) PRIMARY KEY, --Số phòng
    RoomType NVARCHAR(50) NOT NULL, -- Loại phòng (VD: Standard, Deluxe, Suite)
    Capacity INT NOT NULL, -- Sức chứa (số người)
    Price DECIMAL(18, 2) NOT NULL, -- Giá phòng mỗi đêm
    Status NVARCHAR(20) NOT NULL, -- Tình trạng phòng (VD: Trống, Đã đặt, Đang bảo trì)
    Description NVARCHAR(MAX), -- Mô tả thêm nếu cần
);
GO

CREATE TABLE RoomBookings (
    BookingID INT PRIMARY KEY,
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
GO

-- Tạo bảng Invoices (Hóa đơn)
CREATE TABLE Invoices (
    InvoiceID INT PRIMARY KEY,
    BookingID INT NOT NULL,
    InvoiceDate DATE NOT NULL,
    TotalAmount DECIMAL(18, 2) NOT NULL, --Tổng tiền
    PaidAmount DECIMAL(18, 2) NOT NULL, -- số tiền đã thanh toán
    PaymentStatus NVARCHAR(20) NOT NULL, -- Tình trạng thanh toán (VD: Chưa thanh toán, Đã thanh toán)
    Notes NVARCHAR(MAX), -- Ghi chú thêm nếu cần
    CONSTRAINT FK_Invoices_RoomBookings FOREIGN KEY (BookingID)
        REFERENCES RoomBookings(BookingID)
);
GO

CREATE TABLE Login (
    Username VARCHAR(20) PRIMARY KEY, -- Tên đăng nhập duy nhất làm khóa chính
    Password VARCHAR(100) NOT NULL,
    Role NVARCHAR(50) NOT NULL,	--Nhân viên/Admin
);
GO

-- Insert dữ liệu vào bảng Employees
INSERT INTO Employees (EmployeeID, FullName, DateOfBirth, Gender, Address, PhoneNumber, Email, Role, Position, DateHired, Status, Notes)
VALUES 
    ('627894563201', N'Nguyễn Văn A', '1985-05-12', N'Nam', N'123 Đường ABC, Hà Nội', '0123456789', 'nguyenvana@example.com', N'Admin', 'Manager', '2020-01-15', N'Đang làm việc', N'Quản lý cấp cao'),
    ('395012847621', N'Trần Thị B', '1990-07-20', N'Nữ', N'456 Đường DEF, TP HCM', '0987654321', 'tranthib@example.com', N'Nhân viên', 'Receptionist', '2019-03-10', N'Đang làm việc', N'Nhân viên lễ tân'),
    ('830916257143', N'Lê Văn C', '1987-09-15', N'Nam', N'789 Đường GHI, Đà Nẵng', '0912345678', 'levanc@example.com', N'Nhân viên', 'Chef', '2021-05-22', N'Đang làm việc', N'Đầu bếp chính'),
    ('610592743186', N'Phạm Thị D', '1995-11-30', N'Nữ', N'101 Đường JKL, Cần Thơ', '0934567890', 'phamthid@example.com', N'Nhân viên', 'Housekeeper', '2022-02-14', N'Đang làm việc', N'Nhân viên dọn phòng'),
    ('721049836527', N'Đặng Văn E', '1988-12-25', N'Nam', N'202 Đường MNO, Hải Phòng', '0923456781', 'dangvane@example.com', N'Nhân viên', 'Bellboy', '2023-07-19', N'Đang làm việc', N'Nhân viên hành lý'),
    ('360927581043', N'Ngô Thị F', '1993-03-08', N'Nữ', N'303 Đường PQR, Vũng Tàu', '0945678901', 'ngothif@example.com', N'Nhân viên', 'Waitress', '2020-09-28', N'Đang làm việc', N'Nhân viên phục vụ'),
    ('598432716095', N'Hoàng Văn G', '1986-01-17', N'Nam', N'404 Đường STU, Nha Trang', '0956789012', 'hoangvang@example.com', N'Nhân viên', 'Security', '2021-11-06', N'Đang làm việc', N'Nhân viên bảo vệ'),
    ('537469182035', N'Vũ Thị H', '1992-04-14', N'Nữ', N'505 Đường VWX, Huế', '0967890123', 'vuthih@example.com', N'Nhân viên', 'Receptionist', '2022-03-22', N'Đang làm việc', N'Nhân viên lễ tân'),
    ('290815673214', N'Bùi Văn I', '1989-06-22', N'Nam', N'606 Đường YZ, Quy Nhơn', '0978901234', 'buivani@example.com', N'Nhân viên', 'Concierge', '2019-08-17', N'Đang làm việc', N'Nhân viên hỗ trợ khách hàng'),
    ('157982430965', N'Đỗ Thị J', '1994-09-18', N'Nữ', N'707 Đường ABC, Đà Lạt', '0989012345', 'dothij@example.com', N'Nhân viên', 'Housekeeper', '2021-12-30', N'Đang làm việc', N'Nhân viên dọn phòng'),
    ('492578130647', N'Trịnh Văn K', '1985-02-10', N'Nam', N'808 Đường DEF, Biên Hòa', '0990123456', 'trinhvank@example.com', N'Admin', 'IT Manager', '2020-06-25', N'Đang làm việc', N'Quản lý IT'),
    ('370682915493', N'Phan Thị L', '1991-10-05', N'Nữ', N'909 Đường GHI, Buôn Ma Thuột', '0911234567', 'phanthil@example.com', N'Nhân viên', 'Chef', '2018-07-14', N'Đang làm việc', N'Đầu bếp'),
    ('860324179582', N'Đinh Văn M', '1986-11-11', N'Nam', N'010 Đường JKL, Phú Quốc', '0922345678', 'dinhvanm@example.com', N'Nhân viên', 'Security', '2023-01-23', N'Đang làm việc', N'Nhân viên bảo vệ'),
    ('419578630724', N'Lý Thị N', '1990-08-15', N'Nữ', N'111 Đường MNO, Ninh Bình', '0933456789', 'lythin@example.com', N'Nhân viên', 'Waitress', '2019-04-08', N'Đang làm việc', N'Nhân viên phục vụ'),
    ('985674310726', N'Cao Văn O', '1987-12-29', N'Nam', N'212 Đường PQR, Long An', '0944567890', 'caovano@example.com', N'Nhân viên', 'Bellboy', '2020-10-05', N'Đang làm việc', N'Nhân viên hành lý'),
    ('213486507924', N'Hồ Thị P', '1993-05-19', N'Nữ', N'313 Đường STU, Tây Ninh', '0955678901', 'hothip@example.com', N'Nhân viên', 'Receptionist', '2022-09-12', N'Đang làm việc', N'Nhân viên lễ tân'),
    ('587136420935', N'Dương Văn Q', '1988-03-14', N'Nam', N'414 Đường VWX, Hòa Bình', '0966789012', 'duongvanq@example.com', N'Nhân viên', 'Concierge', '2021-03-30', N'Đang làm việc', N'Nhân viên hỗ trợ khách hàng'),
    ('630795284671', N'Vương Thị R', '1995-07-24', N'Nữ', N'515 Đường YZ, Quảng Ninh', '0977890123', 'vuongthir@example.com', N'Nhân viên', 'Housekeeper', '2019-11-18', N'Đang làm việc', N'Nhân viên dọn phòng'),
    ('498325176403', N'Tạ Văn S', '1989-04-09', N'Nam', N'616 Đường ABC, Nam Định', '0988901234', 'tavans@example.com', N'Nhân viên', 'Security', '2023-05-21', N'Đang làm việc', N'Nhân viên bảo vệ'),
    ('234671592830', N'Đỗ Thị T', '1992-01-06', N'Nữ', N'717 Đường DEF, Hưng Yên', '0999012345', 'dothit@example.com', N'Nhân viên', 'Waitress', '2022-01-09', N'Đang làm việc', N'Nhân viên phục vụ');
GO

-- Insert dữ liệu vào bảng Customers
INSERT INTO Customers (CustomerID, FullName, DateOfBirth, Gender, Address, PhoneNumber, Email, DateJoined, Notes)
VALUES 
    ('839671524308', N'Michael Johnson', '1985-03-10', N'Nam', N'789 Main Road, City', '111222333', 'michael.johnson@example.com', '2023-01-05', N'Frequent guest'),
    ('573812964031', N'Emily Brown', '1992-07-25', N'Nữ', N'321 Park Avenue, City', '444555666', 'emily.brown@example.com', '2022-12-15', N'VIP member'),
    ('420587691324', N'David Wilson', '1987-09-05', N'Nam', N'567 Pine Lane, City', '333222111', 'david.wilson@example.com', '2024-05-20', N'Regular guest'),
    ('935461207824', N'Sophia Lee', '1991-07-30', N'Nữ', N'890 Oak Drive, City', '555666777', 'sophia.lee@example.com', '2021-04-18', N'Business traveler'),
    ('608275139472', N'Robert Martinez', '1994-04-17', N'Nam', N'234 Cedar Street, City', '777888999', 'robert.martinez@example.com', '2022-11-05', N'Vacationer'),
    ('754296801321', N'Jessica Robinson', '1989-12-25', N'Nữ', N'876 Elm Road, City', '666555444', 'jessica.robinson@example.com', '2023-09-30', N'Returning guest'),
    ('172830964521', N'Daniel Taylor', '1996-03-08', N'Nam', N'543 Birch Avenue, City', '222333444', 'daniel.taylor@example.com', '2021-06-12', N'First-time visitor'),
    ('530942687154', N'Megan Lewis', '1990-10-31', N'Nữ', N'432 Walnut Drive, City', '888999000', 'megan.lewis@example.com', '2024-08-22', N'Regular guest'),
    ('490725836142', N'Christopher Hall', '1985-06-20', N'Nam', N'678 Maple Street, City', '333444555', 'christopher.hall@example.com', '2022-12-03', N'Business traveler'),
    ('682540319476', N'Amanda Young', '1992-04-14', N'Nữ', N'987 Pine Lane, City', '555444333', 'amanda.young@example.com', '2021-02-28', N'Returning guest'),
    ('295847631420', N'John Doe', '1985-01-01', N'Nam', N'123 Elm Street, City', '1234567890', 'john.doe@example.com', '2023-01-01', N'New customer'),
    ('856312049731', N'Jane Smith', '1990-02-02', N'Nữ', N'456 Oak Avenue, City', '2345678901', 'jane.smith@example.com', '2023-01-02', N'Returning guest'),
    ('610259438721', N'Samuel Green', '1983-11-22', N'Nam', N'987 Willow Drive, City', '3456789012', 'samuel.green@example.com', '2023-02-12', N'Occasional guest'),
    ('374509612843', N'Alice White', '1992-05-10', N'Nữ', N'654 Cedar Lane, City', '4567890123', 'alice.white@example.com', '2022-10-25', N'VIP member'),
    ('928647350124', N'Paul Harris', '1986-08-15', N'Nam', N'321 Oak Street, City', '5678901234', 'paul.harris@example.com', '2024-04-18', N'Regular guest'),
    ('451289763102', N'Anna Clark', '1991-03-20', N'Nữ', N'432 Maple Road, City', '6789012345', 'anna.clark@example.com', '2023-11-11', N'Business traveler'),
    ('739682514201', N'Edward Lewis', '1994-12-30', N'Nam', N'123 Birch Avenue, City', '7890123456', 'edward.lewis@example.com', '2023-07-09', N'Vacationer'),
    ('182504937621', N'Sophia Evans', '1988-10-12', N'Nữ', N'234 Walnut Lane, City', '8901234567', 'sophia.evans@example.com', '2022-05-08', N'Returning guest'),
    ('305964271842', N'Henry Collins', '1996-01-19', N'Nam', N'345 Elm Drive, City', '9012345678', 'henry.collins@example.com', '2023-09-01', N'First-time visitor'),
    ('819743652041', N'Laura King', '1990-09-05', N'Nữ', N'567 Oak Avenue, City', '0123456789', 'laura.king@example.com', '2023-03-15', N'Regular guest'),
    ('924361078531', N'Peter Wright', '1985-05-14', N'Nam', N'789 Pine Street, City', '1234567891', 'peter.wright@example.com', '2022-11-03', N'Business traveler'),
    ('675492183014', N'Linda Scott', '1992-04-18', N'Nữ', N'890 Maple Lane, City', '2345678902', 'linda.scott@example.com', '2021-06-20', N'Returning guest'),
    ('471820965342', N'Charles Baker', '1980-12-25', N'Nam', N'123 Cedar Street, City', '3456789013', 'charles.baker@example.com', '2023-08-10', N'Frequent guest'),
    ('823674019521', N'Olivia Allen', '1989-07-23', N'Nữ', N'234 Elm Avenue, City', '4567890124', 'olivia.allen@example.com', '2022-01-05', N'New customer'),
    ('367598124510', N'George Turner', '1983-06-22', N'Nam', N'345 Birch Street, City', '5678901235', 'george.turner@example.com', '2023-12-01', N'Business traveler'),
    ('509376241328', N'Emily Hill', '1991-01-30', N'Nữ', N'456 Oak Road, City', '6789012346', 'emily.hill@example.com', '2023-07-25', N'VIP member'),
    ('247850163591', N'James Adams', '1988-02-28', N'Nam', N'567 Pine Drive, City', '7890123457', 'james.adams@example.com', '2024-05-02', N'Regular guest'),
    ('936127540821', N'Samantha Nelson', '1990-08-14', N'Nữ', N'678 Maple Lane, City', '8901234568', 'samantha.nelson@example.com', '2023-02-28', N'Vacationer'),
    ('512398467230', N'Oliver Carter', '1985-03-16', N'Nam', N'789 Elm Avenue, City', '9012345679', 'oliver.carter@example.com', '2024-03-17', N'Frequent guest'),
    ('780254916432', N'Natalie Parker', '1992-11-22', N'Nữ', N'890 Cedar Street, City', '0123456790', 'natalie.parker@example.com', '2023-04-19', N'Returning guest'),
    ('394762150283', N'Ryan Moore', '1983-01-13', N'Nam', N'123 Oak Lane, City', '1234567892', 'ryan.moore@example.com', '2023-06-13', N'New customer'),
    ('657189234012', N'Sophia Thompson', '1994-12-10', N'Nữ', N'234 Pine Street, City', '2345678903', 'sophia.thompson@example.com', '2023-05-14', N'Regular guest'),
    ('945608273124', N'Jackson Brown', '1987-09-08', N'Nam', N'345 Maple Avenue, City', '3456789014', 'jackson.brown@example.com', '2023-09-25', N'Frequent guest'),
    ('319875462041', N'Mia Garcia', '1990-10-29', N'Nữ', N'456 Birch Street, City', '4567890125', 'mia.garcia@example.com', '2023-04-24', N'VIP member'),
    ('826345179420', N'David Martin', '1985-11-15', N'Nam', N'567 Cedar Avenue, City', '5678901236', 'david.martin@example.com', '2023-12-13', N'Business traveler'),
    ('207948563912', N'Sophia Davis', '1991-06-17', N'Nữ', N'678 Elm Road, City', '6789012347', 'sophia.davis@example.com', '2023-03-16', N'Returning guest'),
    ('185396472301', N'Michael Thomas', '1988-04-18', N'Nam', N'789 Oak Drive, City', '7890123458', 'michael.thomas@example.com', '2023-05-17', N'Frequent guest'),
    ('732489615420', N'Emily Martinez', '1994-05-21', N'Nữ', N'890 Pine Lane, City', '8901234569', 'emily.martinez@example.com', '2023-06-18', N'Regular guest'),
    ('576198243051', N'David Lee', '1985-06-13', N'Nam', N'901 Maple Avenue, City', '9012345680', 'david.lee@example.com', '2023-07-19', N'Business traveler'),
    ('693417580124', N'Sophia Young', '1992-07-26', N'Nữ', N'234 Cedar Street, City', '0123456791', 'sophia.young@example.com', '2023-08-20', N'VIP member');
GO

-- Insert dữ liệu vào bảng Login
INSERT INTO Login (Username, Password, Role)
VALUES 
    ('627894563201', '627894563201@123', N'Admin'),
    ('395012847621', '395012847621@123', N'Nhân viên'),
    ('830916257143', '830916257143@123', N'Nhân viên'),
    ('610592743186', '610592743186@123', N'Nhân viên'),
    ('721049836527', '721049836527@123', N'Nhân viên'),
    ('360927581043', '360927581043@123', N'Nhân viên'),
    ('598432716095', '598432716095@123', N'Nhân viên'),
    ('537469182035', '537469182035@123', N'Nhân viên'),
    ('290815673214', '290815673214@123', N'Nhân viên'),
    ('157982430965', '157982430965@123', N'Nhân viên'),
    ('492578130647', '492578130647@123', N'Admin'),
    ('370682915493', '370682915493@123', N'Nhân viên'),
    ('860324179582', '860324179582@123', N'Nhân viên'),
    ('419578630724', '419578630724@123', N'Nhân viên'),
    ('985674310726', '985674310726@123', N'Nhân viên'),
    ('213486507924', '213486507924@123', N'Nhân viên'),
    ('587136420935', '587136420935@123', N'Nhân viên'),
    ('630795284671', '630795284671@123', N'Nhân viên'),
    ('498325176403', '498325176403@123', N'Nhân viên'),
    ('234671592830', '234671592830@123', N'Nhân viên');
GO

-- Insert dữ liệu vào bảng Rooms
INSERT INTO Rooms (RoomID, RoomType, Capacity, Price, Status, Description)
VALUES 
    ('RM1', 'Standard', 2, 500000, N'Trống', N'Phòng tiêu chuẩn với giường đôi và view vườn.'),
    ('RM2', 'Standard', 2, 500000, N'Trống', N'Phòng tiêu chuẩn với giường đôi và view thành phố.'),
    ('RM3', 'Deluxe', 3, 750000, N'Trống', N'Phòng deluxe với giường đôi và giường đơn, view biển.'),
    ('RM4', 'Deluxe', 3, 750000, N'Trống', N'Phòng deluxe với giường đôi và giường đơn, view vườn.'),
    ('RM5', 'Suite', 4, 1000000, N'Trống', N'Phòng suite sang trọng với hai giường đôi, view biển.'),
    ('RM6', 'Suite', 4, 1000000, N'Trống', N'Phòng suite sang trọng với hai giường đôi, view núi.'),
    ('RM7', 'Standard', 2, 500000, N'Trống', N'Phòng tiêu chuẩn với giường đôi và view hồ bơi.'),
    ('RM8', 'Standard', 2, 500000, N'Trống', N'Phòng tiêu chuẩn với giường đôi và view sông.'),
    ('RM9', 'Deluxe', 3, 750000, N'Trống', N'Phòng deluxe với giường đôi và giường đơn, view thành phố.'),
    ('RM0', 'Deluxe', 3, 750000, N'Trống', N'Phòng deluxe với giường đôi và giường đơn, view hồ bơi.'),
    ('RM11', 'Suite', 4, 1000000, N'Trống', N'Phòng suite sang trọng với hai giường đôi, view sông.'),
    ('RM12', 'Suite', 4, 1000000, N'Trống', N'Phòng suite sang trọng với hai giường đôi, view thành phố.'),
    ('RM13', 'Standard', 2, 500000, N'Trống', N'Phòng tiêu chuẩn với giường đôi và view núi.'),
    ('RM14', 'Standard', 2, 500000, N'Trống', N'Phòng tiêu chuẩn với giường đôi và view vườn.'),
    ('RM15', 'Deluxe', 3, 750000, N'Trống', N'Phòng deluxe với giường đôi và giường đơn, view hồ bơi.'),
    ('RM16', 'Deluxe', 3, 750000, N'Trống', N'Phòng deluxe với giường đôi và giường đơn, view vườn.'),
    ('RM17', 'Suite', 4, 1000000, N'Trống', N'Phòng suite sang trọng với hai giường đôi, view sông.'),
    ('RM18', 'Suite', 4, 1000000, N'Trống', N'Phòng suite sang trọng với hai giường đôi, view biển.'),
    ('RM19', 'Standard', 2, 500000, N'Trống', N'Phòng tiêu chuẩn với giường đôi và view thành phố.'),
    ('RM20', 'Standard', 2, 500000, N'Trống', N'Phòng tiêu chuẩn với giường đôi và view hồ bơi.'),
    ('RM21', 'Deluxe', 3, 750000, N'Trống', N'Phòng deluxe với giường đôi và giường đơn, view vườn.'),
    ('RM22', 'Deluxe', 3, 750000, N'Trống', N'Phòng deluxe với giường đôi và giường đơn, view thành phố.'),
    ('RM23', 'Suite', 4, 1000000, N'Trống', N'Phòng suite sang trọng với hai giường đôi, view sông.'),
    ('RM24', 'Suite', 4, 1000000, N'Trống', N'Phòng suite sang trọng với hai giường đôi, view núi.'),
    ('RM25', 'Standard', 2, 500000, N'Trống', N'Phòng tiêu chuẩn với giường đôi và view biển.'),
    ('RM26', 'Standard', 2, 500000, N'Trống', N'Phòng tiêu chuẩn với giường đôi và view vườn.'),
    ('RM27', 'Deluxe', 3, 750000, N'Trống', N'Phòng deluxe với giường đôi và giường đơn, view hồ bơi.'),
    ('RM28', 'Deluxe', 3, 750000, N'Trống', N'Phòng deluxe với giường đôi và giường đơn, view biển.'),
    ('RM29', 'Suite', 4, 1000000, N'Trống', N'Phòng suite sang trọng với hai giường đôi, view thành phố.'),
    ('RM30', 'Suite', 4, 1000000, N'Trống', N'Phòng suite sang trọng với hai giường đôi, view vườn.');
GO
