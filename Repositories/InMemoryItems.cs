using System;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public class InMemoryItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 10, CreationDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 20, CreationDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 15, CreationDate = DateTimeOffset.UtcNow }
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItemsById(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItem(Item item)
        {
            // items.(item);
            var index = items.FindIndex(existingItem => existingItem.Id == item.Id);
            if (index > -1)
            {
                items[index] = item;
            }
        }

        public void DeleteItem(Guid id)
        {
            // items.(item);
            var index = items.FindIndex(existingItem => existingItem.Id == id);
            if (index > -1)
            {
                items.RemoveAt(index);
            }
        }
    }
}