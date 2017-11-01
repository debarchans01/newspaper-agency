CREATE TABLE [dbo].[Publishing]
(
	[P_ID] NCHAR(10) NOT NULL PRIMARY KEY, 
    [P_Name] NVARCHAR(50) NOT NULL, 
    [Monthly_Rate] NCHAR(10) NULL

)
CREATE TABLE [dbo].[Subscription]
(
	[S_ID] NCHAR(10) NOT NULL PRIMARY KEY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [P_Name] NVARCHAR(50) NOT NULL, 
    [Status] NCHAR(10) NOT NULL, 
    [Start_date] DATE NULL, 
    [End_date] DATE NULL, 
    [Pause_start] DATE NULL, 
    [Pause_end] DATE NULL
)

CREATE TABLE [dbo].[User]
(
	[U_ID] INT IDENTITY(1000,1) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Email-id] NVARCHAR(50) NOT NULL UNIQUE, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(MAX) NOT NULL, 
    [City] NVARCHAR(50) NOT NULL, 
    [Pincode] NCHAR(10) NOT NULL, 
    [State] NVARCHAR(50) NOT NULL, 
    [Country] NVARCHAR(50) NOT NULL
)

