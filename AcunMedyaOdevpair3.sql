-- Sorgular

-- 1. Books tablosundaki tüm kitapları listeleyin
SELECT * FROM Books;

-- 2. "Bilgisayar Bilimleri" kategorisindeki kitapları listeleyin
SELECT * FROM Books WHERE CategoryID = (SELECT CategoryID FROM Categories WHERE CategoryName = 'Bilgisayar Bilimleri');

-- 3. 2020 ve sonrasında yayımlanan kitapları listeleyin
SELECT * FROM Books WHERE PublishYear >= 2020;

-- 4. Her kitabın ismini ve ait olduğu kategoriyi listeleyin
SELECT Books.Title, Categories.CategoryName FROM Books
JOIN Categories ON Books.CategoryID = Categories.CategoryID;

-- 5. Kitap alan öğrencilerin adını, soyadını ve kitap adını listeleyin
SELECT Users.FirstName, Users.LastName, Books.Title FROM Borrowings
JOIN Users ON Borrowings.UserID = Users.UserID
JOIN Books ON Borrowings.BookID = Books.BookID;

-- 6. Her kitapla ilişkili yazarı ve yayın yılını listeleyin
SELECT Books.Title, Authors.AuthorName, Books.PublishYear FROM Books
JOIN Authors ON Books.AuthorID = Authors.AuthorID;

-- 7. Hangi kullanıcı hangi kitabı ne zaman almış?
SELECT Users.FirstName, Users.LastName, Books.Title, Borrowings.BorrowDate FROM Borrowings
JOIN Users ON Borrowings.UserID = Users.UserID
JOIN Books ON Borrowings.BookID = Books.BookID;

-- 8. Geri dönüş tarihi boş olan kitapların listesini ve kullanıcı bilgilerini getiriniz
SELECT Users.FirstName, Users.LastName, Books.Title, Borrowings.BorrowDate FROM Borrowings
JOIN Users ON Borrowings.UserID = Users.UserID
JOIN Books ON Borrowings.BookID = Books.BookID
WHERE Borrowings.ReturnDate IS NULL;

-- 9. Her kategoriye ait kaç kitap olduğunu listeleyiniz
SELECT Categories.CategoryName, COUNT(Books.BookID) AS BookCount FROM Books
JOIN Categories ON Books.CategoryID = Categories.CategoryID
GROUP BY Categories.CategoryName;

-- 10. En çok kitap ödünç alan kullanıcıları en fazla borç alandan az borç alana göre sıralayınız
SELECT Users.FirstName, Users.LastName, COUNT(Borrowings.BorrowID) AS BorrowCount FROM Borrowings
JOIN Users ON Borrowings.UserID = Users.UserID
GROUP BY Users.FirstName, Users.LastName
ORDER BY BorrowCount DESC;

-- 11. ALTER TABLE kullanımı
-- Yeni bir sütun ekleme
ALTER TABLE Books ADD PageCount INT;
-- Var olan sütunu değiştirme
ALTER TABLE Books ALTER COLUMN Title NVARCHAR(500);

-- 12. UPDATE ve DELETE kullanımı
UPDATE Books SET PublishYear = 2021 WHERE Title = 'Bilgisayar Ağları';
DELETE FROM Books Where Title = 'Da Vinci Sifresi'

-- 13. JOIN türleri
-- INNER JOIN, LEFT JOIN, RIGHT JOIN, FULL JOIN örnekleri

-- 14. HAVING ve GROUP BY kullanımı
SELECT CategoryID, COUNT(*) FROM Books GROUP BY CategoryID HAVING COUNT(*) > 2;

-- 15. TOP, OFFSET-FETCH kullanımı
SELECT TOP 5 * FROM Books ORDER BY PublishYear DESC;
SELECT * FROM Books ORDER BY PublishYear DESC OFFSET 5 ROWS FETCH NEXT 5 ROWS ONLY;

-- 16. SUBQUERY kullanımı
SELECT * FROM Users WHERE UserID IN (SELECT UserID FROM Borrowings WHERE BookID = 1);

-- 17. AND / OR mantıksal operatörleri
SELECT * FROM Books WHERE PublishYear > 2000 AND CategoryID = 1;

-- 18. BETWEEN ile aralık filtreleme
SELECT * FROM Books WHERE PublishYear BETWEEN 2020 AND 2023;

-- 19. IN ifadesi kullanımı
SELECT * FROM Books WHERE CategoryID IN (1, 3);

-- 20. LIKE operatörü kullanımı
SELECT * FROM Books WHERE Title LIKE 'Bil%';

