CREATE TABLE [dbo].[SoftwareDetail]
(
	[Id] INT NOT NULL PRIMARY KEY, 
	[Name] NVARCHAR(100) NOT NULL, 
	[Type] INT NOT NULL, 
	[Description] NVARCHAR(1000) NULL, 
	[Url] NVARCHAR(1000) NOT NULL, 
    [IsTrial] BIT NOT NULL
)
