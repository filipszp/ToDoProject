--drop table [Task];
--GO
--drop table [TaskCategory];
--GO
--drop table [User];
--GO

CREATE TABLE [User] (
  [Id] int IDENTITY (1,1)  NOT NULL,
  [Login] nvarchar(20)  NOT NULL,
  [FullName] nvarchar(50),
  [Password] nvarchar(255)  NOT NULL,
  [LastLoginDate] datetime
);
GO
ALTER TABLE [User] ADD CONSTRAINT [PK_UserId] PRIMARY KEY ([Id]);
GO

CREATE TABLE [TaskCategory] (
  [Id] int IDENTITY (1,1)  NOT NULL,
  [CategoryName] nvarchar(50)  NOT NULL,
  [Description] nvarchar(1000)
);
GO
ALTER TABLE [TaskCategory] ADD CONSTRAINT [PK_TaskCategoryId] PRIMARY KEY ([Id]);
GO


CREATE TABLE [Task] (
  [Id] int IDENTITY (1,1)  NOT NULL,
  [TaskName] nvarchar(100)  NOT NULL,
  [CreateDate] datetime NOT NULL DEFAULT GETDATE(),
  [User_Id] int NOT NULL,
  [TaskCategory_Id] int NOT NULL,
  [Description] nvarchar(2000),
  [TaskDate] datetime NOT NULL,
  [Completed] int NOT NULL DEFAULT 0  
);
GO
ALTER TABLE [Task] ADD CONSTRAINT [PK_TaskId] PRIMARY KEY ([Id]);
GO

ALTER TABLE [Task]     
ADD CONSTRAINT FK_Task_UserId FOREIGN KEY (User_Id)     
    REFERENCES [User] (Id) ;
GO
ALTER TABLE [Task]     
ADD CONSTRAINT FK_Task_CategoryId FOREIGN KEY (TaskCategory_Id)     
    REFERENCES [TaskCategory] (Id);
GO


insert into [TaskCategory]([CategoryName],[Description]) values ('Praca','Kategoria z zadaniami związanymi z pracą');
GO
insert into [TaskCategory]([CategoryName],[Description]) values ('Domowe','Kategoria z zadaniami związanymi domem');
GO
insert into [TaskCategory]([CategoryName],[Description]) values ('Inne','Różne zadania bez kategorii');

