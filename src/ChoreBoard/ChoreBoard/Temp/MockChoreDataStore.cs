using ChoreBoard.Data.DataAccess;
using ChoreBoard.Core.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ChoreBoard.Temp
{
    class MockChoreDataStore : IDataService<IChore>
    {
        public Task<bool> AddItemAsync(IChore item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IChore> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IChore>> GetItemsAsync(bool forceRefresh = false)
        {
            return Task.FromResult(Enumerable.Range(1, 15)
                        .Select(i => (IChore)new Chore
                        {
                            Name = $"Chore {i}",
                            Notes = $"If I had notes, this is where they would go. That's why I added the field to the model"
                        }));
        }

        public Task<bool> UpdateItemAsync(IChore item)
        {
            throw new NotImplementedException();
        }
    }
}
