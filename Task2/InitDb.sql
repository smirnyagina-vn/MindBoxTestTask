CREATE TABLE Categories (
    CategoryId INT PRIMARY KEY IDENTITY(1,1),
    CategoryName NVARCHAR(50) NOT NULL
);

CREATE TABLE Products (
    ProductId INT PRIMARY KEY IDENTITY(1,1),
    ProductName NVARCHAR(50) NOT NULL
);

CREATE TABLE ProductCategories (
    ProductId INT,
    CategoryId INT,
    FOREIGN KEY (ProductId) REFERENCES Products(ProductId),
    FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId),
    PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Categories (CategoryName) VALUES ('Electronics');
INSERT INTO Categories (CategoryName) VALUES ('Books');
INSERT INTO Categories (CategoryName) VALUES ('Clothing');
INSERT INTO Categories (CategoryName) VALUES ('Home Appliances');
INSERT INTO Categories (CategoryName) VALUES ('Furniture');
INSERT INTO Categories (CategoryName) VALUES ('Toys');
INSERT INTO Categories (CategoryName) VALUES ('Sports Equipment');

INSERT INTO Products (ProductName) VALUES ('Smartphone');
INSERT INTO Products (ProductName) VALUES ('Laptop');
INSERT INTO Products (ProductName) VALUES ('Novel');
INSERT INTO Products (ProductName) VALUES ('T-shirt');
INSERT INTO Products (ProductName) VALUES ('Table');
INSERT INTO Products (ProductName) VALUES ('Washing Machine');
INSERT INTO Products (ProductName) VALUES ('Refrigerator');
INSERT INTO Products (ProductName) VALUES ('Chair');
INSERT INTO Products (ProductName) VALUES ('Sofa');
INSERT INTO Products (ProductName) VALUES ('Bicycle');
INSERT INTO Products (ProductName) VALUES ('Doll');
INSERT INTO Products (ProductName) VALUES ('Action Figure');
INSERT INTO Products (ProductName) VALUES ('Table Tennis Racket');
INSERT INTO Products (ProductName) VALUES ('Microwave Oven'); -- Продукт без категории
INSERT INTO Products (ProductName) VALUES ('Vacuum Cleaner'); -- Продукт без категории


INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (1, 1); -- Smartphone - Electronics
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (1, 4); -- Smartphone - Home Appliances
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (2, 1); -- Laptop - Electronics
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (2, 4); -- Laptop - Home Appliances
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (3, 2); -- Novel - Books
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (3, 6); -- Novel - Toys
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (4, 3); -- T-shirt - Clothing
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (4, 7); -- T-shirt - Sports Equipment
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (5, 5); -- Table - Furniture
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (5, 1); -- Table - Electronics
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (6, 4); -- Washing Machine - Home Appliances
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (7, 4); -- Refrigerator - Home Appliances
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (8, 5); -- Chair - Furniture
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (9, 5); -- Sofa - Furniture
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (10, 7); -- Bicycle - Sports Equipment
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (10, 6); -- Bicycle - Toys
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (11, 6); -- Doll - Toys
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (12, 6); -- Action Figure - Toys
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (13, 7); -- Table Tennis Racket - Sports Equipment
