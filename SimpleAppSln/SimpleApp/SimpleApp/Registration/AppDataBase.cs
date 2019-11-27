using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;
using System.Threading.Tasks;

namespace SimpleApp.Registration
{
   public class AppDataBase
    {
        readonly SQLiteAsyncConnection database;

        public AppDataBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<InformationTable>().Wait();
        }

        public Task<List<InformationTable>> GetItemsAsync()
        {
            return database.Table<InformationTable>().ToListAsync();
        }

        public Task<List<InformationTable>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<InformationTable>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<InformationTable> GetItemAsync(int id)
        {
            return database.Table<InformationTable>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(InformationTable item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(InformationTable item)
        {
            return database.DeleteAsync(item);
        }

    }
}
