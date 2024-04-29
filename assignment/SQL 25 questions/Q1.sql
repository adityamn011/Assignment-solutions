CREATE TABLE salespeople (
  salesman_id INT PRIMARY KEY,
  name VARCHAR(50) NOT NULL,
  city VARCHAR(50) NOT NULL,
  commission DECIMAL(5,2) NOT NULL
);
 
INSERT INTO salespeople (salesman_id, name, city, commission)
VALUES
  (5001, 'James Hoog', 'New York', 0.15),
  (5002, 'Nail Knite', 'Paris', 0.13),
  (5005, 'Pit Alex', 'London', 0.11),
  (5006, 'Mc Lyon', 'Paris', 0.14),
  (5007, 'Paul Adam', 'Rome', 0.13),
  (5003, 'Lawson Hen', 'San Jose', 0.12);
SELECT * FROM salespeople
 
SELECT 'This is SQL Exercise, Practice and Solution';
