using System;
using Catalog.Entities;
using System.Collections.Generic;

namespace Catalog.Repositories
{
    public interface IItemsRepository
    {
        Item GetItemsById(Guid id);
        IEnumerable<Item> GetItems();
    }
}