
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/07/2021 15:31:14
-- Generated from EDMX file: D:\Visual Studio Project\Goodline\TableBusWinForms\TableBusWinForms\Models\DataContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TableBus];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Route_City]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Routes] DROP CONSTRAINT [FK_Route_City];
GO
IF OBJECT_ID(N'[dbo].[FK_Route_City1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Routes] DROP CONSTRAINT [FK_Route_City1];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_Route]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tables] DROP CONSTRAINT [FK_Table_Route];
GO
IF OBJECT_ID(N'[dbo].[FK_Table_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tables] DROP CONSTRAINT [FK_Table_User];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities];
GO
IF OBJECT_ID(N'[dbo].[Routes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Routes];
GO
IF OBJECT_ID(N'[dbo].[Tables]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tables];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CityName] nvarchar(200)  NOT NULL,
    [IsDelete] bit  NOT NULL
);
GO

-- Creating table 'Routes'
CREATE TABLE [dbo].[Routes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NameRoute] nvarchar(250)  NOT NULL,
    [CityStart] int  NOT NULL,
    [CityEnd] int  NOT NULL,
    [Distance] float  NOT NULL,
    [TravelTime] time  NOT NULL,
    [IsDelete] bit  NOT NULL
);
GO

-- Creating table 'Tables'
CREATE TABLE [dbo].[Tables] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RouteId] int  NOT NULL,
    [DateTimeStart] datetime  NOT NULL,
    [DateTimeEnd] datetime  NOT NULL,
    [CurrentCountPassenger] int  NOT NULL,
    [MaxCountPassenger] int  NOT NULL,
    [Price] int  NOT NULL,
    [IsDelete] bit  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Login] nvarchar(200)  NOT NULL,
    [Money] int  NOT NULL,
    [IsAdmin] bit  NOT NULL
);
GO

-- Creating table 'RecordFlights'
CREATE TABLE [dbo].[RecordFlights] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TableId] int  NOT NULL,
    [UserId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Routes'
ALTER TABLE [dbo].[Routes]
ADD CONSTRAINT [PK_Routes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Tables'
ALTER TABLE [dbo].[Tables]
ADD CONSTRAINT [PK_Tables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RecordFlights'
ALTER TABLE [dbo].[RecordFlights]
ADD CONSTRAINT [PK_RecordFlights]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CityStart] in table 'Routes'
ALTER TABLE [dbo].[Routes]
ADD CONSTRAINT [FK_Route_City]
    FOREIGN KEY ([CityStart])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Route_City'
CREATE INDEX [IX_FK_Route_City]
ON [dbo].[Routes]
    ([CityStart]);
GO

-- Creating foreign key on [CityEnd] in table 'Routes'
ALTER TABLE [dbo].[Routes]
ADD CONSTRAINT [FK_Route_City1]
    FOREIGN KEY ([CityEnd])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Route_City1'
CREATE INDEX [IX_FK_Route_City1]
ON [dbo].[Routes]
    ([CityEnd]);
GO

-- Creating foreign key on [RouteId] in table 'Tables'
ALTER TABLE [dbo].[Tables]
ADD CONSTRAINT [FK_Table_Route]
    FOREIGN KEY ([RouteId])
    REFERENCES [dbo].[Routes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Table_Route'
CREATE INDEX [IX_FK_Table_Route]
ON [dbo].[Tables]
    ([RouteId]);
GO

-- Creating foreign key on [TableId] in table 'RecordFlights'
ALTER TABLE [dbo].[RecordFlights]
ADD CONSTRAINT [FK_TableRecordFlight]
    FOREIGN KEY ([TableId])
    REFERENCES [dbo].[Tables]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TableRecordFlight'
CREATE INDEX [IX_FK_TableRecordFlight]
ON [dbo].[RecordFlights]
    ([TableId]);
GO

-- Creating foreign key on [UserId] in table 'RecordFlights'
ALTER TABLE [dbo].[RecordFlights]
ADD CONSTRAINT [FK_UserRecordFlight]
    FOREIGN KEY ([UserId])
    REFERENCES [dbo].[Users]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserRecordFlight'
CREATE INDEX [IX_FK_UserRecordFlight]
ON [dbo].[RecordFlights]
    ([UserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------