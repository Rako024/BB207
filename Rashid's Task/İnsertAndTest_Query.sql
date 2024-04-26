use Films

-- Directors
INSERT INTO Directors (FirstName, LastName, Gender) VALUES 
('Christopher', 'Nolan', 'M'),
('Quentin', 'Tarantino', 'M'),
('Greta', 'Gerwig', 'F'),
('Martin', 'Scorsese', 'M'),
('Sofia', 'Coppola', 'F'),
('Steven', 'Spielberg', 'M');

-- Movies
INSERT INTO Movies ([Name], [Description], ReleaseDate, [Length]) VALUES 
('Inception', 'A thief who enters the dreams of others to steal secrets from their subconscious.', '2010-07-16', 148),
('Pulp Fiction', 'Various interrelated stories of crime in Los Angeles.', '1994-10-14', 154),
('Little Women', 'Adaptation of Louisa May Alcott''s novel following the lives of the March sisters.', '2019-12-25', 135),
('The Godfather', 'The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.', '1972-03-24', 175),
('Lost in Translation', 'A faded movie star and a neglected young woman form an unlikely bond after crossing paths in Tokyo.', '2003-09-12', 102),
('Jurassic Park', 'During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run amok.', '1993-06-11', 127);

-- Genres
INSERT INTO Genres (GenreName) VALUES 
('Sci-Fi'),
('Crime'),
('Drama'),
('Thriller'),
('Adventure'),
('Romance');

-- MoviesDirectors
INSERT INTO MoviesDirectors (MovieId, DirectorId) VALUES
(1, 1), -- Inception, Christopher Nolan
(2, 2), -- Pulp Fiction, Quentin Tarantino
(3, 3), -- Little Women, Greta Gerwig
(4, 4), -- The Godfather, Martin Scorsese
(5, 5), -- Lost in Translation, Sofia Coppola
(6, 6); -- Jurassic Park, Steven Spielberg

-- MoviesGenres
INSERT INTO MoviesGenres (MovieId, GenreId) VALUES
(1, 1), -- Inception, Sci-Fi
(2, 2), -- Pulp Fiction, Crime
(3, 3), -- Little Women, Drama
(4, 2), -- The Godfather, Crime
(5, 4), -- Lost in Translation, Thriller
(6, 5); -- Jurassic Park, Adventure

-- Actors
INSERT INTO Actors ([Name], Surname, Gender) VALUES
('Leonardo', 'DiCaprio', 'M'),
('Tom', 'Hanks', 'M'),
('Scarlett', 'Johansson', 'F'),
('Al', 'Pacino', 'M'),
('Bill', 'Murray', 'M'),
('Sam', 'Neill', 'M'),
('Tom', 'Hardy', 'M'),
('Joseph', 'Gordon-Levitt', 'M'),
('Ellen', 'Page', 'F'),
('Uma', 'Thurman', 'F'),
('Timothée', 'Chalamet', 'M'),
('Emma', 'Watson', 'F');

-- MovieCast
INSERT INTO MovieCast (ActorId, MovieId, [Role]) VALUES
(1, 1, 'Cobb'),
(1, 5, 'Bob Harris'),
(2, 6, 'Dr. Alan Grant'),
(3, 5, 'Charlotte'),
(4, 4, 'Michael Corleone'),
(4, 2, 'Vincent Vega'),
(5, 5, 'Bob Harris'),
(6, 6, 'Dr. Alan Grant');

-- Users
INSERT INTO Users ([Name], Surname, Gender, Email, UserName) VALUES
('Alice', 'Smith', 'F', 'alice@example.com', 'alice_smith'),
('Bob', 'Johnson', 'M', 'bob@example.com', 'bob_johnson'),
('Charlie', 'Brown', 'M', 'charlie@example.com', 'charlie_brown'),
('Diana', 'Lee', 'F', 'diana@example.com', 'diana_lee'),
('Eva', 'Garcia', 'F', 'eva@example.com', 'eva_garcia'),
('Frank', 'Davis', 'M', 'frank@example.com', 'frank_davis');

-- Comments
INSERT INTO Commets (UserId, MovieId, Content, CommentDate) VALUES
(1, 1, 'Inception is mind-blowing!', '2024-04-25 10:00:00'),
(2, 2, 'Pulp Fiction is a classic!', '2024-04-24 15:30:00'),
(3, 3, 'Little Women was beautifully done.', '2024-04-23 18:45:00'),
(4, 4, 'The Godfather is a masterpiece.', '2024-04-22 12:20:00'),
(5, 5, 'Lost in Translation captures the feeling of being lost.', '2024-04-21 09:10:00'),
(6, 6, 'Jurassic Park is thrilling!', '2024-04-20 14:55:00'),
(1, 1, 'Mind-blowing movie!', '2024-04-25 11:00:00'),
(1, 2, 'Awesome film!', '2024-04-24 16:30:00'),
(2, 3, 'Beautifully portrayed!', '2024-04-23 19:45:00'),
(2, 4, 'Epic masterpiece!', '2024-04-22 13:20:00'),
(3, 5, 'Deep and emotional.', '2024-04-21 10:10:00'),
(3, 6, 'Great adventure!', '2024-04-20 15:55:00'),
(4, 1, 'One of the best!', '2024-04-25 11:15:00'),
(4, 2, 'A classic!', '2024-04-24 16:45:00'),
(5, 3, 'Loved every bit!', '2024-04-23 19:55:00'),
(5, 4, 'Incredible storytelling.', '2024-04-22 13:30:00'),
(6, 5, 'Captivating!', '2024-04-21 10:20:00'),
(6, 6, 'Adrenaline rush!', '2024-04-20 16:05:00'),
(6, 1, 'Absolutely mind-blowing!', '2024-04-25 11:30:00'),
(5, 2, 'Iconic film!', '2024-04-24 17:00:00'),
(4, 3, 'Brilliant adaptation!', '2024-04-23 20:05:00'),
(3, 4, 'Timeless classic.', '2024-04-22 13:40:00'),
(2, 5, 'Masterful!', '2024-04-21 10:30:00'),
(1, 6, 'Unforgettable experience!', '2024-04-20 16:15:00');


-- MovieCast
INSERT INTO MovieCast (ActorId, MovieId, [Role]) VALUES
(1, 1, 'Eames'),
(2, 1, 'Arthur'),
(3, 1, 'Ariadne'),
(4, 2, 'Mia Wallace'),
(5, 2, 'Butch Coolidge'),
(6, 3, 'Jo March'),
(1, 4, 'Tom Hagen'),
(2, 5, 'Bob Harris'),
(3, 6, 'Dr. Alan Grant'),
(4, 1, 'Cobb'),
(5, 2, 'Vincent Vega'),
(6, 3, 'Amy March');


SELECT 
    m.[Name] AS MovieName,
    m.Description AS MovieDescription,
    m.ReleaseDate AS ReleaseDate,
    m.Length AS MovieLength,
    d.FirstName AS DirectorFirstName,
    d.LastName AS DirectorLastName,
    d.Gender AS DirectorGender,
    g.GenreName AS Genre,
    a.[Name] AS ActorName,
    a.Surname AS ActorSurname,
    a.Gender AS ActorGender,
    mc.[Role] AS Role,
    u.[Name] AS UserName,
    u.Surname AS UserSurname,
    u.Gender AS UserGender,
    c.Content AS CommentContent,
    c.CommentDate AS CommentDate
FROM 
    Movies m
JOIN 
    MoviesDirectors md ON m.Id = md.MovieId
JOIN 
    Directors d ON md.DirectorId = d.Id
JOIN 
    MoviesGenres mg ON m.Id = mg.MovieId
JOIN 
    Genres g ON mg.GenreId = g.Id
JOIN 
    MovieCast mc ON m.Id = mc.MovieId
JOIN 
    Actors a ON mc.ActorId = a.Id
JOIN 
    Commets c ON m.Id = c.MovieId
JOIN 
    Users u ON c.UserId = u.Id;
