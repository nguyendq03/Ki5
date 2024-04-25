USE [MyStock]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 3/19/2024 8:25:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarID] [int] NOT NULL,
	[CarName] [varchar](50) NOT NULL,
	[Manufacturer] [varchar](50) NOT NULL,
	[price] [money] NOT NULL,
	[ReleasedYear] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Cars] ([CarID], [CarName], [Manufacturer], [price], [ReleasedYear]) VALUES (1, N'Accord', N'Honda Motor Company', 24970.0000, 2021)
INSERT [dbo].[Cars] ([CarID], [CarName], [Manufacturer], [price], [ReleasedYear]) VALUES (3, N'Clarity', N'Honda Motor Company', 33400.0000, 2021)
INSERT [dbo].[Cars] ([CarID], [CarName], [Manufacturer], [price], [ReleasedYear]) VALUES (4, N'BMW 8 Series', N'BMW', 85000.0000, 2021)
INSERT [dbo].[Cars] ([CarID], [CarName], [Manufacturer], [price], [ReleasedYear]) VALUES (5, N'Audi A6', N'Audi', 14000.0000, 2020)
GO
