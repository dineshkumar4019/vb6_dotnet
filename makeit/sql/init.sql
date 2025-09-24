-- Legacy schema (MS SQL flavor)
CREATE TABLE Orders (
  OrderId INT IDENTITY(1,1) PRIMARY KEY,
  CustomerName VARCHAR(200),
  Amount DECIMAL(10,2),
  Processed BIT DEFAULT 0
);
