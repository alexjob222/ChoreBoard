using ChoreBoard.Data;
using ChoreBoard.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreBoard.Temp
{
    class MockCategoryDataStore : IDataService<ChoreCategory>
    {
        public Task<bool> AddItemAsync(ChoreCategory item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ChoreCategory> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ChoreCategory>> GetItemsAsync(bool forceRefresh = false)
        {
            return Task.FromResult(Enumerable.Range(1, 5)
                       .Select(i => new ChoreCategory()
                       {
                           CategoryId = i,
                           Name = $"Category #{i}"
                       }));
        }

        public Task<bool> UpdateItemAsync(ChoreCategory item)
        {
            throw new NotImplementedException();
        }
    }
}
