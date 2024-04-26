create database BlogDB

use BlogDB

create table Catagories
(
Id int primary key identity,
[Name] nvarchar(40) not null unique,
)

create table Tags
(
Id int primary key identity,
[Name] nvarchar(40) not null unique
)

create table Users
(
Id int primary key identity,
[UserName] nvarchar(40) not null unique,
FullName nvarchar(50) not null,
Age int check(Age>=0 and Age<=150)
)


create table comments
(
Id int primary key identity,
Content nvarchar(250) not null,
UserId int foreign key references Users(Id),
BlogId int references Blog(Id)
)

create table Blog
(
Id int primary key identity,
Title nvarchar(50) not null,
[Description] nvarchar(1000) not null,
UserID int references Users(Id),
CatagorieId int references Catagories(Id)
)


Create view GetTitleUserNameSurname
as
select b.Title,u.UserName,u.FullName from Blog as b 
join Users as u
on u.Id = b.Id

select * from GetTitleUserNameSurname

create view GetBlogCatagories
as
select b.Title,c.Name from Blog b
join Catagories c
on b.Id = c.Id

select * from GetBlogCatagories

create procedure GetUsersComments @UserId int
as
begin
select c.Content from comments c
where c.UserId = @UserId
end

execute GetUsersComments 1

create procedure GetUsersBlogs @UserId int
as
begin 
select b.Title,b.Description from Blog b
where b.UserID = @UserId
end

execute GetUsersBlogs 1

create function GetCatagorysBlogs (@CatagoryId int)
returns int
as
Begin
declare @Count int
select @Count  = Count(*) from Blog b
where b.CatagorieId = @CatagoryId	
return @Count
end

select dbo.GetCatagorysBlogs(1) as count

create function GetTableUsersBlog (@UserId int)
returns Table
as
return
	select * from Blog b
	where b.UserID = @UserId

select * from dbo.GetTableUsersBlog(1) 

INSERT INTO Catagories ([Name]) VALUES ('Category 1');
INSERT INTO Catagories ([Name]) VALUES ('Category 2');
INSERT INTO Catagories ([Name]) VALUES ('Category 3');

INSERT INTO Tags ([Name]) VALUES ('Tag 1');
INSERT INTO Tags ([Name]) VALUES ('Tag 2');
INSERT INTO Tags ([Name]) VALUES ('Tag 3');

INSERT INTO Users (UserName, FullName, Age) VALUES ('user1', 'User One', 25);
INSERT INTO Users (UserName, FullName, Age) VALUES ('user2', 'User Two', 30);
INSERT INTO Users (UserName, FullName, Age) VALUES ('user3', 'User Three', 35);

Select * from Catagories
select * from Users
select * from Blog
select * from Tags
insert into Blog values ('title1','description1',1,2)
insert into Blog values ('title2','description2',2,3)
insert into Blog values ('title3','description3',1,3)
insert into Blog values ('title4','description4',3,1)
insert into Blog values ('title5','description6',2,2)
insert into Blog values ('title7','description7',3,2)

insert into comments values ('content1',1,3)
insert into comments values ('content2',1,2)
insert into comments values ('content3',2,3)
insert into comments values ('content4',2,1)
insert into comments values ('content5',3,3)