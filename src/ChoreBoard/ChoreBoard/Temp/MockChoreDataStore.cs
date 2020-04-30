using ChoreBoard.Data.DataAccess;
using ChoreBoard.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ChoreBoard.Temp
{
    class MockChoreDataStore : IDataService<Chore>
    {
        public Task<bool> AddItemAsync(Chore item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Chore> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Chore>> GetItemsAsync(bool forceRefresh = false)
        {
            return Task.FromResult(Enumerable.Range(1, 15)
                        .Select(i => new Data.Chore
                        {
                            Name = $"Chore {i}",
                            Description = $"This is the description for chore {i}",
                            Notes = $"If I had notes, this is where they would go. That's why I added the field to the model"
                        }));
        }

        public Task<bool> UpdateItemAsync(Chore item)
        {
            throw new NotImplementedException();
        }
    }
}
