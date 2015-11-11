
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/11/2015 21:56:35
-- Generated from EDMX file: C:\Users\Scott\Source\Repos\Book-A-Majig2\Book-A-Majig v2\Book-A-Majig v2\Book-A-Majig v2\DatabaseEntities\DatabaseEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EmployeeAccessLevel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_EmployeeAccessLevel];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingBookingClasification]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_BookingBookingClasification];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingConfirmationBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookingConfirmations] DROP CONSTRAINT [FK_BookingConfirmationBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingNotesBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookingNotes] DROP CONSTRAINT [FK_BookingNotesBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_EmployeeBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_RestaurantBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_LockOutDateLockOutTime]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LockOutTimes] DROP CONSTRAINT [FK_LockOutDateLockOutTime];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantLockOutDate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LockOutDates] DROP CONSTRAINT [FK_RestaurantLockOutDate];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingNoteEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookingNotes] DROP CONSTRAINT [FK_BookingNoteEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingClasificationLockOutDate_BookingClasification]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookingClasificationLockOutDate] DROP CONSTRAINT [FK_BookingClasificationLockOutDate_BookingClasification];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingClasificationLockOutDate_LockOutDate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookingClasificationLockOutDate] DROP CONSTRAINT [FK_BookingClasificationLockOutDate_LockOutDate];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeAvailabilityDayEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeAvailabilityDays] DROP CONSTRAINT [FK_EmployeeAvailabilityDayEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeNAEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeNAs] DROP CONSTRAINT [FK_EmployeeNAEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_ShiftEmployeeShift]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeShifts] DROP CONSTRAINT [FK_ShiftEmployeeShift];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeShiftEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeShifts] DROP CONSTRAINT [FK_EmployeeShiftEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeRestaurant_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeRestaurant] DROP CONSTRAINT [FK_EmployeeRestaurant_Employee];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeRestaurant_Restaurant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeRestaurant] DROP CONSTRAINT [FK_EmployeeRestaurant_Restaurant];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeAvailabilityHoursRequestEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeAvailabilityHoursRequests] DROP CONSTRAINT [FK_EmployeeAvailabilityHoursRequestEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_PermissionsAccessLevel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Permissions] DROP CONSTRAINT [FK_PermissionsAccessLevel];
GO
IF OBJECT_ID(N'[dbo].[FK_RosterShift]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Shifts] DROP CONSTRAINT [FK_RosterShift];
GO
IF OBJECT_ID(N'[dbo].[FK_RosterRestaurant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Rosters] DROP CONSTRAINT [FK_RosterRestaurant];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeCommendationEmployee_EmployeeCommendation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeCommendationEmployee] DROP CONSTRAINT [FK_EmployeeCommendationEmployee_EmployeeCommendation];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeCommendationEmployee_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeCommendationEmployee] DROP CONSTRAINT [FK_EmployeeCommendationEmployee_Employee];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeCommendationShift]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeCommendations] DROP CONSTRAINT [FK_EmployeeCommendationShift];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeCommendationEmployeeCommendationClassification]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeCommendations] DROP CONSTRAINT [FK_EmployeeCommendationEmployeeCommendationClassification];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeShiftCategoryEmployeeShiftPresets]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeShiftPresets] DROP CONSTRAINT [FK_EmployeeShiftCategoryEmployeeShiftPresets];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeShiftCategoryEmployeeShift]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeShifts] DROP CONSTRAINT [FK_EmployeeShiftCategoryEmployeeShift];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeShiftPresetsShiftCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeShiftPresets] DROP CONSTRAINT [FK_EmployeeShiftPresetsShiftCategory];
GO
IF OBJECT_ID(N'[dbo].[FK_ShiftCategoryShift]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Shifts] DROP CONSTRAINT [FK_ShiftCategoryShift];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeCommendationEmployee1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeCommendations] DROP CONSTRAINT [FK_EmployeeCommendationEmployee1];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_BookingEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingConfirmationEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookingConfirmations] DROP CONSTRAINT [FK_BookingConfirmationEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingEmployee1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_BookingEmployee1];
GO
IF OBJECT_ID(N'[dbo].[FK_DateNoteRestaurant]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DateNotes] DROP CONSTRAINT [FK_DateNoteRestaurant];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeNAEmployee1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeNAs] DROP CONSTRAINT [FK_EmployeeNAEmployee1];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeNAEmployee2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeNAs] DROP CONSTRAINT [FK_EmployeeNAEmployee2];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AccessLevels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccessLevels];
GO
IF OBJECT_ID(N'[dbo].[BookingClasifications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookingClasifications];
GO
IF OBJECT_ID(N'[dbo].[BookingConfirmations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookingConfirmations];
GO
IF OBJECT_ID(N'[dbo].[BookingNotes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookingNotes];
GO
IF OBJECT_ID(N'[dbo].[Bookings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bookings];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[LockOutDates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LockOutDates];
GO
IF OBJECT_ID(N'[dbo].[LockOutTimes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LockOutTimes];
GO
IF OBJECT_ID(N'[dbo].[Restaurants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurants];
GO
IF OBJECT_ID(N'[dbo].[PresetNotes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PresetNotes];
GO
IF OBJECT_ID(N'[dbo].[EmployeeAvailabilityDays]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeAvailabilityDays];
GO
IF OBJECT_ID(N'[dbo].[EmployeeNAs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeNAs];
GO
IF OBJECT_ID(N'[dbo].[Shifts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Shifts];
GO
IF OBJECT_ID(N'[dbo].[EmployeeShifts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeShifts];
GO
IF OBJECT_ID(N'[dbo].[EmployeeAvailabilityHoursRequests]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeAvailabilityHoursRequests];
GO
IF OBJECT_ID(N'[dbo].[Permissions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Permissions];
GO
IF OBJECT_ID(N'[dbo].[Rosters]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Rosters];
GO
IF OBJECT_ID(N'[dbo].[EmployeeCommendations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeCommendations];
GO
IF OBJECT_ID(N'[dbo].[EmployeeCommendationClassifications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeCommendationClassifications];
GO
IF OBJECT_ID(N'[dbo].[EmployeeLevelCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeLevelCategories];
GO
IF OBJECT_ID(N'[dbo].[EmployeeShiftPresets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeShiftPresets];
GO
IF OBJECT_ID(N'[dbo].[ShiftCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ShiftCategories];
GO
IF OBJECT_ID(N'[dbo].[DateNotes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DateNotes];
GO
IF OBJECT_ID(N'[dbo].[BookingClasificationLockOutDate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookingClasificationLockOutDate];
GO
IF OBJECT_ID(N'[dbo].[EmployeeRestaurant]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeRestaurant];
GO
IF OBJECT_ID(N'[dbo].[EmployeeCommendationEmployee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeCommendationEmployee];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AccessLevels'
CREATE TABLE [dbo].[AccessLevels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Level] int  NOT NULL
);
GO

-- Creating table 'BookingClasifications'
CREATE TABLE [dbo].[BookingClasifications] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClassificationName] nvarchar(max)  NOT NULL,
    [DisplayOrder] int  NOT NULL
);
GO

-- Creating table 'BookingConfirmations'
CREATE TABLE [dbo].[BookingConfirmations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ConfirmationDate] datetime  NULL,
    [Booking_Id] int  NOT NULL,
    [EmployeeId] int  NOT NULL
);
GO

-- Creating table 'BookingNotes'
CREATE TABLE [dbo].[BookingNotes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [Booking_Id] int  NOT NULL,
    [EmployeeId] int  NOT NULL,
    [DateInactive] datetime  NULL,
    [DateAdded] datetime  NOT NULL,
    [Severity] int  NOT NULL
);
GO

-- Creating table 'Bookings'
CREATE TABLE [dbo].[Bookings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EmployeeId] int  NOT NULL,
    [ContactNumber] nvarchar(max)  NULL,
    [BookingClasificationId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [ArrivedDate] datetime  NULL,
    [DateInactive] datetime  NULL,
    [RestaurantId] int  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [BookingClasificationId1] int  NOT NULL,
    [RestaurantId1] int  NOT NULL,
    [EmployeeBooking_Booking_Id] int  NOT NULL,
    [BookingDate] datetime  NOT NULL,
    [Adults] int  NOT NULL,
    [Children] int  NOT NULL,
    [HighChair] int  NOT NULL,
    [DeletedByID] int  NULL,
    [BookingEmployee_Booking_Id] int  NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [DateInactive] datetime  NULL,
    [AccessLevel_Id] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [PhoneNumber] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LockOutDates'
CREATE TABLE [dbo].[LockOutDates] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Reason] nvarchar(max)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [RestaurantId] int  NOT NULL,
    [AuthorityRequiredToOverride] int  NULL,
    [DateCreated] datetime  NOT NULL
);
GO

-- Creating table 'LockOutTimes'
CREATE TABLE [dbo].[LockOutTimes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartTime] datetime  NOT NULL,
    [EndTime] datetime  NOT NULL,
    [LockOutDate_Id] int  NOT NULL
);
GO

-- Creating table 'Restaurants'
CREATE TABLE [dbo].[Restaurants] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Capacity] int  NOT NULL,
    [RosteringStartDay] int  NOT NULL,
    [RosteringWeekDuration] int  NOT NULL,
    [RosteringWeekOffset] int  NOT NULL
);
GO

-- Creating table 'PresetNotes'
CREATE TABLE [dbo].[PresetNotes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Severity] int  NOT NULL
);
GO

-- Creating table 'EmployeeAvailabilityDays'
CREATE TABLE [dbo].[EmployeeAvailabilityDays] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DayOfWeek] int  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NULL,
    [Notes] nvarchar(max)  NOT NULL,
    [StartTime] datetime  NOT NULL,
    [FinishTime] datetime  NULL,
    [DateAdded] datetime  NOT NULL,
    [Employee_Id] int  NOT NULL
);
GO

-- Creating table 'EmployeeNAs'
CREATE TABLE [dbo].[EmployeeNAs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [Notes] nvarchar(max)  NOT NULL,
    [SubmittedDate] datetime  NOT NULL,
    [Employee_Id] int  NOT NULL,
    [SubmittedBy_Id] int  NULL,
    [ApprovedBy_Id] int  NULL
);
GO

-- Creating table 'Shifts'
CREATE TABLE [dbo].[Shifts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Notes] nvarchar(max)  NOT NULL,
    [RosterId] int  NOT NULL,
    [ShiftCategoryId] int  NOT NULL,
    [DayOfTheWeek] int  NOT NULL
);
GO

-- Creating table 'EmployeeShifts'
CREATE TABLE [dbo].[EmployeeShifts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ShiftId] int  NOT NULL,
    [StartTime] datetime  NOT NULL,
    [EndTime] datetime  NULL,
    [EmployeeShiftCategoryId] int  NOT NULL,
    [Employee_Id] int  NULL
);
GO

-- Creating table 'EmployeeAvailabilityHoursRequests'
CREATE TABLE [dbo].[EmployeeAvailabilityHoursRequests] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NULL,
    [RequestedMinimumHours] int  NULL,
    [RequestedMaximumHours] int  NULL,
    [Employee_Id] int  NOT NULL
);
GO

-- Creating table 'Permissions'
CREATE TABLE [dbo].[Permissions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PermissionName] nvarchar(max)  NOT NULL,
    [PermissionValue] bit  NOT NULL,
    [AccessLevel_Id] int  NOT NULL
);
GO

-- Creating table 'Rosters'
CREATE TABLE [dbo].[Rosters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Notes] nvarchar(max)  NOT NULL,
    [WeekOfYear] int  NOT NULL,
    [Year] int  NOT NULL,
    [Restaurant_Id] int  NOT NULL
);
GO

-- Creating table 'EmployeeCommendations'
CREATE TABLE [dbo].[EmployeeCommendations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Notes] nvarchar(max)  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [Shift_Id] int  NULL,
    [EmployeeCommendationClassification_Id] int  NOT NULL,
    [CommendedBy_Id] int  NOT NULL
);
GO

-- Creating table 'EmployeeCommendationClassifications'
CREATE TABLE [dbo].[EmployeeCommendationClassifications] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Weighting] int  NOT NULL
);
GO

-- Creating table 'EmployeeLevelCategories'
CREATE TABLE [dbo].[EmployeeLevelCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [MinLevelStaffMember] int  NULL
);
GO

-- Creating table 'EmployeeShiftPresets'
CREATE TABLE [dbo].[EmployeeShiftPresets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DayOfWeek] int  NOT NULL,
    [StartTime] datetime  NOT NULL,
    [FinishTime] datetime  NULL,
    [EmployeeShiftCategory_Id] int  NOT NULL,
    [ShiftCategory_Id] int  NOT NULL
);
GO

-- Creating table 'ShiftCategories'
CREATE TABLE [dbo].[ShiftCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DateNotes'
CREATE TABLE [dbo].[DateNotes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartDate] datetime  NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [InactiveDate] datetime  NULL,
    [AppearOnAddingBooking] bit  NOT NULL,
    [AppearOnRoster] bit  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [Restaurant_Id] int  NOT NULL
);
GO

-- Creating table 'BookingClasificationLockOutDate'
CREATE TABLE [dbo].[BookingClasificationLockOutDate] (
    [BookingClasifications_Id] int  NOT NULL,
    [LockOutDates_Id] int  NOT NULL
);
GO

-- Creating table 'EmployeeRestaurant'
CREATE TABLE [dbo].[EmployeeRestaurant] (
    [Employees_Id] int  NOT NULL,
    [Restaurants_Id] int  NOT NULL
);
GO

-- Creating table 'EmployeeCommendationEmployee'
CREATE TABLE [dbo].[EmployeeCommendationEmployee] (
    [EmployeeCommendations_Id] int  NOT NULL,
    [RecievingEmployee_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AccessLevels'
ALTER TABLE [dbo].[AccessLevels]
ADD CONSTRAINT [PK_AccessLevels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BookingClasifications'
ALTER TABLE [dbo].[BookingClasifications]
ADD CONSTRAINT [PK_BookingClasifications]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BookingConfirmations'
ALTER TABLE [dbo].[BookingConfirmations]
ADD CONSTRAINT [PK_BookingConfirmations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BookingNotes'
ALTER TABLE [dbo].[BookingNotes]
ADD CONSTRAINT [PK_BookingNotes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [PK_Bookings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LockOutDates'
ALTER TABLE [dbo].[LockOutDates]
ADD CONSTRAINT [PK_LockOutDates]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LockOutTimes'
ALTER TABLE [dbo].[LockOutTimes]
ADD CONSTRAINT [PK_LockOutTimes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Restaurants'
ALTER TABLE [dbo].[Restaurants]
ADD CONSTRAINT [PK_Restaurants]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PresetNotes'
ALTER TABLE [dbo].[PresetNotes]
ADD CONSTRAINT [PK_PresetNotes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeAvailabilityDays'
ALTER TABLE [dbo].[EmployeeAvailabilityDays]
ADD CONSTRAINT [PK_EmployeeAvailabilityDays]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeNAs'
ALTER TABLE [dbo].[EmployeeNAs]
ADD CONSTRAINT [PK_EmployeeNAs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Shifts'
ALTER TABLE [dbo].[Shifts]
ADD CONSTRAINT [PK_Shifts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeShifts'
ALTER TABLE [dbo].[EmployeeShifts]
ADD CONSTRAINT [PK_EmployeeShifts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeAvailabilityHoursRequests'
ALTER TABLE [dbo].[EmployeeAvailabilityHoursRequests]
ADD CONSTRAINT [PK_EmployeeAvailabilityHoursRequests]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Permissions'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [PK_Permissions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Rosters'
ALTER TABLE [dbo].[Rosters]
ADD CONSTRAINT [PK_Rosters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeCommendations'
ALTER TABLE [dbo].[EmployeeCommendations]
ADD CONSTRAINT [PK_EmployeeCommendations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeCommendationClassifications'
ALTER TABLE [dbo].[EmployeeCommendationClassifications]
ADD CONSTRAINT [PK_EmployeeCommendationClassifications]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeLevelCategories'
ALTER TABLE [dbo].[EmployeeLevelCategories]
ADD CONSTRAINT [PK_EmployeeLevelCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'EmployeeShiftPresets'
ALTER TABLE [dbo].[EmployeeShiftPresets]
ADD CONSTRAINT [PK_EmployeeShiftPresets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ShiftCategories'
ALTER TABLE [dbo].[ShiftCategories]
ADD CONSTRAINT [PK_ShiftCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DateNotes'
ALTER TABLE [dbo].[DateNotes]
ADD CONSTRAINT [PK_DateNotes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [BookingClasifications_Id], [LockOutDates_Id] in table 'BookingClasificationLockOutDate'
ALTER TABLE [dbo].[BookingClasificationLockOutDate]
ADD CONSTRAINT [PK_BookingClasificationLockOutDate]
    PRIMARY KEY CLUSTERED ([BookingClasifications_Id], [LockOutDates_Id] ASC);
GO

-- Creating primary key on [Employees_Id], [Restaurants_Id] in table 'EmployeeRestaurant'
ALTER TABLE [dbo].[EmployeeRestaurant]
ADD CONSTRAINT [PK_EmployeeRestaurant]
    PRIMARY KEY CLUSTERED ([Employees_Id], [Restaurants_Id] ASC);
GO

-- Creating primary key on [EmployeeCommendations_Id], [RecievingEmployee_Id] in table 'EmployeeCommendationEmployee'
ALTER TABLE [dbo].[EmployeeCommendationEmployee]
ADD CONSTRAINT [PK_EmployeeCommendationEmployee]
    PRIMARY KEY CLUSTERED ([EmployeeCommendations_Id], [RecievingEmployee_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AccessLevel_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_EmployeeAccessLevel]
    FOREIGN KEY ([AccessLevel_Id])
    REFERENCES [dbo].[AccessLevels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeAccessLevel'
CREATE INDEX [IX_FK_EmployeeAccessLevel]
ON [dbo].[Employees]
    ([AccessLevel_Id]);
GO

-- Creating foreign key on [BookingClasificationId1] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_BookingBookingClasification]
    FOREIGN KEY ([BookingClasificationId1])
    REFERENCES [dbo].[BookingClasifications]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookingBookingClasification'
CREATE INDEX [IX_FK_BookingBookingClasification]
ON [dbo].[Bookings]
    ([BookingClasificationId1]);
GO

-- Creating foreign key on [Booking_Id] in table 'BookingConfirmations'
ALTER TABLE [dbo].[BookingConfirmations]
ADD CONSTRAINT [FK_BookingConfirmationBooking]
    FOREIGN KEY ([Booking_Id])
    REFERENCES [dbo].[Bookings]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookingConfirmationBooking'
CREATE INDEX [IX_FK_BookingConfirmationBooking]
ON [dbo].[BookingConfirmations]
    ([Booking_Id]);
GO

-- Creating foreign key on [Booking_Id] in table 'BookingNotes'
ALTER TABLE [dbo].[BookingNotes]
ADD CONSTRAINT [FK_BookingNotesBooking]
    FOREIGN KEY ([Booking_Id])
    REFERENCES [dbo].[Bookings]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookingNotesBooking'
CREATE INDEX [IX_FK_BookingNotesBooking]
ON [dbo].[BookingNotes]
    ([Booking_Id]);
GO

-- Creating foreign key on [EmployeeBooking_Booking_Id] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_EmployeeBooking]
    FOREIGN KEY ([EmployeeBooking_Booking_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeBooking'
CREATE INDEX [IX_FK_EmployeeBooking]
ON [dbo].[Bookings]
    ([EmployeeBooking_Booking_Id]);
GO

-- Creating foreign key on [RestaurantId1] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_RestaurantBooking]
    FOREIGN KEY ([RestaurantId1])
    REFERENCES [dbo].[Restaurants]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantBooking'
CREATE INDEX [IX_FK_RestaurantBooking]
ON [dbo].[Bookings]
    ([RestaurantId1]);
GO

-- Creating foreign key on [LockOutDate_Id] in table 'LockOutTimes'
ALTER TABLE [dbo].[LockOutTimes]
ADD CONSTRAINT [FK_LockOutDateLockOutTime]
    FOREIGN KEY ([LockOutDate_Id])
    REFERENCES [dbo].[LockOutDates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LockOutDateLockOutTime'
CREATE INDEX [IX_FK_LockOutDateLockOutTime]
ON [dbo].[LockOutTimes]
    ([LockOutDate_Id]);
GO

-- Creating foreign key on [RestaurantId] in table 'LockOutDates'
ALTER TABLE [dbo].[LockOutDates]
ADD CONSTRAINT [FK_RestaurantLockOutDate]
    FOREIGN KEY ([RestaurantId])
    REFERENCES [dbo].[Restaurants]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestaurantLockOutDate'
CREATE INDEX [IX_FK_RestaurantLockOutDate]
ON [dbo].[LockOutDates]
    ([RestaurantId]);
GO

-- Creating foreign key on [EmployeeId] in table 'BookingNotes'
ALTER TABLE [dbo].[BookingNotes]
ADD CONSTRAINT [FK_BookingNoteEmployee]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookingNoteEmployee'
CREATE INDEX [IX_FK_BookingNoteEmployee]
ON [dbo].[BookingNotes]
    ([EmployeeId]);
GO

-- Creating foreign key on [BookingClasifications_Id] in table 'BookingClasificationLockOutDate'
ALTER TABLE [dbo].[BookingClasificationLockOutDate]
ADD CONSTRAINT [FK_BookingClasificationLockOutDate_BookingClasification]
    FOREIGN KEY ([BookingClasifications_Id])
    REFERENCES [dbo].[BookingClasifications]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [LockOutDates_Id] in table 'BookingClasificationLockOutDate'
ALTER TABLE [dbo].[BookingClasificationLockOutDate]
ADD CONSTRAINT [FK_BookingClasificationLockOutDate_LockOutDate]
    FOREIGN KEY ([LockOutDates_Id])
    REFERENCES [dbo].[LockOutDates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookingClasificationLockOutDate_LockOutDate'
CREATE INDEX [IX_FK_BookingClasificationLockOutDate_LockOutDate]
ON [dbo].[BookingClasificationLockOutDate]
    ([LockOutDates_Id]);
GO

-- Creating foreign key on [Employee_Id] in table 'EmployeeAvailabilityDays'
ALTER TABLE [dbo].[EmployeeAvailabilityDays]
ADD CONSTRAINT [FK_EmployeeAvailabilityDayEmployee]
    FOREIGN KEY ([Employee_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeAvailabilityDayEmployee'
CREATE INDEX [IX_FK_EmployeeAvailabilityDayEmployee]
ON [dbo].[EmployeeAvailabilityDays]
    ([Employee_Id]);
GO

-- Creating foreign key on [Employee_Id] in table 'EmployeeNAs'
ALTER TABLE [dbo].[EmployeeNAs]
ADD CONSTRAINT [FK_EmployeeNAEmployee]
    FOREIGN KEY ([Employee_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeNAEmployee'
CREATE INDEX [IX_FK_EmployeeNAEmployee]
ON [dbo].[EmployeeNAs]
    ([Employee_Id]);
GO

-- Creating foreign key on [ShiftId] in table 'EmployeeShifts'
ALTER TABLE [dbo].[EmployeeShifts]
ADD CONSTRAINT [FK_ShiftEmployeeShift]
    FOREIGN KEY ([ShiftId])
    REFERENCES [dbo].[Shifts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ShiftEmployeeShift'
CREATE INDEX [IX_FK_ShiftEmployeeShift]
ON [dbo].[EmployeeShifts]
    ([ShiftId]);
GO

-- Creating foreign key on [Employee_Id] in table 'EmployeeShifts'
ALTER TABLE [dbo].[EmployeeShifts]
ADD CONSTRAINT [FK_EmployeeShiftEmployee]
    FOREIGN KEY ([Employee_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeShiftEmployee'
CREATE INDEX [IX_FK_EmployeeShiftEmployee]
ON [dbo].[EmployeeShifts]
    ([Employee_Id]);
GO

-- Creating foreign key on [Employees_Id] in table 'EmployeeRestaurant'
ALTER TABLE [dbo].[EmployeeRestaurant]
ADD CONSTRAINT [FK_EmployeeRestaurant_Employee]
    FOREIGN KEY ([Employees_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Restaurants_Id] in table 'EmployeeRestaurant'
ALTER TABLE [dbo].[EmployeeRestaurant]
ADD CONSTRAINT [FK_EmployeeRestaurant_Restaurant]
    FOREIGN KEY ([Restaurants_Id])
    REFERENCES [dbo].[Restaurants]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeRestaurant_Restaurant'
CREATE INDEX [IX_FK_EmployeeRestaurant_Restaurant]
ON [dbo].[EmployeeRestaurant]
    ([Restaurants_Id]);
GO

-- Creating foreign key on [Employee_Id] in table 'EmployeeAvailabilityHoursRequests'
ALTER TABLE [dbo].[EmployeeAvailabilityHoursRequests]
ADD CONSTRAINT [FK_EmployeeAvailabilityHoursRequestEmployee]
    FOREIGN KEY ([Employee_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeAvailabilityHoursRequestEmployee'
CREATE INDEX [IX_FK_EmployeeAvailabilityHoursRequestEmployee]
ON [dbo].[EmployeeAvailabilityHoursRequests]
    ([Employee_Id]);
GO

-- Creating foreign key on [AccessLevel_Id] in table 'Permissions'
ALTER TABLE [dbo].[Permissions]
ADD CONSTRAINT [FK_PermissionsAccessLevel]
    FOREIGN KEY ([AccessLevel_Id])
    REFERENCES [dbo].[AccessLevels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PermissionsAccessLevel'
CREATE INDEX [IX_FK_PermissionsAccessLevel]
ON [dbo].[Permissions]
    ([AccessLevel_Id]);
GO

-- Creating foreign key on [RosterId] in table 'Shifts'
ALTER TABLE [dbo].[Shifts]
ADD CONSTRAINT [FK_RosterShift]
    FOREIGN KEY ([RosterId])
    REFERENCES [dbo].[Rosters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RosterShift'
CREATE INDEX [IX_FK_RosterShift]
ON [dbo].[Shifts]
    ([RosterId]);
GO

-- Creating foreign key on [Restaurant_Id] in table 'Rosters'
ALTER TABLE [dbo].[Rosters]
ADD CONSTRAINT [FK_RosterRestaurant]
    FOREIGN KEY ([Restaurant_Id])
    REFERENCES [dbo].[Restaurants]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RosterRestaurant'
CREATE INDEX [IX_FK_RosterRestaurant]
ON [dbo].[Rosters]
    ([Restaurant_Id]);
GO

-- Creating foreign key on [EmployeeCommendations_Id] in table 'EmployeeCommendationEmployee'
ALTER TABLE [dbo].[EmployeeCommendationEmployee]
ADD CONSTRAINT [FK_EmployeeCommendationEmployee_EmployeeCommendation]
    FOREIGN KEY ([EmployeeCommendations_Id])
    REFERENCES [dbo].[EmployeeCommendations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RecievingEmployee_Id] in table 'EmployeeCommendationEmployee'
ALTER TABLE [dbo].[EmployeeCommendationEmployee]
ADD CONSTRAINT [FK_EmployeeCommendationEmployee_Employee]
    FOREIGN KEY ([RecievingEmployee_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeCommendationEmployee_Employee'
CREATE INDEX [IX_FK_EmployeeCommendationEmployee_Employee]
ON [dbo].[EmployeeCommendationEmployee]
    ([RecievingEmployee_Id]);
GO

-- Creating foreign key on [Shift_Id] in table 'EmployeeCommendations'
ALTER TABLE [dbo].[EmployeeCommendations]
ADD CONSTRAINT [FK_EmployeeCommendationShift]
    FOREIGN KEY ([Shift_Id])
    REFERENCES [dbo].[Shifts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeCommendationShift'
CREATE INDEX [IX_FK_EmployeeCommendationShift]
ON [dbo].[EmployeeCommendations]
    ([Shift_Id]);
GO

-- Creating foreign key on [EmployeeCommendationClassification_Id] in table 'EmployeeCommendations'
ALTER TABLE [dbo].[EmployeeCommendations]
ADD CONSTRAINT [FK_EmployeeCommendationEmployeeCommendationClassification]
    FOREIGN KEY ([EmployeeCommendationClassification_Id])
    REFERENCES [dbo].[EmployeeCommendationClassifications]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeCommendationEmployeeCommendationClassification'
CREATE INDEX [IX_FK_EmployeeCommendationEmployeeCommendationClassification]
ON [dbo].[EmployeeCommendations]
    ([EmployeeCommendationClassification_Id]);
GO

-- Creating foreign key on [EmployeeShiftCategory_Id] in table 'EmployeeShiftPresets'
ALTER TABLE [dbo].[EmployeeShiftPresets]
ADD CONSTRAINT [FK_EmployeeShiftCategoryEmployeeShiftPresets]
    FOREIGN KEY ([EmployeeShiftCategory_Id])
    REFERENCES [dbo].[EmployeeLevelCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeShiftCategoryEmployeeShiftPresets'
CREATE INDEX [IX_FK_EmployeeShiftCategoryEmployeeShiftPresets]
ON [dbo].[EmployeeShiftPresets]
    ([EmployeeShiftCategory_Id]);
GO

-- Creating foreign key on [EmployeeShiftCategoryId] in table 'EmployeeShifts'
ALTER TABLE [dbo].[EmployeeShifts]
ADD CONSTRAINT [FK_EmployeeShiftCategoryEmployeeShift]
    FOREIGN KEY ([EmployeeShiftCategoryId])
    REFERENCES [dbo].[EmployeeLevelCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeShiftCategoryEmployeeShift'
CREATE INDEX [IX_FK_EmployeeShiftCategoryEmployeeShift]
ON [dbo].[EmployeeShifts]
    ([EmployeeShiftCategoryId]);
GO

-- Creating foreign key on [ShiftCategory_Id] in table 'EmployeeShiftPresets'
ALTER TABLE [dbo].[EmployeeShiftPresets]
ADD CONSTRAINT [FK_EmployeeShiftPresetsShiftCategory]
    FOREIGN KEY ([ShiftCategory_Id])
    REFERENCES [dbo].[ShiftCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeShiftPresetsShiftCategory'
CREATE INDEX [IX_FK_EmployeeShiftPresetsShiftCategory]
ON [dbo].[EmployeeShiftPresets]
    ([ShiftCategory_Id]);
GO

-- Creating foreign key on [ShiftCategoryId] in table 'Shifts'
ALTER TABLE [dbo].[Shifts]
ADD CONSTRAINT [FK_ShiftCategoryShift]
    FOREIGN KEY ([ShiftCategoryId])
    REFERENCES [dbo].[ShiftCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ShiftCategoryShift'
CREATE INDEX [IX_FK_ShiftCategoryShift]
ON [dbo].[Shifts]
    ([ShiftCategoryId]);
GO

-- Creating foreign key on [CommendedBy_Id] in table 'EmployeeCommendations'
ALTER TABLE [dbo].[EmployeeCommendations]
ADD CONSTRAINT [FK_EmployeeCommendationEmployee1]
    FOREIGN KEY ([CommendedBy_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeCommendationEmployee1'
CREATE INDEX [IX_FK_EmployeeCommendationEmployee1]
ON [dbo].[EmployeeCommendations]
    ([CommendedBy_Id]);
GO

-- Creating foreign key on [BookingEmployee_Booking_Id] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_BookingEmployee]
    FOREIGN KEY ([BookingEmployee_Booking_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookingEmployee'
CREATE INDEX [IX_FK_BookingEmployee]
ON [dbo].[Bookings]
    ([BookingEmployee_Booking_Id]);
GO

-- Creating foreign key on [EmployeeId] in table 'BookingConfirmations'
ALTER TABLE [dbo].[BookingConfirmations]
ADD CONSTRAINT [FK_BookingConfirmationEmployee]
    FOREIGN KEY ([EmployeeId])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookingConfirmationEmployee'
CREATE INDEX [IX_FK_BookingConfirmationEmployee]
ON [dbo].[BookingConfirmations]
    ([EmployeeId]);
GO

-- Creating foreign key on [DeletedByID] in table 'Bookings'
ALTER TABLE [dbo].[Bookings]
ADD CONSTRAINT [FK_BookingEmployee1]
    FOREIGN KEY ([DeletedByID])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookingEmployee1'
CREATE INDEX [IX_FK_BookingEmployee1]
ON [dbo].[Bookings]
    ([DeletedByID]);
GO

-- Creating foreign key on [Restaurant_Id] in table 'DateNotes'
ALTER TABLE [dbo].[DateNotes]
ADD CONSTRAINT [FK_DateNoteRestaurant]
    FOREIGN KEY ([Restaurant_Id])
    REFERENCES [dbo].[Restaurants]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DateNoteRestaurant'
CREATE INDEX [IX_FK_DateNoteRestaurant]
ON [dbo].[DateNotes]
    ([Restaurant_Id]);
GO

-- Creating foreign key on [SubmittedBy_Id] in table 'EmployeeNAs'
ALTER TABLE [dbo].[EmployeeNAs]
ADD CONSTRAINT [FK_EmployeeNAEmployee1]
    FOREIGN KEY ([SubmittedBy_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeNAEmployee1'
CREATE INDEX [IX_FK_EmployeeNAEmployee1]
ON [dbo].[EmployeeNAs]
    ([SubmittedBy_Id]);
GO

-- Creating foreign key on [ApprovedBy_Id] in table 'EmployeeNAs'
ALTER TABLE [dbo].[EmployeeNAs]
ADD CONSTRAINT [FK_EmployeeNAEmployee2]
    FOREIGN KEY ([ApprovedBy_Id])
    REFERENCES [dbo].[Employees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeNAEmployee2'
CREATE INDEX [IX_FK_EmployeeNAEmployee2]
ON [dbo].[EmployeeNAs]
    ([ApprovedBy_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------