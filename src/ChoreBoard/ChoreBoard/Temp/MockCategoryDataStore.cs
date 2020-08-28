using ChoreBoard.Core.Models;
using ChoreBoard.Data.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoreBoard.Temp
{
    class MockCategoryDataStore : IDataService<IChoreCategory>
    {
        public Task<bool> AddItemAsync(IChoreCategory item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IChoreCategory> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IChoreCategory>> GetItemsAsync(bool forceRefresh = false)
        {
            return Task.FromResult(Enumerable.Range(1, 5)
                       .Select(i => (IChoreCategory) new ChoreCategory()
                       {
                           //CategoryId = i,
                           Name = $"Category #{i}"
                       }));
        }

        public Task<bool> UpdateItemAsync(IChoreCategory item)
        {
            throw new NotImplementedException();
        }
    }
}
