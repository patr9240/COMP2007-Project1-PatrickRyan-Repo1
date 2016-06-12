CREATE TABLE [dbo].[Games] (
    [GameID]       INT           IDENTITY (4000, 1) NOT NULL,
    [GameName]    VARCHAR (30)   NOT NULL,
    [Description] VARCHAR (500)  NOT NULL,
    [Runs]        INT            NOT NULL,
    [Spectators]  INT            NOT NULL,
    [Team1]       VARCHAR (30)   NOT NULL,
    [Team2]       VARCHAR (30)   NOT NULL,
    [WinningTeam] INT            NOT NULL,
    [Created]     DATE           NOT NULL CURDATE(),
    CONSTRAINT [PK_Games] PRIMARY KEY CLUSTERED ([GameID] ASC),
    CONSTRAINT [FK_Games_Team1] FOREIGN KEY ([Team1]) REFERENCES [dbo].[Teams] ([TeamName]),
    CONSTRAINT [FK_Games_Team2] FOREIGN KEY ([Team2]) REFERENCES [dbo].[Teams] ([TeamName]);
    
    CREATE TABLE [dbo].[Teams] (
    [TeamID]      INT            IDENTITY (4000, 1) NOT NULL,
    [TeamName]    VARCHAR (30)   NOT NULL,
    [Description] VARCHAR (500)  NOT NULL,
    [Sport]       VARCHAR (30)   NOT NULL,
    [City]        VARCHAR (30)   NOT NULL,
    [TotalRuns]   INT            NOT NULL,
    [AllowedRuns] INT            NOT NULL,
    CONSTRAINT [PK_Teams] PRIMARY KEY CLUSTERED ([TeamID] ASC);