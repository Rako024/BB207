--create database Films

use Films

create table Movies
(
Id int primary key Identity,
[Name] nvarchar(50) not null,
[Description] nvarchar(1000),
ReleaseDate datetime ,
[Length] int not null
)

create table Directors
(
Id int primary key identity,
FirstName nvarchar(50) not null,
LastName nvarchar(60),
Gender nvarchar(1)
)

create table MoviesDirectors
(
Id int primary key identity,
MovieId int foreign key references Movies(Id),
DirectorId int foreign key references Directors(Id)
)

create table Genres
(
Id int primary key identity,
GenreName nvarchar(60)
)


create table MoviesGenres
(
Id int primary key identity,
MovieId int Foreign key references Movies(Id),
GenreId int foreign key references Genres(Id)
)


create table Actors
(
Id int primary key identity,
[Name] nvarchar(50) not null,
Surname nvarchar(60),
Gender nvarchar(1) 
)

create table MovieCast
(
Id int primary key identity,
ActorId int foreign key references Actors(Id),
MovieId int foreign key references Movies(Id),
[Role] nvarchar(30)
)

create table Users
(
Id int primary key identity,
[Name] nvarchar(50) not null,
Surname nvarchar(60),
Gender nvarchar(1),
Email nvarchar(60) not null,
UserName nvarchar(60) Unique not null
)

create table Commets
(
Id int primary key identity,
UserId int foreign key references Users(Id) not null,
MovieId int foreign key references Movies(Id) not null,
Content nvarchar(1500) not null,
CommentDate datetime  
)