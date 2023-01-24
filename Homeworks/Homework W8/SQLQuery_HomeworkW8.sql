CREATE DATABASE ZooManagemnt;

USE ZooManagemnt;
-- Creating tables
CREATE TABLE ZoneArea
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Zone VARCHAR(50)
);

CREATE TABLE Species
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50),
Zone INT REFERENCES ZoneArea(Id)
);

CREATE TABLE Animals
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Species INT REFERENCES Species(Id)
);

CREATE TABLE Workers
(
Id INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR (20),
LastName VARCHAR (20),
WorkArea INT REFERENCES ZoneArea(Id)
);

CREATE TABLE Ticket
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Price MONEY,
ValidityStart DATE,
ValidityEnd DATE,
Zone INT REFERENCES ZoneArea(Id)
);

SELECT *
FROM Ticket;

CREATE TABLE Visitors
(
Id INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR (20),
LastName VARCHAR (20),
Ticket INT REFERENCES Ticket(Id)
);
-- Populating tables + Changes related to tables if needed
INSERT INTO ZoneArea
VALUES ('Fish');
INSERT INTO ZoneArea
VALUES ('Amphibians');
INSERT INTO ZoneArea
VALUES ('Reptiles');
INSERT INTO ZoneArea
VALUES ('Birds');
INSERT INTO ZoneArea
VALUES ('Mammals');

SELECT *
FROM ZoneArea;

INSERT INTO Species
VALUES ('Goldfish',1);
INSERT INTO Species
VALUES ('Angelfish',1);
INSERT INTO Species
VALUES ('Neon Tetra',1);
INSERT INTO Species
VALUES ('Catfish',1);
INSERT INTO Species
VALUES ('Frog',2);
INSERT INTO Species
VALUES ('Toad',2);
INSERT INTO Species
VALUES ('Salamander',2);
INSERT INTO Species
VALUES ('Newt',2);
INSERT INTO Species
VALUES ('Turtle',3);
INSERT INTO Species
VALUES ('Lizard',3);
INSERT INTO Species
VALUES ('Snake',3);
INSERT INTO Species
VALUES ('Peafowl',4);
INSERT INTO Species
VALUES ('Emu',4);
INSERT INTO Species
VALUES ('Parrot',4);
INSERT INTO Species
VALUES ('Duck',4);
INSERT INTO Species
VALUES ('Swan',4);
INSERT INTO Species
VALUES ('Tiger',5);
INSERT INTO Species
VALUES ('Gorilla',5);
INSERT INTO Species
VALUES ('Leopard',5);
INSERT INTO Species
VALUES ('Bear',5);



SELECT *
FROM Species;

SELECT *
FROM ZoneArea;



ALTER TABLE Workers
DROP constraint FK__Workers__WorkAre__3F466844;
ALTER TABLE Workers
DROP COLUMN WorkArea;

ALTER TABLE ZoneArea
ADD Worker INT REFERENCES Workers(Id);

SELECT *
FROM Workers;

INSERT INTO Workers
VALUES ('Gigi','Negoi');
INSERT INTO Workers
VALUES ('Liviu','Albu');
INSERT INTO Workers
VALUES ('Lavinia','Sagan');
INSERT INTO Workers
VALUES ('Luca','Nifor');

-- modifing table ZoneArea after Changing foreign key
UPDATE ZoneArea
SET Worker = 4 
WHERE Id = 5;

SELECT *
FROM ZoneArea;
-- Safety code to run tables and see if joins are working
SELECT z.[Zone], w.FirstName
FROM ZoneArea z
JOIN Workers  w ON z.Worker=w.Id;

SELECT * 
FROM Ticket;

INSERT INTO Ticket
VALUES(10,'2023-01-20','2023-01-20',1);
INSERT INTO Ticket
VALUES(10,'2023-01-20','2023-01-20',2);
INSERT INTO Ticket
VALUES(50,'2023-01-20','2023-01-27',3);
INSERT INTO Ticket
VALUES(80,'2023-01-20','2023-02-20',2);
INSERT INTO Ticket
VALUES(50,'2023-02-10','2023-02-20',2,4);
INSERT INTO Ticket
VALUES(10,'2023-01-22','2023-01-22',4,5);
INSERT INTO Ticket
VALUES(80,'2023-01-24','2023-02-24',5,6);

ALTER TABLE Visitors
DROP constraint FK__Visitors__Ticket__44FF419A;
ALTER TABLE Visitors
DROP COLUMN Ticket;

ALTER TABLE Ticket
ADD Visitor INT REFERENCES Visitors(Id);

SELECT * 
FROM Ticket;

UPDATE Ticket
SET Visitor = 3 
WHERE Id = 9;

SELECT *
FROM Visitors;
SELECT * 
FROM Ticket;

INSERT INTO Visitors
VALUES('Alexandru','Mihai');
INSERT INTO Visitors
VALUES('Loredana','Luca');
INSERT INTO Visitors
VALUES('Elvis','Musteata');
INSERT INTO Visitors
VALUES('Emanuela','Coroi');
INSERT INTO Visitors
VALUES('George','Buhusi');
INSERT INTO Visitors
VALUES('Gina','Doroh');

INSERT INTO Animals
VALUES (1);
INSERT INTO Animals
VALUES (1);
INSERT INTO Animals
VALUES (1);
INSERT INTO Animals
VALUES (1);
INSERT INTO Animals
VALUES (2);
INSERT INTO Animals
VALUES (2);
INSERT INTO Animals
VALUES (2);
INSERT INTO Animals
VALUES (2);
INSERT INTO Animals
VALUES (2);
INSERT INTO Animals
VALUES (3);
INSERT INTO Animals
VALUES (4);
INSERT INTO Animals
VALUES (5);
INSERT INTO Animals
VALUES (6);
INSERT INTO Animals
VALUES (6);
INSERT INTO Animals
VALUES (7);
INSERT INTO Animals
VALUES (7);
--
INSERT INTO Animals
VALUES (8);
INSERT INTO Animals
VALUES (8);
INSERT INTO Animals
VALUES (9);
INSERT INTO Animals
VALUES (9);
INSERT INTO Animals
VALUES (10);
INSERT INTO Animals
VALUES (11);
INSERT INTO Animals
VALUES (12);
INSERT INTO Animals
VALUES (12);
INSERT INTO Animals
VALUES (13);
INSERT INTO Animals
VALUES (14);
INSERT INTO Animals
VALUES (15);
INSERT INTO Animals
VALUES (16);
INSERT INTO Animals
VALUES (17);
INSERT INTO Animals
VALUES (17);
INSERT INTO Animals
VALUES (18);
INSERT INTO Animals
VALUES (18);
INSERT INTO Animals
VALUES (19);
INSERT INTO Animals
VALUES (19);
INSERT INTO Animals
VALUES (20);
INSERT INTO Animals
VALUES (20);
INSERT INTO Animals
VALUES (21);
INSERT INTO Animals
VALUES (21);
INSERT INTO Animals
VALUES (21);
INSERT INTO Animals
VALUES (20);
INSERT INTO Animals
VALUES (18);
INSERT INTO Animals
VALUES (17);
INSERT INTO Animals
VALUES (16);
INSERT INTO Animals
VALUES (15);

SELECT *
FROM Animals;
SELECT *
FROM Species;
SELECT *
FROM Ticket;
SELECT *
FROM Visitors;
SELECT *
FROM Workers;
SELECt *
FROM ZoneArea;
-- Requirements

--the number of animals as a total and in each species

SELECT COUNT( a.Id) as TotalOfAnimals
FROM Animals a;

SELECT COUNT( a.Id) as TotalOfAnimals, s.Name
FROM Animals a
JOIN Species s on a.Species= s.Id
GROUP BY s.Name;

--the number of species 

SELECT COUNT (s.Id) as TotalOfSpecies
FROM Species s

-- number of visitors per day

SELECT COUNT ( t.Id) as TotalOfVisitors
FROM Ticket t
JOIN Visitors v on v.Id=t.Visitor
WHERE t.ValidityStart = '2023-01-20' AND t.ValidityStart= '2023-01-20';

--the ticket price and validity

SELECT t.Price , t.ValidityStart, t.ValidityEnd
FROM Ticket t;

--details about the caretakers and the area their work area

SELECT w.FirstName as Caretaker, z.[Zone]
FROM Workers w
JOIN ZoneArea z on z.Id= w.Id;

SELECT *
FROM Workers;
SELECT *
FROM ZoneArea;