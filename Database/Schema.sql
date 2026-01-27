

CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(255) NOT NULL,
    FullName NVARCHAR(100) NOT NULL,
    Role NVARCHAR(20) NOT NULL, -- 'Admin', 'Operator', 'Transcriber', 'Editor', 'Approver'
    IsActive BIT DEFAULT 1
);

CREATE TABLE Meetings (
    MeetingId INT PRIMARY KEY IDENTITY(1,1),
    MeetingNo NVARCHAR(50) NOT NULL UNIQUE,
    MeetingDate DATETIME NOT NULL,
    Location NVARCHAR(100),
    Chairperson NVARCHAR(100)
);

CREATE TABLE Agendas (
    AgendaId INT PRIMARY KEY IDENTITY(1,1),
    MeetingId INT NOT NULL,
    Title NVARCHAR(200) NOT NULL,
    Office NVARCHAR(100),
    DocumentPath NVARCHAR(500),
    FOREIGN KEY (MeetingId) REFERENCES Meetings(MeetingId) ON DELETE CASCADE
);

CREATE TABLE Recordings (
    RecordingId INT PRIMARY KEY IDENTITY(1,1),
    AgendaId INT NOT NULL,
    FilePath NVARCHAR(500) NOT NULL,
    FOREIGN KEY (AgendaId) REFERENCES Agendas(AgendaId) ON DELETE CASCADE
);

CREATE TABLE Assignments (
    AssignmentId INT PRIMARY KEY IDENTITY(1,1),
    RecordingId INT NOT NULL,
    TranscriberId INT NOT NULL,
    AssignedDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(20) DEFAULT 'Assigned', -- 'Assigned', 'InProgress', 'Completed'
    FOREIGN KEY (RecordingId) REFERENCES Recordings(RecordingId) ON DELETE CASCADE,
    FOREIGN KEY (TranscriberId) REFERENCES Users(UserId)
);

CREATE TABLE Transcriptions (
    TranscriptionId INT PRIMARY KEY IDENTITY(1,1),
    AssignmentId INT NOT NULL,
    TranscriptionText NVARCHAR(MAX),
    Status NVARCHAR(20) DEFAULT 'Draft', -- 'Draft', 'Submitted', 'UnderReview', 'Approved', 'Returned', 'Final'
    Comments NVARCHAR(MAX),
    SubmittedDate DATETIME,
    LastUpdatedDate DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (AssignmentId) REFERENCES Assignments(AssignmentId) ON DELETE CASCADE
);


-- Here we insert sample Users directly for testing purposes.
-- Password is 'password' for all users for simplicity
INSERT INTO Users (Username, PasswordHash, FullName, Role) VALUES 
('admin', 'password', 'System Admin', 'Admin'),
('operator', 'password', 'Meeting Operator', 'Operator'),
('transcriber1', 'password', 'Alice Transcriber', 'Transcriber'),
('transcriber2', 'password', 'Bob Transcriber', 'Transcriber'),
('editor', 'password', 'Eve Editor', 'Editor'),
('approver', 'password', 'Chairperson Charlie', 'Approver');

-- Sample Meeting
INSERT INTO Meetings (MeetingNo, MeetingDate, Location, Chairperson) VALUES
('M-2023-001', '2023-10-01 09:00:00', 'Conference Room A', 'Chairperson Charlie');

-- Sample Agenda
INSERT INTO Agendas (MeetingId, Title, Office, DocumentPath) VALUES
(1, 'Budget Review', 'Finance Dept', 'C:\Docs\Budget.pdf'),
(1, 'Project Status', 'IT Dept', 'C:\Docs\Status.pdf');

-- Sample Recording 
INSERT INTO Recordings (AgendaId, FilePath) VALUES
(1, 'C:\Recordings\Budget_Review.mp3');

-- Sample Assignment
INSERT INTO Assignments (RecordingId, TranscriberId, Status) VALUES
(1, 3, 'Assigned');
