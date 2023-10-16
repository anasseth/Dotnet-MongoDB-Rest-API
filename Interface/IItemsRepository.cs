using System;
using Catalog.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.Repositories
{
    public interface IItemsRepository
    {
        Task<Item> GetItemsByIdAsync(Guid id);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(Guid id);
    }
}