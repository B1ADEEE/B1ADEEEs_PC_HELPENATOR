
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/11/2021 14:40:13
-- Generated from EDMX file: C:\Users\joshs\Desktop\OOD_2021\PcPartHelpenator\PcPartHelpenator\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PcHelpenator];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CPUs'
CREATE TABLE [dbo].[CPUs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CPUName] nvarchar(max)  NOT NULL,
    [CPUSocketType] nvarchar(max)  NOT NULL,
    [CPUHeatsink] nvarchar(max)  NOT NULL,
    [CPUWatts] int  NOT NULL,
    [CPUPrice] int  NOT NULL,
    [CPURating] int  NOT NULL
);
GO

-- Creating table 'GPUs'
CREATE TABLE [dbo].[GPUs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GPUName] nvarchar(max)  NOT NULL,
    [GPUBrand] nvarchar(max)  NOT NULL,
    [GPUWatts] int  NOT NULL,
    [GPUPrice] int  NOT NULL,
    [GPURating] int  NOT NULL
);
GO

-- Creating table 'RAMs'
CREATE TABLE [dbo].[RAMs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RAMType] nvarchar(max)  NOT NULL,
    [RAMSpeed] nvarchar(max)  NOT NULL,
    [RAMSize] int  NOT NULL,
    [RAMPrice] int  NOT NULL,
    [RAMRating] int  NOT NULL
);
GO

-- Creating table 'HEATSINKs'
CREATE TABLE [dbo].[HEATSINKs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HEATSINKName] nvarchar(max)  NOT NULL,
    [HEATSINKSocket] nvarchar(max)  NOT NULL,
    [HEATSINKPrice] int  NOT NULL,
    [HEATSINKRating] int  NOT NULL
);
GO

-- Creating table 'MOTHERBOARDs'
CREATE TABLE [dbo].[MOTHERBOARDs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MOTHERBOARDName] nvarchar(max)  NOT NULL,
    [MOTHERBOARDSize] nvarchar(max)  NOT NULL,
    [MOTHERBOARDSocke] nvarchar(max)  NOT NULL,
    [MOTHERBOARDRam] nvarchar(max)  NOT NULL,
    [MOTHERBOARDMaxRam] int  NOT NULL,
    [MOTHERBOARDPrice] int  NOT NULL,
    [MOTHERBOARDRating] int  NOT NULL
);
GO

-- Creating table 'STORAGEs'
CREATE TABLE [dbo].[STORAGEs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [STORAGEType] nvarchar(max)  NOT NULL,
    [STORAGESize] nvarchar(max)  NOT NULL,
    [STORAGEPrice] int  NOT NULL,
    [STORAGERating] int  NOT NULL
);
GO

-- Creating table 'POWERSUPPLies'
CREATE TABLE [dbo].[POWERSUPPLies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [POWERSUPPLYWatts] int  NOT NULL,
    [POWERSUPPLYBrand] nvarchar(max)  NOT NULL,
    [POWERSUPPLYPrice] int  NOT NULL,
    [POWERSUPPLYRating] int  NOT NULL
);
GO

-- Creating table 'Cases'
CREATE TABLE [dbo].[Cases] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CASEName] nvarchar(max)  NOT NULL,
    [CASESize] nvarchar(max)  NOT NULL,
    [CASELooks] nvarchar(max)  NOT NULL,
    [CASEPrice] int  NOT NULL,
    [CASERating] int  NOT NULL,
    [CASEImage] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OPTIONALs'
CREATE TABLE [dbo].[OPTIONALs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OPTIONALType] nvarchar(max)  NOT NULL,
    [Property1] nvarchar(max)  NOT NULL,
    [OPTIONALPrice] int  NOT NULL,
    [OPTIONALRating] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CPUs'
ALTER TABLE [dbo].[CPUs]
ADD CONSTRAINT [PK_CPUs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GPUs'
ALTER TABLE [dbo].[GPUs]
ADD CONSTRAINT [PK_GPUs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RAMs'
ALTER TABLE [dbo].[RAMs]
ADD CONSTRAINT [PK_RAMs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HEATSINKs'
ALTER TABLE [dbo].[HEATSINKs]
ADD CONSTRAINT [PK_HEATSINKs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MOTHERBOARDs'
ALTER TABLE [dbo].[MOTHERBOARDs]
ADD CONSTRAINT [PK_MOTHERBOARDs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'STORAGEs'
ALTER TABLE [dbo].[STORAGEs]
ADD CONSTRAINT [PK_STORAGEs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'POWERSUPPLies'
ALTER TABLE [dbo].[POWERSUPPLies]
ADD CONSTRAINT [PK_POWERSUPPLies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cases'
ALTER TABLE [dbo].[Cases]
ADD CONSTRAINT [PK_Cases]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OPTIONALs'
ALTER TABLE [dbo].[OPTIONALs]
ADD CONSTRAINT [PK_OPTIONALs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------