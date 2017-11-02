CREATE TABLE [dbo].[Publishing] (
    [P_ID]         INT  IDENTITY (1, 1)  NOT NULL,
    [P_Name]       NVARCHAR (50) NOT NULL,
    [Monthly_Rate] NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([P_ID] ASC)
);


CREATE TABLE [dbo].[Subscription] (
    [S_ID]        INT  IDENTITY(1,1)  NOT NULL,
    [Username]    NVARCHAR (50) NOT NULL,
    [P_Name]      NVARCHAR (50) NOT NULL,
    [Status]      NCHAR (10)    NOT NULL,
    [Start_date]  DATE          NULL,
    [End_date]    DATE          NULL,
    [Pause_start] DATE          NULL,
    [Pause_end]   DATE          NULL,
    [Region] NVARCHAR(50) NOT NULL, 
    [Pincode] NCHAR(10) NOT NULL, 
    PRIMARY KEY CLUSTERED ([S_ID] ASC)
);



CREATE TABLE [dbo].[Users] (
    [U_ID]     INT            IDENTITY (1000, 1) NOT NULL,
    [Name]     NVARCHAR (50)  NOT NULL,
    [Email_id] NVARCHAR (50)  NOT NULL,
    [Username] NVARCHAR (50)  NOT NULL,
    [Password] NVARCHAR (50)  NOT NULL,
    [Address]  NVARCHAR (MAX) NOT NULL,
    [City]     NVARCHAR (50)  NOT NULL,
    [Pincode]  NCHAR (10)     NOT NULL,
    [State]    NVARCHAR (50)  NOT NULL,
    [Country]  NVARCHAR (50)  NOT NULL,
    [User_type] NVARCHAR(50) NOT NULL, 
    [Region] NVARCHAR(50) NOT NULL, 
    PRIMARY KEY CLUSTERED ([U_ID] ASC),
    UNIQUE NONCLUSTERED ([Email_id] ASC)
);

