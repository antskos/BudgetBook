using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetBook.Data
{
    public class BudgetBookService
    {

        private static List<Entry> mockDb = new List<Entry>() 
        {
            new Entry { Description = "Test1", Amount = 4.99m },
            new Entry { Description = "Test2", Amount = 3.05m }
        };

        public async Task<bool> AddEntry(Entry entry) 
        {
            mockDb.Add(entry);
            return true;
        }

        public async Task<List<Entry>> GetAllEntries()
        {
            return mockDb;
        }
    }
}
