using System;
using System.Data;

namespace LegacyService.Services
{
    public class DataAccess
    {
        public void InsertRecord(string[] cols)
        {
            // Fake DB access that demonstrates old patterns (no DI, no async)
            Console.WriteLine("[DataAccess] Inserting: " + string.Join("|", cols));
            // Simulate SQL building with concatenation (vulnerable pattern)
            string sql = "INSERT INTO Orders (A,B,C) VALUES ('" + cols[0] + "','" + cols[1] + "','" + cols[2] + "')";
            Console.WriteLine("[DataAccess] SQL: " + sql);
        }
    }
}
