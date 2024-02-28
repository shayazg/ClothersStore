
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/04/2023 15:10:02
-- Generated from EDMX file: C:\rpm\Papamamaya\Papamamaya\Model7.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [C:\rpm\Papamamaya\Papamamaya\practica.mdf];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[cvet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[cvet];
GO
IF OBJECT_ID(N'[dbo].[cvet1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[cvet1];
GO
IF OBJECT_ID(N'[dbo].[furnitura]', 'U') IS NOT NULL
    DROP TABLE [dbo].[furnitura];
GO
IF OBJECT_ID(N'[dbo].[furnitura_izdeliya]', 'U') IS NOT NULL
    DROP TABLE [dbo].[furnitura_izdeliya];
GO
IF OBJECT_ID(N'[dbo].[furnituraizdeliya]', 'U') IS NOT NULL
    DROP TABLE [dbo].[furnituraizdeliya];
GO
IF OBJECT_ID(N'[dbo].[izdeliya]', 'U') IS NOT NULL
    DROP TABLE [dbo].[izdeliya];
GO
IF OBJECT_ID(N'[dbo].[risunok]', 'U') IS NOT NULL
    DROP TABLE [dbo].[risunok];
GO
IF OBJECT_ID(N'[dbo].[risunoktkani]', 'U') IS NOT NULL
    DROP TABLE [dbo].[risunoktkani];
GO
IF OBJECT_ID(N'[dbo].[skladfurniturra]', 'U') IS NOT NULL
    DROP TABLE [dbo].[skladfurniturra];
GO
IF OBJECT_ID(N'[dbo].[skladtkani]', 'U') IS NOT NULL
    DROP TABLE [dbo].[skladtkani];
GO
IF OBJECT_ID(N'[dbo].[sostav]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sostav];
GO
IF OBJECT_ID(N'[dbo].[sostavtkani]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sostavtkani];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[tcanicvet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tcanicvet];
GO
IF OBJECT_ID(N'[dbo].[tip]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tip];
GO
IF OBJECT_ID(N'[dbo].[tipfurnitura]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tipfurnitura];
GO
IF OBJECT_ID(N'[dbo].[tkan1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tkan1];
GO
IF OBJECT_ID(N'[dbo].[tkani]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tkani];
GO
IF OBJECT_ID(N'[dbo].[tkani_izdeliya]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tkani_izdeliya];
GO
IF OBJECT_ID(N'[dbo].[user]', 'U') IS NOT NULL
    DROP TABLE [dbo].[user];
GO
IF OBJECT_ID(N'[dbo].[Zakaz]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zakaz];
GO
IF OBJECT_ID(N'[dbo].[zakazan_izdeliya]', 'U') IS NOT NULL
    DROP TABLE [dbo].[zakazan_izdeliya];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'cvet'
CREATE TABLE [dbo].[cvet] (
    [articul] int  NOT NULL,
    [kodcveta] int  NULL
);
GO

-- Creating table 'cvet1'
CREATE TABLE [dbo].[cvet1] (
    [kod_cveta] int  NOT NULL,
    [name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'furnitura'
CREATE TABLE [dbo].[furnitura] (
    [articul] varchar(30)  NOT NULL,
    [name] varchar(30)  NULL,
    [shirina] float  NULL,
    [dlina] float  NULL,
    [kodtipa] int  NULL,
    [cena] int  NULL,
    [ves] int  NULL
);
GO

-- Creating table 'furnitura_izdeliya'
CREATE TABLE [dbo].[furnitura_izdeliya] (
    [articul_furnitura] nvarchar(50)  NOT NULL,
    [articul_izdeliya] nvarchar(50)  NOT NULL,
    [razmeshenie] nvarchar(50)  NOT NULL,
    [povorot] int  NOT NULL,
    [kolichestvo] int  NOT NULL
);
GO

-- Creating table 'furnituraizdeliya'
CREATE TABLE [dbo].[furnituraizdeliya] (
    [articul_furnityura] nvarchar(50)  NOT NULL,
    [articul_izdeliya] nvarchar(50)  NOT NULL,
    [razmeshenie] nvarchar(50)  NOT NULL,
    [povorot] int  NOT NULL,
    [kolichestvo] int  NOT NULL
);
GO

-- Creating table 'izdeliya'
CREATE TABLE [dbo].[izdeliya] (
    [articul] int  NOT NULL,
    [name] varchar(30)  NULL,
    [shirina] int  NULL,
    [dlina] int  NULL
);
GO

-- Creating table 'risunok'
CREATE TABLE [dbo].[risunok] (
    [name] nvarchar(50)  NOT NULL,
    [kod_risunka] int  NOT NULL
);
GO

-- Creating table 'risunoktkani'
CREATE TABLE [dbo].[risunoktkani] (
    [articul] int  NOT NULL,
    [kodrisunka] int  NULL
);
GO

-- Creating table 'skladfurniturra'
CREATE TABLE [dbo].[skladfurniturra] (
    [partia] int  NOT NULL,
    [articul_furnitura] nvarchar(50)  NOT NULL,
    [kolichestvo] int  NOT NULL
);
GO

-- Creating table 'skladtkani'
CREATE TABLE [dbo].[skladtkani] (
    [articul_tkami] nvarchar(50)  NOT NULL,
    [rulon] nvarchar(50)  NOT NULL,
    [dlina] float  NOT NULL
);
GO

-- Creating table 'sostav'
CREATE TABLE [dbo].[sostav] (
    [kod_sostava] int  NOT NULL,
    [name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'sostavtkani'
CREATE TABLE [dbo].[sostavtkani] (
    [articul] int  NOT NULL,
    [kodsostava] int  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'tcanicvet'
CREATE TABLE [dbo].[tcanicvet] (
    [tkani_cvet] int  NOT NULL,
    [kod_sostava] int  NOT NULL,
    [articul] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'tip'
CREATE TABLE [dbo].[tip] (
    [kodtipa] int  NOT NULL,
    [name] varchar(30)  NULL
);
GO

-- Creating table 'tipfurnitura'
CREATE TABLE [dbo].[tipfurnitura] (
    [articul] varchar(30)  NOT NULL,
    [kodtipa] int  NULL
);
GO

-- Creating table 'tkan1'
CREATE TABLE [dbo].[tkan1] (
    [articul] int  NOT NULL,
    [name] varchar(30)  NULL,
    [kodcveta] int  NULL,
    [kodrisunka] int  NULL,
    [kodsostava] int  NULL,
    [shirina] int  NULL,
    [dlina] int  NULL,
    [cena] int  NULL
);
GO

-- Creating table 'tkani'
CREATE TABLE [dbo].[tkani] (
    [articul] nvarchar(50)  NOT NULL,
    [name] nvarchar(50)  NOT NULL,
    [shirina] int  NOT NULL,
    [dlina] int  NOT NULL,
    [cena] int  NOT NULL
);
GO

-- Creating table 'tkani_izdeliya'
CREATE TABLE [dbo].[tkani_izdeliya] (
    [artikul_tkani] nchar(10)  NOT NULL,
    [articul_izdeliya] nchar(10)  NOT NULL
);
GO

-- Creating table 'user'
CREATE TABLE [dbo].[user] (
    [login] nvarchar(50)  NOT NULL,
    [password] nvarchar(50)  NOT NULL,
    [role] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Zakaz'
CREATE TABLE [dbo].[Zakaz] (
    [nomer] int  NOT NULL,
    [data] datetime  NOT NULL,
    [etap_vypolneniya] nvarchar(50)  NOT NULL,
    [zakazchik] nvarchar(50)  NOT NULL,
    [manager] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'zakazan_izdeliya'
CREATE TABLE [dbo].[zakazan_izdeliya] (
    [nomer_zakaza] int  NOT NULL,
    [articul_izdeliya] nvarchar(50)  NOT NULL,
    [kolichestvo] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [articul] in table 'cvet'
ALTER TABLE [dbo].[cvet]
ADD CONSTRAINT [PK_cvet]
    PRIMARY KEY CLUSTERED ([articul] ASC);
GO

-- Creating primary key on [kod_cveta] in table 'cvet1'
ALTER TABLE [dbo].[cvet1]
ADD CONSTRAINT [PK_cvet1]
    PRIMARY KEY CLUSTERED ([kod_cveta] ASC);
GO

-- Creating primary key on [articul] in table 'furnitura'
ALTER TABLE [dbo].[furnitura]
ADD CONSTRAINT [PK_furnitura]
    PRIMARY KEY CLUSTERED ([articul] ASC);
GO

-- Creating primary key on [articul_furnitura] in table 'furnitura_izdeliya'
ALTER TABLE [dbo].[furnitura_izdeliya]
ADD CONSTRAINT [PK_furnitura_izdeliya]
    PRIMARY KEY CLUSTERED ([articul_furnitura] ASC);
GO

-- Creating primary key on [articul_furnityura] in table 'furnituraizdeliya'
ALTER TABLE [dbo].[furnituraizdeliya]
ADD CONSTRAINT [PK_furnituraizdeliya]
    PRIMARY KEY CLUSTERED ([articul_furnityura] ASC);
GO

-- Creating primary key on [articul] in table 'izdeliya'
ALTER TABLE [dbo].[izdeliya]
ADD CONSTRAINT [PK_izdeliya]
    PRIMARY KEY CLUSTERED ([articul] ASC);
GO

-- Creating primary key on [name], [kod_risunka] in table 'risunok'
ALTER TABLE [dbo].[risunok]
ADD CONSTRAINT [PK_risunok]
    PRIMARY KEY CLUSTERED ([name], [kod_risunka] ASC);
GO

-- Creating primary key on [articul] in table 'risunoktkani'
ALTER TABLE [dbo].[risunoktkani]
ADD CONSTRAINT [PK_risunoktkani]
    PRIMARY KEY CLUSTERED ([articul] ASC);
GO

-- Creating primary key on [partia] in table 'skladfurniturra'
ALTER TABLE [dbo].[skladfurniturra]
ADD CONSTRAINT [PK_skladfurniturra]
    PRIMARY KEY CLUSTERED ([partia] ASC);
GO

-- Creating primary key on [rulon] in table 'skladtkani'
ALTER TABLE [dbo].[skladtkani]
ADD CONSTRAINT [PK_skladtkani]
    PRIMARY KEY CLUSTERED ([rulon] ASC);
GO

-- Creating primary key on [kod_sostava] in table 'sostav'
ALTER TABLE [dbo].[sostav]
ADD CONSTRAINT [PK_sostav]
    PRIMARY KEY CLUSTERED ([kod_sostava] ASC);
GO

-- Creating primary key on [articul] in table 'sostavtkani'
ALTER TABLE [dbo].[sostavtkani]
ADD CONSTRAINT [PK_sostavtkani]
    PRIMARY KEY CLUSTERED ([articul] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [tkani_cvet], [kod_sostava], [articul] in table 'tcanicvet'
ALTER TABLE [dbo].[tcanicvet]
ADD CONSTRAINT [PK_tcanicvet]
    PRIMARY KEY CLUSTERED ([tkani_cvet], [kod_sostava], [articul] ASC);
GO

-- Creating primary key on [kodtipa] in table 'tip'
ALTER TABLE [dbo].[tip]
ADD CONSTRAINT [PK_tip]
    PRIMARY KEY CLUSTERED ([kodtipa] ASC);
GO

-- Creating primary key on [articul] in table 'tipfurnitura'
ALTER TABLE [dbo].[tipfurnitura]
ADD CONSTRAINT [PK_tipfurnitura]
    PRIMARY KEY CLUSTERED ([articul] ASC);
GO

-- Creating primary key on [articul] in table 'tkan1'
ALTER TABLE [dbo].[tkan1]
ADD CONSTRAINT [PK_tkan1]
    PRIMARY KEY CLUSTERED ([articul] ASC);
GO

-- Creating primary key on [articul] in table 'tkani'
ALTER TABLE [dbo].[tkani]
ADD CONSTRAINT [PK_tkani]
    PRIMARY KEY CLUSTERED ([articul] ASC);
GO

-- Creating primary key on [artikul_tkani] in table 'tkani_izdeliya'
ALTER TABLE [dbo].[tkani_izdeliya]
ADD CONSTRAINT [PK_tkani_izdeliya]
    PRIMARY KEY CLUSTERED ([artikul_tkani] ASC);
GO

-- Creating primary key on [login] in table 'user'
ALTER TABLE [dbo].[user]
ADD CONSTRAINT [PK_user]
    PRIMARY KEY CLUSTERED ([login] ASC);
GO

-- Creating primary key on [nomer] in table 'Zakaz'
ALTER TABLE [dbo].[Zakaz]
ADD CONSTRAINT [PK_Zakaz]
    PRIMARY KEY CLUSTERED ([nomer] ASC);
GO

-- Creating primary key on [nomer_zakaza] in table 'zakazan_izdeliya'
ALTER TABLE [dbo].[zakazan_izdeliya]
ADD CONSTRAINT [PK_zakazan_izdeliya]
    PRIMARY KEY CLUSTERED ([nomer_zakaza] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------