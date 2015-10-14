
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/12/2015 10:48:18
-- Generated from EDMX file: C:\Users\Scott\Desktop\Book-A-Majig v2\Book-A-Majig v2\Book-A-Majig v2\BookingModel.edmx
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

IF OBJECT_ID(N'[dbo].[FK_BookingNotesBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookingNotes] DROP CONSTRAINT [FK_BookingNotesBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingConfirmationBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookingConfirmations] DROP CONSTRAINT [FK_BookingConfirmationBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeAccessLevel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_EmployeeAccessLevel];
GO
IF OBJECT_ID(N'[dbo].[FK_LockOutDateLockOutTime]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LockOutTimes] DROP CONSTRAINT [FK_LockOutDateLockOutTime];
GO
IF OBJECT_ID(N'[dbo].[FK_LockOutDateBookingClasification]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookingClasifications] DROP CONSTRAINT [FK_LockOutDateBookingClasification];
GO
IF OBJECT_ID(N'[dbo].[FK_LockOutDateAccessLevel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LockOutDates] DROP CONSTRAINT [FK_LockOutDateAccessLevel];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_EmployeeBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_BookingBookingClasification]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_BookingBookingClasification];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_RestaurantBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_RestaurantLockOutDate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[LockOutDates] DROP CONSTRAINT [FK_RestaurantLockOutDate];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bookings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bookings];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[AccessLevels]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AccessLevels];
GO
IF OBJECT_ID(N'[dbo].[BookingNotes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookingNotes];
GO
IF OBJECT_ID(N'[dbo].[BookingClasifications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookingClasifications];
GO
IF OBJECT_ID(N'[dbo].[BookingConfirmations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookingConfirmations];
GO
IF OBJECT_ID(N'[dbo].[Restaurants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurants];
GO
IF OBJECT_ID(N'[dbo].[LockOutDates]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LockOutDates];
GO
IF OBJECT_ID(N'[dbo].[LockOutTimes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LockOutTimes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

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
    [EmployeeBooking_Booking_Id] int  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [DateInactive] datetime  NULL,
    [AccessLevel_Id] int  NOT NULL
);
GO

-- Creating table 'AccessLevels'
CREATE TABLE [dbo].[AccessLevels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Level] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BookingNotes'
CREATE TABLE [dbo].[BookingNotes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Note] nvarchar(max)  NOT NULL,
    [EmployeeId] int  NOT NULL,
    [Booking_Id] int  NOT NULL
);
GO

-- Creating table 'BookingClasifications'
CREATE TABLE [dbo].[BookingClasifications] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClassificationName] nvarchar(max)  NOT NULL,
    [DisplayOrder] int  NOT NULL,
    [LockOutDateId] int  NULL
);
GO

-- Creating table 'BookingConfirmations'
CREATE TABLE [dbo].[BookingConfirmations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ConfirmationDate] datetime  NULL,
    [Booking_Id] int  NOT NULL
);
GO

-- Creating table 'Restaurants'
CREATE TABLE [dbo].[Restaurants] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [Capacity] int  NOT NULL
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
    [AccessLevel_Id] int  NULL
);
GO

-- Creating table 'LockOutTimes'
CREATE TABLE [dbo].[LockOutTimes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StartTime] nvarchar(max)  NOT NULL,
    [EndTime] datetime  NOT NULL,
    [LockOutDate_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

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

-- Creating primary key on [Id] in table 'AccessLevels'
ALTER TABLE [dbo].[AccessLevels]
ADD CONSTRAINT [PK_AccessLevels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BookingNotes'
ALTER TABLE [dbo].[BookingNotes]
ADD CONSTRAINT [PK_BookingNotes]
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

-- Creating primary key on [Id] in table 'Restaurants'
ALTER TABLE [dbo].[Restaurants]
ADD CONSTRAINT [PK_Restaurants]
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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

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

-- Creating foreign key on [LockOutDateId] in table 'BookingClasifications'
ALTER TABLE [dbo].[BookingClasifications]
ADD CONSTRAINT [FK_LockOutDateBookingClasification]
    FOREIGN KEY ([LockOutDateId])
    REFERENCES [dbo].[LockOutDates]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LockOutDateBookingClasification'
CREATE INDEX [IX_FK_LockOutDateBookingClasification]
ON [dbo].[BookingClasifications]
    ([LockOutDateId]);
GO

-- Creating foreign key on [AccessLevel_Id] in table 'LockOutDates'
ALTER TABLE [dbo].[LockOutDates]
ADD CONSTRAINT [FK_LockOutDateAccessLevel]
    FOREIGN KEY ([AccessLevel_Id])
    REFERENCES [dbo].[AccessLevels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LockOutDateAccessLevel'
CREATE INDEX [IX_FK_LockOutDateAccessLevel]
ON [dbo].[LockOutDates]
    ([AccessLevel_Id]);
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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------