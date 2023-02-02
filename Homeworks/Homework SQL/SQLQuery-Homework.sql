ALTER TABLE Books
DROP COLUMN AuthorFirstName;
ALTER TABLE Books
DROP COLUMN AuthorLastName;
ALTER TABLE Books
DROP COLUMN Type;

CREATE TABLE Author
(
Id INT IDENTITY(1,1) PRIMARY KEY,
FirstName VARCHAR (50),
LastName VARCHAR (50),
Email VARCHAR (30),
)

CREATE TABLE TYPE
(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR (30),
)

ALTER TABLE Books
ADD AuthorId INT REFERENCES Author(id);

ALTER TABLE Books
ADD TypeId INT REFERENCES Type(id);

SELECT *
FROM Books;

ALTER TABLE Librarians
DROP COLUMN IsOnHoliday;

CREATE TABLE IsOnHoliday
(
Id INT IDENTITY(1,1) PRIMARY KEY,
HolidayStatus VARCHAR (20),
)

ALTER TABLE Librarians
ADD IsOnHolidayId INT REFERENCES IsOnHoliday(id);

INSERT INTO Author
VALUES ('ana', 'mitrea', 'am@gmail.com');
INSERT INTO Author
VALUES ('andrei', 'stan', 'as@gmail.com');
INSERT INTO Author
VALUES ('diana', 'ciocan', 'ac@gmail.com');
INSERT INTO Author
VALUES ('teodor', 'nistor', 'tn@gmail.com');
INSERT INTO Author
VALUES ('stefania', 'iancu', 'si@gmail.com');

SELECT *
FROM Author;

--crime, fantasy, horror, adventure
INSERT INTO TYPE
VALUES ('crime');
INSERT INTO TYPE
VALUES ('fantasy');
INSERT INTO TYPE
VALUES ('horror');
INSERT INTO TYPE
VALUES ('adventure');

SELECT *
FROM TYPE;

INSERT INTO Books
VALUES ('Book1',1,1);
INSERT INTO Books
VALUES ('Book2',1,2);
INSERT INTO Books
VALUES ('Book3',2,3);
INSERT INTO Books
VALUES ('Book4',3,4);
INSERT INTO Books
VALUES ('Book5',4,2);
INSERT INTO Books
VALUES ('Book6',5,4);
INSERT INTO Books
VALUES ('Book7',4,3);
INSERT INTO Books
VALUES ('Book8',3,2);
INSERT INTO Books
VALUES ('Book9',2,1);

SELECT *
FROM Books;

INSERT INTO Libraries
VALUES ('Library 1','Bv. Independetei','Iasi');
INSERT INTO Libraries
VALUES ('Library 2','Bv. Eroilor','Bucuresti');
INSERT INTO Libraries
VALUES ('Library 3','Strada Brancusi','Brasov');
INSERT INTO Libraries
VALUES ('Library 4','Bv. Unirii','Bucuresti');
INSERT INTO Libraries
VALUES ('Library 5','Strada Stefan Cel Mare','Iasi');
INSERT INTO Libraries
VALUES ('Library 6','Bv. Socola','Iasi');

-- Forgot to change library number
DELETE FROM Libraries
WHERE Id=6;

SELECT * 
FROM Libraries;

INSERT INTO IsOnHoliday
VALUES ('True');
INSERT INTO IsOnHoliday
VALUES ('False');

SELECT *
FROM IsOnHoliday;

INSERT INTO Librarians
VALUES ('Gustav','2022-01-01',1,1);
INSERT INTO Librarians
VALUES ('Robert','2010-01-01',7,2);
INSERT INTO Librarians
VALUES ('Giulia','2012-01-01',8,1);
INSERT INTO Librarians
VALUES ('Maxi','2019-01-01',9,2);
INSERT INTO Librarians
VALUES ('Vlad','2013-01-01',10,2);
INSERT INTO Librarians
VALUES ('Dana','2023-01-01',1,2);
INSERT INTO Librarians
VALUES ('Mihai','2007-01-01',11,1);
INSERT INTO Librarians
VALUES ('Ionut','2019-01-01',8,2);

INSERT INTO Sales
VALUES(13,1,1);
INSERT INTO Sales
VALUES(33,1,1);
INSERT INTO Sales
VALUES(312,7,2);
INSERT INTO Sales
VALUES(112,8,3);
INSERT INTO Sales
VALUES(53,9,4);
INSERT INTO Sales
VALUES(441,10,5);
INSERT INTO Sales
VALUES(444,11,6);
INSERT INTO Sales
VALUES(44,8,7);
INSERT INTO Sales
VALUES(124,9,8);
INSERT INTO Sales
VALUES(22,1,9);
INSERT INTO Sales
VALUES(44,7,10);
INSERT INTO Sales
VALUES(121,10,11);

INSERT INTO Books_Sales
VALUES (1,1);

INSERT INTO Books_Sales
VALUES (2,2);
INSERT INTO Books_Sales
VALUES (3,3);
INSERT INTO Books_Sales
VALUES (4,4);
INSERT INTO Books_Sales
VALUES (5,5);
INSERT INTO Books_Sales
VALUES (5,6);
INSERT INTO Books_Sales
VALUES (4,7);
INSERT INTO Books_Sales
VALUES (3,8);
INSERT INTO Books_Sales
VALUES (2,9);
INSERT INTO Books_Sales
VALUES (1,10);
INSERT INTO Books_Sales
VALUES (2,11);
INSERT INTO Books_Sales
VALUES (4,12);

INSERT INTO Books_Libraries
VALUES(1,1);
INSERT INTO Books_Libraries
VALUES(2,7);
INSERT INTO Books_Libraries
VALUES(3,8);
INSERT INTO Books_Libraries
VALUES(4,9);
INSERT INTO Books_Libraries
VALUES(5,10);
INSERT INTO Books_Libraries
VALUES(6,11);
INSERT INTO Books_Libraries
VALUES(7,1);
INSERT INTO Books_Libraries
VALUES(8,7);
INSERT INTO Books_Libraries
VALUES(9,8);
INSERT INTO Books_Libraries
VALUES(2,9);
INSERT INTO Books_Libraries
VALUES(3,10);
INSERT INTO Books_Libraries
VALUES(4,11);
INSERT INTO Books_Libraries
VALUES(5,1);

-- See all Tables
SELECT *
FROM Author;
SELECT *
FROM Books;
SELECT *
FROM Books_Libraries;
SELECT *
FROM Books_Sales;
SELECT *
FROM Librarians;
SELECT *
FROM Libraries;
SELECT *
FROM Sales;

--2. Display all the librarians together with the library name they work in ordered by librarian name and library name descending.

SELECT l.Name,l.HireDate,l.IsOnHolidayId as HolidayStatus, i.Name
FROM Librarians l
INNER JOIN Libraries i ON i.Id = l.LibraryId
ORDER BY l.Name ASC,i.Name DESC;

--3. Update all the street names to start with "STR.".

UPDATE LIbraries
SET
    StreetName = 'STR.'+StreetName
WHERE Id=11;

SELECT *
FROM Libraries;

--4. Display the authors' email for those who have more than 3 books published.

SELECT a.Email
FROM Author a 
RIGHT JOIN Books b ON b.AuthorId=a.Id
GROUP BY  a.Email, a.Id
HAVING COUNT(a.Id) >3;

--5. Display the library name and the book title of the largest sale (the highest number of copies sold in one sale).

SELECT l.Name, bb.Title
FROM Libraries l 
JOIN Sales s ON s.LibraryId= l.Id 
JOIN Books_Sales b ON  b.SalesId= s.Id
JOIN Books bb ON bb.Id= b.BookId
WHERE s.NumberOfCopies = ( SELECT MAX (NumberOfCopies) FROM Sales);

--6. Display all the librarians that are not on holiday and are hired more than 5 years ago.

SELECT l.Name, i.HolidayStatus as IsOnHoliday
FROM Librarians l
JOIN IsOnHoliday i ON i.Id=l.IsOnHolidayId
WHERE i.Id=2 AND l.HireDate< DATEADD(year,-5,GETDATE());

--7. Create a stored procedure that displays, based on the book title, the number of libraries in which the book is found. Call the procedure with three different book titles.

GO
CREATE PROCEDURE nrOfLibraries @BookTitle varchar(20)
AS
BEGIN
    SELECT b.Title, COUNT(l.LibraryId) as NumberOfLibraries
    FROM   Books b
    JOIN   Books_Libraries l ON l.BookId= b.Id
    WHERE b.Title= @BookTitle
    GROUP BY b.Title
END
GO

EXEC nrOfLibraries @BookTitle='Book1';
EXEC nrOfLibraries @BookTitle='Book2';
EXEC nrOfLibraries @BookTitle='Book3';

--8. Create a function that returns, based on the author's email, the number of copies sold for each of his / her books. Call the function with three different emails.
GO
CREATE FUNCTION dbo.NrOfCopies(@AuthorMail varchar(30)) 
RETURNS int
AS
BEGIN
    DECLARE @Copies INT
    SET @Copies =
    (SELECT s.NumberOfCopies 
    FROM Sales s
    JOIN Books_Sales bs ON bs.SalesId=s.Id
    JOIN Books b ON b.Id= bs.BookId
    JOIN Author a ON a.Id= b.AuthorId
    WHERE a.Email= @AuthorMail
    GROUP BY s.NumberOfCopies)
    RETURN @Copies;
END 
GO

SELECT dbo.NrOfCopies('am@gmail.com');

--9. Create a trigger so that when a new librarian is added to the system with no library assigned (NULL on LibraryId), he / she is automatically assigned to a library.

Go
CREATE TRIGGER AddStandardLibrarian
ON Librarians
AFTER INSERT
AS
BEGIN
    UPDATE Librarians
    SET LibraryId= 1
    WHERE Librarians.LibraryId=NULL
END 
GO

--10. Create a transaction that should have at least three commands inside it. Based on the logic you think of use at least one savepoint and at least one rollback operation.

BEGIN TRAN 
INSERT INTO Librarians
VALUES ('Giovanni','2022-01-01',1,2);
ROLLBACK TRAN
UPDATE LIbraries
SET
    Name= 'Carturesti'
WHERE Id=1;
SAVE TRANSACTION AddLibrarian
INSERT INTO Books
VALUES ('Book10',1,1);
COMMIT TRAN

