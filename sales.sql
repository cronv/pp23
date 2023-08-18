CREATE DATABASE IF NOT EXISTS db_analyse;

USE db_analyse;

CREATE TABLE IF NOT EXISTS sales (
    id INT PRIMARY KEY AUTO_INCREMENT,
    product VARCHAR(255),
    category VARCHAR(255),
    quantity INT,
    price DECIMAL(10, 2)
);

INSERT INTO sales (`product`, `category`, `quantity`, `price`)
SELECT
    CONCAT('Product_', FLOOR(RAND() * 1000)) AS product,
    CONCAT('Category_', FLOOR(RAND() * 10)) AS category,
    FLOOR(RAND() * 10) AS quantity,
    FLOOR(RAND() * 1000 + 1) AS price
FROM
    information_schema.TABLES AS t1
        CROSS JOIN information_schema.TABLES AS t2
    LIMIT 200;
