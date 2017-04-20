using OsoloStore.Db;
using OsoloStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace OsoloStore.Factories
{
    public class ItemListModelFactory : IItemListModelFactory
    {
        public ItemListModel Create(IQueryable<Item> items, bool summary = false)
        {
            var model = new ItemListModel();
            model.Items = new List<ItemModel>();
            model.Summary = summary;

            foreach (var item in items)
            {
                model.Items.Add(new ItemModel
                {
                    Id = item.Id,
                    ImageUrl = item.ImageUrl,
                    Name = item.Name,
                    Price = item.Price
                });
            }
            return model;
        }
    }
}