﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChoreBoard.Data.DataAccess
{
    public interface IDataService<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(int id);
        Task<T> GetItemAsync(int id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
    }
}