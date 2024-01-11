/****** Object: Table [dbo].[Authors] Script Date: 11/01/2024 15:47:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Authors] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NULL
);


/****** Object: Table [dbo].[Courses] Script Date: 11/01/2024 15:47:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Courses] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]       NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [Level]       INT            NOT NULL,
    [FullPrice]   REAL           NOT NULL,
    [Author_Id]   INT            NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Author_Id]
    ON [dbo].[Courses]([Author_Id] ASC);


GO
ALTER TABLE [dbo].[Courses]
    ADD CONSTRAINT [PK_dbo.Courses] PRIMARY KEY CLUSTERED ([Id] ASC);


GO
ALTER TABLE [dbo].[Courses]
    ADD CONSTRAINT [FK_dbo.Courses_dbo.Authors_Author_Id] FOREIGN KEY ([Author_Id]) REFERENCES [dbo].[Authors] ([Id]);



/****** Object: Table [dbo].[TagCourses] Script Date: 11/01/2024 15:47:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TagCourses] (
    [Tag_Id]    INT NOT NULL,
    [Course_Id] INT NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Tag_Id]
    ON [dbo].[TagCourses]([Tag_Id] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Course_Id]
    ON [dbo].[TagCourses]([Course_Id] ASC);


GO
ALTER TABLE [dbo].[TagCourses]
    ADD CONSTRAINT [PK_dbo.TagCourses] PRIMARY KEY CLUSTERED ([Tag_Id] ASC, [Course_Id] ASC);


GO
ALTER TABLE [dbo].[TagCourses]
    ADD CONSTRAINT [FK_dbo.TagCourses_dbo.Tags_Tag_Id] FOREIGN KEY ([Tag_Id]) REFERENCES [dbo].[Tags] ([Id]) ON DELETE CASCADE;


GO
ALTER TABLE [dbo].[TagCourses]
    ADD CONSTRAINT [FK_dbo.TagCourses_dbo.Courses_Course_Id] FOREIGN KEY ([Course_Id]) REFERENCES [dbo].[Courses] ([Id]) ON DELETE CASCADE;


/****** Object: Table [dbo].[Tags] Script Date: 11/01/2024 15:48:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tags] (
    [Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (MAX) NULL
);


