DROP TABLE Programs
CREATE TABLE [Programs](
	[ProgramCode] [nchar](10) NOT NULL,
	[Description] [nchar](60) NOT NULL,
 CONSTRAINT [PK_Programs] PRIMARY KEY CLUSTERED 
(
	[ProgramCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Students]    Script Date: 11/29/2016 1:16:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentID] [char](10) NOT NULL,
	[FirstName] [char](25) NULL,
	[LastName] [char](25) NULL,
	[Email] [nchar](50) NULL,
	[ProgramCode] [nchar](10) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_ProgramCode] FOREIGN KEY([ProgramCode])
REFERENCES [dbo].[Programs] ([ProgramCode])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_ProgramCode]
GO
/****** Object:  StoredProcedure [dbo].[AddProgram]    Script Date: 11/29/2016 1:16:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AddProgram](@ProgramCode nchar(10), @Description nchar(60)) 
AS
DECLARE
	@return_code int = 0;
BEGIN
	Insert into Programs 
	Values(@ProgramCode, @Description)
END
RETURN @return_code

GO
/****** Object:  StoredProcedure [dbo].[AddStudent]    Script Date: 11/29/2016 1:16:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddStudent](@StudentID char(10), @FirstName nchar(10), @LastName nchar(10), @Email nchar(10), @ProgramCode nchar(10)) 
AS
	DECLARE
	@return_code int = 0;
	BEGIN
	Insert into Students (StudentID,FirstName,LastName,Email, ProgramCode)
	Values(@StudentID, @FirstName, @LastName, @Email, @ProgramCode)
	END
	RETURN @return_code
GO
/****** Object:  StoredProcedure [dbo].[DeleteStudent]    Script Date: 11/29/2016 1:16:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[DeleteStudent](@StudentID char(10)) 
AS
DECLARE
	@return_code int = 0;
BEGIN
	DELETE 
	FROM Students 
	where StudentID = @StudentID
END
RETURN @return_code;

GO
/****** Object:  StoredProcedure [dbo].[EnrollStudent]    Script Date: 11/29/2016 1:16:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EnrollStudent](@StudentID char(10), @ProgramCode nchar(10)) 
AS
DECLARE
	@return_code int = 0;
BEGIN
	UPDATE Students 
	SET ProgramCode = @ProgramCode
	where StudentID = @StudentID
END
RETURN @return_code;

GO
/****** Object:  StoredProcedure [dbo].[Getprogram]    Script Date: 11/29/2016 1:16:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Getprogram](@ProgramCode nchar(10)) 
AS
DECLARE
	@return_code int = 0;
BEGIN
	Select * 
	from Programs
	Where ProgramCode = @ProgramCode;  
END
RETURN @return_code


GO
/****** Object:  StoredProcedure [dbo].[GetStudent]    Script Date: 11/29/2016 1:16:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetStudent](@StudentID char(10)) 
AS
Declare
	@return_code int = 0;
BEGIN
	Select * 
	FROM Students
	WHERE StudentID = @StudentID;
END
RETURN @return_code

GO
/****** Object:  StoredProcedure [dbo].[GetStudents]    Script Date: 11/29/2016 1:16:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetStudents](@ProgramCode nchar(10)) 
AS
Declare
	@return_code int = 0;
BEGIN
	Select * 
	FROM Students
	WHERE ProgramCode = @ProgramCode;
END
RETURN @return_code

GO
/****** Object:  StoredProcedure [dbo].[RemoveStudents]    Script Date: 11/29/2016 1:16:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RemoveStudents](@ProgramCode varchar(10))
AS
	DELETE 
	FROM Students
	WHERE ProgramCode = @ProgramCode
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[UpdateStudent]    Script Date: 11/29/2016 1:16:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE UpdateStudent(@StudentID char(10), @FirstName nchar(10), @LastName nchar(10), @Email nchar(10)) 
AS
DECLARE
	@return_code int = 0;
BEGIN
Update Students
Set FirstName = @FirstName,
LastName = @LastName, 
Email = @Email
WHERE StudentID = @StudentID
END
RETURN @return_code
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Relationship between student and program' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Students', @level2type=N'CONSTRAINT',@level2name=N'FK_ProgramCode'
GO
USE wpritchard1
GO
ALTER DATABASE [Students_DB] SET  READ_WRITE 
GO
