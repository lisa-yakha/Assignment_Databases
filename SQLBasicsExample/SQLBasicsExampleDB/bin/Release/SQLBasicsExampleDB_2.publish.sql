﻿/*
Deployment script for SQLBasicsExampleDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "SQLBasicsExampleDB"
:setvar DefaultFilePrefix "SQLBasicsExampleDB"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
The type for column DateReceived in table [dbo].[ComplaintForm] is currently  BIT NOT NULL but is being changed to  DATETIME NOT NULL. Data loss could occur and deployment may fail if the column contains data that is incompatible with type  DATETIME NOT NULL.
*/

IF EXISTS (select top 1 1 from [dbo].[ComplaintForm])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Altering Table [dbo].[ComplaintForm]...';


GO
ALTER TABLE [dbo].[ComplaintForm] ALTER COLUMN [DateReceived] DATETIME NOT NULL;


GO
PRINT N'Creating Procedure [dbo].[INSERT_Complaint]...';


GO
CREATE PROCEDURE [dbo].[INSERT_Complaint]
	@Id UNIQUEIDENTIFIER,
	@Reference UNIQUEIDENTIFIER,
	@IsUsed BIT,
	@DamageOnArrival BIT,
	@IsWorking BIT,
	@DamageCaused BIT,
	@Complaint NVARCHAR,
	@DateOrdered DATETIME,
	@Arrived BIT,
	@DesiredSolution INT,
	@DateReceived DATETIME
AS
INSERT INTO ComplaintForm
(Id, Reference, IsUsed, DamageOnArrival, IsWorking, DamageCaused, Complaint, DateOrdered, Arrived, DesiredSolution, DateReceived)
values
( NEWID(), @Reference, @DamageOnArrival, @IsWorking, @DamageCaused, @Complaint, @DateOrdered, @Arrived, @DesiredSolution ,SYSUTCDATETIME())
GO
PRINT N'Update complete.';


GO
