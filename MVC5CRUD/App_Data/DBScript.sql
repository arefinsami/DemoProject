
USE [MVC5CRUD]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 02-Feb-16 2:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[CustName] [varchar](100) NULL,
	[CustEmail] [varchar](150) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 02-Feb-16 2:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departments](
	[DeptNo] [int] NOT NULL,
	[DeptName] [varchar](14) NULL,
	[Location] [varchar](13) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DeptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 02-Feb-16 2:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeNo] [int] NOT NULL,
	[EmployeeName] [varchar](10) NULL,
	[Job] [varchar](9) NULL,
	[Manager] [int] NULL,
	[HireDate] [datetime] NULL,
	[Salary] [numeric](7, 2) NULL,
	[Commision] [numeric](7, 2) NULL,
	[DeptNo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

GO
INSERT [dbo].[Customers] ([Id], [CustName], [CustEmail]) VALUES (2, N'Patrick', N'patric@gmail.com')
GO
INSERT [dbo].[Customers] ([Id], [CustName], [CustEmail]) VALUES (3, N'Aron K', N'aron@gmail.com')
GO
INSERT [dbo].[Customers] ([Id], [CustName], [CustEmail]) VALUES (4, N'Steve', N'steve@yahoo.com')
GO
INSERT [dbo].[Customers] ([Id], [CustName], [CustEmail]) VALUES (5, N'Morison J', N'morison@gmail.com')
GO
INSERT [dbo].[Customers] ([Id], [CustName], [CustEmail]) VALUES (6, N'Neil', N'neil@gmail.com')
GO
INSERT [dbo].[Customers] ([Id], [CustName], [CustEmail]) VALUES (7, N'Kate', N'kt@gmail.com')
GO
INSERT [dbo].[Customers] ([Id], [CustName], [CustEmail]) VALUES (8, N'Lindsy', N'lindst@google.com')
GO
INSERT [dbo].[Customers] ([Id], [CustName], [CustEmail]) VALUES (9, N'Jeffry', N'jeff@hmail.com')
GO
INSERT [dbo].[Customers] ([Id], [CustName], [CustEmail]) VALUES (10017, N'Mahfuz A', N'mafz@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
INSERT [dbo].[Departments] ([DeptNo], [DeptName], [Location]) VALUES (1, N'ACCOUNTING', N'ST LOUIS')
GO
INSERT [dbo].[Departments] ([DeptNo], [DeptName], [Location]) VALUES (2, N'RESEARCH', N'NEW YORK')
GO
INSERT [dbo].[Departments] ([DeptNo], [DeptName], [Location]) VALUES (3, N'SALES', N'ATLANTA')
GO
INSERT [dbo].[Departments] ([DeptNo], [DeptName], [Location]) VALUES (4, N'OPERATIONS', N'SEATTLE')
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (0, N'LINCOLN 3', N'TECH', NULL, CAST(N'1994-06-23T00:00:00.000' AS DateTime), CAST(22500.00 AS Numeric(7, 2)), CAST(1400.00 AS Numeric(7, 2)), 2)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (1, N'JOHNSON', N'ADMIN', 6, CAST(N'1990-12-17T00:00:00.000' AS DateTime), CAST(18000.00 AS Numeric(7, 2)), CAST(100.00 AS Numeric(7, 2)), 4)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (2, N'HARDING', N'MANAGER', 9, CAST(N'1998-02-02T00:00:00.000' AS DateTime), CAST(52000.00 AS Numeric(7, 2)), CAST(300.00 AS Numeric(7, 2)), 3)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (3, N'TAFT', N'SALES I', 2, CAST(N'1996-01-02T00:00:00.000' AS DateTime), CAST(25000.00 AS Numeric(7, 2)), CAST(500.00 AS Numeric(7, 2)), 3)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (4, N'Aston K', N'TECH', 3, CAST(N'2016-01-17T00:00:00.000' AS DateTime), CAST(22900.00 AS Numeric(7, 2)), CAST(100.00 AS Numeric(7, 2)), 3)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (5, N'LINCOLN B', N'TECH', 0, CAST(N'1994-06-23T00:00:00.000' AS DateTime), CAST(22500.00 AS Numeric(7, 2)), CAST(1400.00 AS Numeric(7, 2)), 4)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (6, N'GARFIELD', N'MANAGER', 9, CAST(N'1993-05-01T00:00:00.000' AS DateTime), CAST(54000.00 AS Numeric(7, 2)), NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (7, N'POLK', N'TECH', 6, CAST(N'1997-09-22T00:00:00.000' AS DateTime), CAST(25000.00 AS Numeric(7, 2)), NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (8, N'GRANT', N'ENGINEER', 10, CAST(N'1997-03-30T00:00:00.000' AS DateTime), CAST(32000.00 AS Numeric(7, 2)), NULL, 2)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (9, N'JACKSON', N'CEO', NULL, CAST(N'1990-01-01T00:00:00.000' AS DateTime), CAST(75000.00 AS Numeric(7, 2)), NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (10, N'FILLMORE', N'MANAGER', 9, CAST(N'1994-08-09T00:00:00.000' AS DateTime), CAST(56000.00 AS Numeric(7, 2)), NULL, 2)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (11, N'ADAMS', N'ENGINEER', 10, CAST(N'1996-03-15T00:00:00.000' AS DateTime), CAST(34000.00 AS Numeric(7, 2)), NULL, 2)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (12, N'WASHINGTON', N'ADMIN', 6, CAST(N'1998-04-16T00:00:00.000' AS DateTime), CAST(18000.00 AS Numeric(7, 2)), NULL, 4)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (13, N'MONROE', N'ENGINEER', 10, CAST(N'2000-12-03T00:00:00.000' AS DateTime), CAST(30000.00 AS Numeric(7, 2)), NULL, 2)
GO
INSERT [dbo].[Employees] ([EmployeeNo], [EmployeeName], [Job], [Manager], [HireDate], [Salary], [Commision], [DeptNo]) VALUES (14, N'ROOSEVELT', N'CPA', 9, CAST(N'1995-10-12T00:00:00.000' AS DateTime), CAST(35000.00 AS Numeric(7, 2)), NULL, 1)
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Departments] FOREIGN KEY([DeptNo])
REFERENCES [dbo].[Departments] ([DeptNo])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Departments]
GO
/****** Object:  StoredProcedure [dbo].[Delete_Customer]    Script Date: 02-Feb-16 2:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Delete_Customer]
	-- Add the parameters for the stored procedure here
	 @Id Bigint
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM[dbo].[Customers] WHERE [Id] = @Id
	RETURN 1
END


GO
/****** Object:  StoredProcedure [dbo].[Get_Customer]    Script Date: 02-Feb-16 2:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_Customer] 
	-- Add the parameters for the stored procedure here
	@Count INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT top(@Count)* FROM [dbo].[Customers]
END


GO
/****** Object:  StoredProcedure [dbo].[Get_CustomerbyID]    Script Date: 02-Feb-16 2:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_CustomerbyID] 
	-- Add the parameters for the stored procedure here
	@Id BIGINT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM [dbo].[Customers]
	WHERE Id=@Id
END


GO
/****** Object:  StoredProcedure [dbo].[Set_Customer]    Script Date: 02-Feb-16 2:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Set_Customer]
	-- Add the parameters for the stored procedure here
	 @CustName Nvarchar(100)
	,@CustEmail Nvarchar(150)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO [dbo].[Customers] ([CustName],[CustEmail])
	VALUES(@CustName,@CustEmail)
	RETURN 1
END


GO
/****** Object:  StoredProcedure [dbo].[Update_Customer]    Script Date: 02-Feb-16 2:19:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Update_Customer]
	-- Add the parameters for the stored procedure here
	 @Id Bigint
	,@CustName Nvarchar(100)
	,@CustEmail Nvarchar(150)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE [dbo].[Customers] SET[CustName] = @CustName ,[CustEmail]= @CustEmail
	WHERE [Id] = @Id
	RETURN 1
END


GO
USE [master]
GO
ALTER DATABASE [MVC5CRUD] SET  READ_WRITE 
GO
