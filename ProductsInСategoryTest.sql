--�������� ������� ��������� �������
CREATE TABLE �ategories
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(30) NOT NULL
);

--���������� ��������� ���������� ������� ��������� �������
INSERT INTO �ategories VALUES ('�����');  
INSERT INTO �ategories VALUES ('���������'); 
INSERT INTO �ategories VALUES ('�������');  

--�������� ������� �������
CREATE TABLE Products
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(30) NOT NULL
);

--���������� ��������� ���������� ������� �������
INSERT INTO Products VALUES ('����� ����� ������');  
INSERT INTO Products VALUES ('������� ����� ������'); 
INSERT INTO Products VALUES ('����� ������');  

--�������� ������� ������ �� ������ ����� - ���������
CREATE TABLE ProductsIn�ategory
(
    Id INT IDENTITY PRIMARY KEY,
    Product_Id int NOT NULL,
	�ategory_Id int NOT NULL
	CONSTRAINT FK_Product FOREIGN KEY (Product_Id)
        REFERENCES Products (Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
	CONSTRAINT FK_�ategory FOREIGN KEY (�ategory_Id)
        REFERENCES �ategories (Id)
        ON DELETE CASCADE
        ON UPDATE CASCADE
);

--���������� ��������� ���������� ������� ����� - ���������
INSERT INTO ProductsIn�ategory VALUES (1, 1);  
INSERT INTO ProductsIn�ategory VALUES (2, 1);  
INSERT INTO ProductsIn�ategory VALUES (2, 3); 

--������ ���� ��� ���� �������� � ��� ���������
SELECT p.Name[�������], ISNULL(c.Name, '-')[���������] FROM Products p
LEFT JOIN ProductsIn�ategory pc ON p.Id = pc.Product_Id
LEFT JOIN �ategories c ON pc.�ategory_Id = c.Id
ORDER BY p.Name;