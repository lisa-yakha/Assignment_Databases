CREATE TABLE [dbo].ComplaintForm
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Reference] UNIQUEIDENTIFIER NOT NULL, 
    [IsUsed] BIT NOT NULL, 
    [DamageOnArrival] BIT NOT NULL,
    [IsWorking] BIT NOT NULL,
    [DamageCaused] BIT NOT NULL, 
    [Complaint] NVARCHAR(2000) NOT NULL,
    [DateOrdered] DATETIME NOT NULL,
    [Arrived] BIT NOT NULL, 
    [DesiredSolution] INT NOT NULL, 
    [DateReceived] DATETIME NOT NULL,
    CONSTRAINT FK_Reference FOREIGN KEY (Reference) REFERENCES Products(Id)

)
