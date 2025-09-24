-- Example stored proc using old patterns
CREATE PROCEDURE usp_InsertOrder
  @CustomerName VARCHAR(200),
  @Amount DECIMAL(10,2)
AS
BEGIN
  SET NOCOUNT ON;
  INSERT INTO Orders (CustomerName, Amount, Processed) VALUES (@CustomerName, @Amount, 0);
END
