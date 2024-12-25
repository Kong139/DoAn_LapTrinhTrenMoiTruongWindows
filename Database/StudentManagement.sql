-- Tạo cơ sở dữ liệu mới
CREATE DATABASE StudentManagement;
GO

-- Sử dụng cơ sở dữ liệu vừa tạo
USE StudentManagement;
GO


-- 1. Tạo bảng Faculty
CREATE TABLE Faculty (
    FacultyID INT IDENTITY(1,1) PRIMARY KEY,
    FacultyName NVARCHAR(50) NOT NULL
);
GO

-- 2. Tạo bảng Status
CREATE TABLE Status (
    StatusID INT IDENTITY(1,1) PRIMARY KEY,
    StatusName NVARCHAR(20) NOT NULL
);
GO

-- 3. Tạo bảng Major
CREATE TABLE Major (
    MajorID INT IDENTITY(1,1) PRIMARY KEY,
    MajorName NVARCHAR(50) NOT NULL,
    FacultyID INT NOT NULL,
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID)
);
GO

-- 4. Tạo bảng Subject
CREATE TABLE Subject (
    SubjectID VARCHAR(10) PRIMARY KEY,
    SubjectName NVARCHAR(50) NOT NULL,
    CreditHours INT NOT NULL
);
GO

-- 5. Tạo bảng ScoreCategory
CREATE TABLE ScoreCategory (
    ScoreCategoryID VARCHAR(2) PRIMARY KEY,
    ScoreCategoryName NVARCHAR(20) NOT NULL,
    Weight INT NOT NULL
);
GO

-- 6. Tạo bảng Student
CREATE TABLE Student (
    StudentID VARCHAR(10) PRIMARY KEY,
    StudentName NVARCHAR(50) NOT NULL,
    Class VARCHAR(10) NOT NULL,
	GPA FLOAT NOT NULL,
    FacultyID INT NOT NULL,
    MajorID INT,
    Birthday DATETIME NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Address NVARCHAR(100) NOT NULL,
    StatusID INT NOT NULL,
    Email VARCHAR(50) NOT NULL,
	Avatar NVARCHAR(255),
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID),
    FOREIGN KEY (MajorID) REFERENCES Major(MajorID),
    FOREIGN KEY (StatusID) REFERENCES Status(StatusID)
);
GO

-- 7. Tạo bảng Score
CREATE TABLE Score (
    ScoreID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID VARCHAR(10) NOT NULL,
    SubjectID VARCHAR(10) NOT NULL,
    ScoreCategoryID VARCHAR(2) NOT NULL,
    ScoreValue FLOAT NOT NULL,
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID),
    FOREIGN KEY (ScoreCategoryID) REFERENCES ScoreCategory(ScoreCategoryID)
);

-- Thêm các khoa vào bảng Faculty
INSERT INTO Faculty (FacultyName) 
VALUES 
    (N'Công nghệ thông tin'),
    (N'Ngôn ngữ Anh'),
    (N'Quản trị kinh doanh');
GO

-- Thêm chuyên ngành cho khoa Công nghệ thông tin
INSERT INTO Major (MajorName, FacultyID) 
VALUES 
    (N'Công nghệ phần mềm', 1),
    (N'Hệ thống thông tin', 1),
    (N'An toàn thông tin', 1);
GO

-- Thêm chuyên ngành cho khoa Ngôn ngữ Anh
INSERT INTO Major (MajorName, FacultyID) 
VALUES 
    (N'Tiếng Anh thương mại', 2),
    (N'Tiếng Anh truyền thông', 2);
GO

-- Thêm chuyên ngành cho khoa Quản trị kinh doanh
INSERT INTO Major (MajorName, FacultyID) 
VALUES 
    (N'Tài chính ngân hàng', 3),
    (N'Marketing', 3);
GO

-- Thêm các môn học vào bảng Subject
INSERT INTO Subject (SubjectID, SubjectName, CreditHours)
VALUES 
    ('POS106', N'Chủ nghĩa xã hội khoa học', 2),
    ('POS105', N'Kinh tế chính trị Mác - Lênin', 2),
    ('PSY167', N'Tâm lý học ứng dụng', 3),
    ('POS104', N'Triết học Mác - Lênin', 3),
    ('POS107', N'Lịch sử Đảng Cộng sản Việt Nam', 2);
GO

-- Thêm các cột điểm vào bảng ScoreCategory
INSERT INTO ScoreCategory (ScoreCategoryID, ScoreCategoryName, Weight)
VALUES 
    ('CC', N'Chuyên cần', 1),
    ('GK', N'Giữa kỳ', 2),
    ('CK', N'Cuối kỳ', 3);
GO

--Thêm các trạng thái của sinh viên
INSERT INTO Status (StatusName)
VALUES
    (N'Đang học'),
	(N'Đình chỉ'),
	(N'Thôi học'),
	(N'Đã tốt nghiệp');
GO

--Thêm các sinh viên
INSERT INTO Student (StudentID, StudentName, Class, GPA, FacultyID, MajorID, Birthday, Phone, Address, StatusID, Email)
VALUES 
    ('2287700011', N'Nguyễn Văn A', 'CNTT01', 0, 1, 1, '2002-05-15', '0123456789', N'41 Đường số 22, Linh Đông, Thủ Đức, Hồ Chí Minh', 1, 'nguyenvana@gmail.com'),
    ('2287700012', N'Trần Thị B', 'NNA01', 0, 2, 4, '2001-12-20', '0987654321', N'114 Nhất Chi Mai, Phường 13, Tân Bình, Hồ Chí Minh', 1, 'tranthib@gmail.com'),
    ('2287700013', N'Lê Văn C', 'QTKD01', 0, 3, 6, '2003-03-10', '0123344556', N'51 Đường N1, Thống Nhất, Biên Hòa, Đồng Nai', 1, 'levanc@gmail.com');
GO
