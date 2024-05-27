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
( NEWID(), @Reference, @IsUsed, @DamageOnArrival, @IsWorking, @DamageCaused, @Complaint, @DateOrdered, @Arrived, @DesiredSolution ,SYSUTCDATETIME())