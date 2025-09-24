using System;
using System.Collections.Generic;

namespace LegacyService.Services
{
    public class Processor
    {
        private DataAccess _db;
        public Processor(DataAccess db)
        {
            _db = db;
        }
        public void RunBatch(string fileName)
        {
            Console.WriteLine("[Processor] Starting batch for " + fileName);
            var rows = ReadFile(fileName);
            foreach(var r in rows)
            {
                try
                {
                    _db.InsertRecord(r);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("[Processor] Error: " + ex.Message);
                }
            }
        }
        private List<string[]> ReadFile(string fileName)
        {
            // intentionally naive file parsing to mimic legacy code
            var list = new List<string[]>();
            if(System.IO.File.Exists(fileName))
            {
                foreach(var line in System.IO.File.ReadAllLines(fileName))
                    list.Add(line.Split(','));
            }
            return list;
        }
    }
}
