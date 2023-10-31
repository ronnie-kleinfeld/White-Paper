
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/11/2019 18:36:32
-- Generated from EDMX file: \\mac\Home\Dev\CSharp FullStack\EntityFramework\EntityFramework\DatabaseFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SRYCRMDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[LogTypesEnum]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LogTypesEnum];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'LogTypesEnums'
CREATE TABLE [dbo].[LogTypesEnums] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [CreateDateTime] datetime  NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [Description] nvarchar(255)  NULL,
    [Synonyms] nvarchar(2000)  NULL,
    [OrderBy] int  NOT NULL,
    [IsDefault] bit  NOT NULL,
    [Disabled] bit  NOT NULL
);
GO

-- Creating table 'SampleTables'
CREATE TABLE [dbo].[SampleTables] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ColumnName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'LogTypesEnums'
ALTER TABLE [dbo].[LogTypesEnums]
ADD CONSTRAINT [PK_LogTypesEnums]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Id] in table 'SampleTables'
ALTER TABLE [dbo].[SampleTables]
ADD CONSTRAINT [PK_SampleTables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------