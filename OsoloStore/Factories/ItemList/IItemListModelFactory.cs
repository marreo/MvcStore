using System.Linq;
using OsoloStore.Db;
using OsoloStore.Models;

namespace OsoloStore.Factories
{
    public interface IItemListModelFactory
    {
        ItemListModel Create(IQueryable<Item> items, bool summary);
    }
}