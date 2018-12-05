drop table [User];
drop table [Task];
drop table [TaskCategory];

-- Script Date: 30.11.2018 13:11  - ErikEJ.SqlCeScripting version 3.5.2.75
CREATE TABLE [User] (
  [Id] int IDENTITY (1,1)  NOT NULL,
  [Login] nvarchar(20)  NOT NULL,
  [FullName] nvarchar(20),
  [Password] nvarchar(255)  NOT NULL,
  [LastLoginDate] datetime
);
GO
ALTER TABLE [User] ADD CONSTRAINT [PK_UserId] PRIMARY KEY ([Id]);
GO

CREATE TABLE [TaskCategory] (
  [Id] int IDENTITY (1,1)  NOT NULL,
  [CategoryName] nvarchar(20)  NOT NULL,
  [Description] nvarchar(1000)
);
GO
ALTER TABLE [TaskCategory] ADD CONSTRAINT [PK_TaskCategoryId] PRIMARY KEY ([Id]);
GO


CREATE TABLE [Task] (
  [Id] int IDENTITY (1,1)  NOT NULL,
  [TaskName] nvarchar(20)  NOT NULL,
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
    REFERENCES [TaskCategory] (Id) ;
GO


insert into [User]([Login],[FullName],[Password]) values ('jeden','full','dfdfdfd');
insert into [User]([Login],[FullName],[Password]) values ('drugi','full','dfdfdfd');


insert into [TaskCategory]([CategoryName],[Description]) values ('Praca','Kategoria z zadaniami związanymi z pracą');
insert into [TaskCategory]([CategoryName],[Description]) values ('Domowe','Kategoria z zadaniami związanymi domem');
insert into [TaskCategory]([CategoryName],[Description]) values ('Inne','Różne zadania bez kategorii');

insert into [Task]([TaskName],[User_Id],[Description],[TaskDate],[Completed],[TaskCategory_Id]) values ('task 1',27,'Opis taska', CONVERT(DATETIME, '07-23-08', 10),1,1);
insert into [Task]([TaskName],[User_Id],[Description],[TaskDate],[Completed],[TaskCategory_Id]) values ('task świąteczny',27,'Opis taska', CONVERT(DATETIME, '12-23-18', 10),1,1);



select * from [Task] LEFT JOIN [User] ON [User].[Id] = [Task].[User_Id];



