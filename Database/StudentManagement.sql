-- Tạo cơ sở dữ liệu
CREATE DATABASE StudentManagement;
GO

USE StudentManagement;
GO

-- Tạo bảng Faculty
CREATE TABLE Faculty (
    FacultyID INT IDENTITY(1,1) PRIMARY KEY,
    FacultyName NVARCHAR(50) NOT NULL
);
GO

-- Tạo bảng Status
CREATE TABLE Status (
    StatusID INT IDENTITY(1,1) PRIMARY KEY,
    StatusName NVARCHAR(20) NOT NULL
);
GO

-- Tạo bảng Major (phụ thuộc vào Faculty)
CREATE TABLE Major (
    MajorID INT IDENTITY(1,1) PRIMARY KEY,
    MajorName NVARCHAR(50) NOT NULL,
    FacultyID INT NOT NULL,
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID)
);
GO

-- Tạo bảng Subject
CREATE TABLE Subject (
    SubjectID VARCHAR(10) PRIMARY KEY,
    SubjectName NVARCHAR(50) NOT NULL,
    CreditHours INT NOT NULL
);
GO

-- Tạo bảng ScoreCategory
CREATE TABLE ScoreCategory (
    ScoreCategoryID VARCHAR(2) PRIMARY KEY,
    ScoreCategoryName NVARCHAR(20) NOT NULL,
    Weight INT NOT NULL
);
GO

-- Tạo bảng Student (phụ thuộc vào Faculty, Major, Status)
CREATE TABLE Student (
    StudentID VARCHAR(10) PRIMARY KEY,
    StudentName NVARCHAR(50) NOT NULL,
    Gender BIT NOT NULL,
    Class VARCHAR(10) NOT NULL,
    GPA FLOAT NOT NULL,
    FacultyID INT NOT NULL,
    MajorID INT,
    Birthday DATETIME NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Address NVARCHAR(100) NOT NULL,
    StatusID INT NOT NULL DEFAULT 1,
    Email VARCHAR(50) NOT NULL,
    Avatar VARBINARY(MAX),
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID),
    FOREIGN KEY (MajorID) REFERENCES Major(MajorID),
    FOREIGN KEY (StatusID) REFERENCES Status(StatusID)
);
GO

-- Tạo bảng Teacher (phụ thuộc vào Faculty)
CREATE TABLE Teacher (
    TeacherID INT IDENTITY(1,1) PRIMARY KEY,
    TeacherName NVARCHAR(50) NOT NULL,
    Gender BIT NOT NULL,
    FacultyID INT NOT NULL,
    Phone VARCHAR(15) NOT NULL,
    Email VARCHAR(50) NOT NULL,
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID)
);
GO

-- Tạo bảng teacher_subject
CREATE TABLE teacher_subject (
    TeacherID INT NOT NULL,
    SubjectID VARCHAR(10) NOT NULL,
    PRIMARY KEY (TeacherID, SubjectID),
    FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID),
    FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID)
);

-- Tạo bảng Semester
CREATE TABLE Semester (
    SemesterID INT IDENTITY(1,1) PRIMARY KEY,
    SemesterName NVARCHAR(50) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NOT NULL
);
GO

-- Tạo bảng Course (phụ thuộc vào Subject, Teacher, Semester)
CREATE TABLE Course (
    CourseID VARCHAR(5) PRIMARY KEY,
    SubjectID VARCHAR(10) NOT NULL,
    TeacherID INT NOT NULL,
    SemesterID INT NOT NULL,
    Schedule NVARCHAR(100) NOT NULL,
    MaxStudents INT NOT NULL,
    CurrentStudents INT DEFAULT 0,
    FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID),
    FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID),
    FOREIGN KEY (SemesterID) REFERENCES Semester(SemesterID)
);
GO

-- Tạo bảng Registration (phụ thuộc vào Student, Course)
CREATE TABLE Registration (
    StudentID VARCHAR(10) NOT NULL,
    CourseID VARCHAR(5) NOT NULL,
    RegistrationDate DATETIME NOT NULL DEFAULT GETDATE(),
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
);
GO

-- Tạo bảng Score (phụ thuộc vào Student, Subject, ScoreCategory)
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
GO


-- Thêm dữ liệu vào bảng Faculty
INSERT INTO Faculty (FacultyName) 
VALUES 
    (N'Công nghệ thông tin'),
    (N'Ngôn ngữ Anh'),
    (N'Quản trị kinh doanh');
GO

-- Thêm dữ liệu vào bảng Status
INSERT INTO Status (StatusName)
VALUES
    (N'Đang học'),
    (N'Đình chỉ'),
    (N'Thôi học'),
    (N'Đã tốt nghiệp');
GO

-- Thêm dữ liệu vào bảng Major
INSERT INTO Major (MajorName, FacultyID) 
VALUES 
    (N'Công nghệ phần mềm', 1),
    (N'Hệ thống thông tin', 1),
    (N'An toàn thông tin', 1),
    (N'Tiếng Anh thương mại', 2),
    (N'Tiếng Anh truyền thông', 2),
    (N'Tài chính ngân hàng', 3),
    (N'Marketing', 3);
GO

-- Thêm dữ liệu vào bảng Subject
INSERT INTO Subject (SubjectID, SubjectName, CreditHours)
VALUES 
    ('POS106', N'Chủ nghĩa xã hội khoa học', 2),
    ('POS105', N'Kinh tế chính trị Mác - Lênin', 2),
    ('PSY167', N'Tâm lý học ứng dụng', 3),
    ('POS104', N'Triết học Mác - Lênin', 3),
    ('POS107', N'Lịch sử Đảng Cộng sản Việt Nam', 2);
GO

-- Thêm dữ liệu vào bảng ScoreCategory
INSERT INTO ScoreCategory (ScoreCategoryID, ScoreCategoryName, Weight)
VALUES 
    ('CC', N'Chuyên cần', 1),
    ('GK', N'Giữa kỳ', 2),
    ('CK', N'Cuối kỳ', 3);
GO

-- Thêm dữ liệu vào bảng Student
INSERT INTO Student (StudentID, StudentName, Gender, Class, GPA, FacultyID, MajorID, Birthday, Phone, Address, Email)
VALUES 
    ('2287700011', N'Nguyễn Văn A', 1, 'CNTT01', 0, 1, 1, '2002-05-15', '0123456789', N'41 Đường số 22, Linh Đông, Thủ Đức, Hồ Chí Minh', 'nguyenvana@gmail.com'),
    ('2287700012', N'Trần Thị B', 0,  'NNA01', 0, 2, 4, '2001-12-20', '0987654321', N'114 Nhất Chi Mai, Phường 13, Tân Bình, Hồ Chí Minh', 'tranthib@gmail.com'),
    ('2287700013', N'Lê Văn C', 1, 'QTKD01', 0, 3, 6, '2003-03-10', '0123344556', N'51 Đường N1, Thống Nhất, Biên Hòa, Đồng Nai', 'levanc@gmail.com');
GO

-- Thêm dữ liệu vào bảng Teacher
INSERT INTO Teacher (TeacherName, Gender, FacultyID, Phone, Email)
VALUES
    (N'Nguyễn Văn Hùng', 1, 1, '0123456789', 'hungnv@university.edu.vn'),
    (N'Trần Thị Hương', 0, 2, '0987654321', 'huongtt@university.edu.vn'),
    (N'Lê Minh Phát', 1, 3, '0123344556', 'phatlm@university.edu.vn');
GO

-- Thêm dữ liệu vào bảng teacher_subject
INSERT INTO teacher_subject (TeacherID, SubjectID) 
VALUES 
    (1, 'POS106'),
    (1, 'POS104'),
    (2, 'POS105'),
    (2, 'POS107'),
    (3, 'PSY167'),
    (3, 'POS106');
GO

-- Thêm dữ liệu vào bảng Semester
INSERT INTO Semester (SemesterName, StartDate, EndDate)
VALUES
    (N'Học kỳ 1 - Năm 2024', '2024-01-01', '2024-05-31'),
    (N'Học kỳ 2 - Năm 2024', '2024-06-01', '2024-11-30'),
    (N'Học kỳ hè - Năm 2024', '2024-07-01', '2024-08-31'),
    (N'Học kỳ 1 - Năm 2025', '2025-01-01', '2025-05-31'),
    (N'Học kỳ 2 - Năm 2025', '2025-06-01', '2025-11-30'),
    (N'Học kỳ hè - Năm 2025', '2025-07-01', '2025-08-31');
GO

-- Thêm dữ liệu vào bảng Course
INSERT INTO Course (CourseID, SubjectID, TeacherID, SemesterID, Schedule, MaxStudents)
VALUES
    ('POS01', 'POS106', 1, 1, N'Thứ 2, Thứ 4, Tiết 1-3', 30),
    ('POS02', 'POS105', 2, 1, N'Thứ 3, Thứ 5, Tiết 2-4', 25),
    ('PSY01', 'PSY167', 3, 2, N'Thứ 2, Thứ 4, Tiết 4-6', 40),
    ('POS03', 'POS104', 1, 3, N'Thứ 3, Thứ 5, Tiết 1-2', 35),
    ('POS04', 'POS107', 2, 4, N'Thứ 4, Thứ 6, Tiết 3-5', 20),
    ('POS05', 'POS106', 3, 5, N'Thứ 2, Thứ 4, Tiết 5-6', 50);
GO
