IF DB_ID(N'pharmacy') IS NULL
BEGIN
    CREATE DATABASE [pharmacy];
END
GO

USE [pharmacy];
GO

IF OBJECT_ID(N'dbo.users', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.users
    (
        id INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_users PRIMARY KEY,
        userRole NVARCHAR(50) NOT NULL,
        names NVARCHAR(250) NOT NULL,
        mobile BIGINT NOT NULL,
        dob NVARCHAR(250) NOT NULL,
        email NVARCHAR(250) NOT NULL,
        username NVARCHAR(250) NOT NULL CONSTRAINT UQ_users_username UNIQUE,
        pass NVARCHAR(250) NOT NULL
    );
END
GO

IF OBJECT_ID(N'dbo.medic', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.medic
    (
        id INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_medic PRIMARY KEY,
        mid NVARCHAR(250) NOT NULL CONSTRAINT UQ_medic_mid UNIQUE,
        mname NVARCHAR(250) NOT NULL,
        mnumber NVARCHAR(250) NOT NULL,
        mdate NVARCHAR(250) NOT NULL,
        edate NVARCHAR(250) NOT NULL,
        quantity BIGINT NOT NULL CONSTRAINT CK_medic_quantity_nonnegative CHECK (quantity >= 0),
        perunit BIGINT NOT NULL CONSTRAINT CK_medic_perunit_nonnegative CHECK (perunit >= 0)
    );
END
GO
