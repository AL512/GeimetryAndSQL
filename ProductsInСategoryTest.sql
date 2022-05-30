--Создание таблицы категории товаров
CREATE TABLE Сategories
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(30) NOT NULL
);

--Заполнение тестовыми значениями таблицу категорий товаров
INSERT INTO Сategories VALUES ('Ручки');  
INSERT INTO Сategories VALUES ('Карандаши'); 
INSERT INTO Сategories VALUES ('Зеленый');  

--Создание таблицы товаров
CREATE TABLE Products
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(30) NOT NULL
);

--Заполнение тестовыми значениями таблицу товаров
INSERT INTO Products VALUES ('Синяя ручка паркер');  
INSERT INTO Products VALUES ('Зеленая ручка паркер'); 
INSERT INTO Products VALUES ('Пачка бумаги');  

--Создание таблицы многие ко многим товар - категория
CREATE TABLE ProductsInСategory
(
    Id INT IDENTITY PRIMARY KEY,
    Product_Id int NOT NULL,
	Сategory_Id int NOT NULL
	CONSTRAINT FK_Product FOREIGN KEY (Product_Id)
        REFERENCES Products (Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	CONSTRAINT FK_Сategory FOREIGN KEY (Сategory_Id)
        REFERENCES Сategories (Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

--Заполнение тестовыми значениями таблицу товар - категория
INSERT INTO ProductsInСategory VALUES (1, 1);  
INSERT INTO ProductsInСategory VALUES (2, 1);  
INSERT INTO ProductsInСategory VALUES (2, 3); 

--выбора всех пар «Имя продукта – Имя категории»
SELECT p.Name[Продукт], ISNULL(c.Name, '-')[Категория] FROM Products p
LEFT JOIN ProductsInСategory pc ON p.Id = pc.Product_Id
LEFT JOIN Сategories c ON pc.Сategory_Id = c.Id
ORDER BY p.Name;