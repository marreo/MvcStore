using OsoloStore.Db;
using OsoloStore.Factories;
using System.Linq;
using System.Web.Mvc;

namespace OsoloStore.Controllers
{
    public class ItemController : Controller
    {
        private StoreDb _storeContext { get; set; }
        
        private IItemListModelFactory _itemListModelFactory { get; set; }        

        public ItemController()
        {
            _storeContext = new StoreDb();
            _itemListModelFactory = new ItemListModelFactory();
        }
        
        [HttpGet]
        public ActionResult Get()
        {
            var items = _storeContext.Item.Take(10);
            var model = _itemListModelFactory.Create(items);
            return PartialView("ItemList", model);
        }
    }
}