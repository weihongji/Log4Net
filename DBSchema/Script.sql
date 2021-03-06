USE [LogDB]
GO

CREATE TABLE [dbo].[Log](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Thread] [varchar](255) NULL,
	[Level] [varchar](50) NULL,
	[Logger] [varchar](255) NULL,
	[Message] [varchar](4000) NULL,
	[Exception] [varchar](2000) NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
) ON [PRIMARY]
GO

CREATE NONCLUSTERED INDEX [IX_Log_Date_Level] ON [dbo].[Log] 
(
	[Date] ASC,
	[Level] ASC
) ON [PRIMARY]
GO
