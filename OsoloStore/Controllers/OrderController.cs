using OsoloStore.Db;
using OsoloStore.Factories;
using System.Linq;
using System.Web.Mvc;

namespace OsoloStore.Controllers
{
    public class OrderController : Controller
    {
        private StoreDb _storeContext { get; set; }
        private IItemListModelFactory _itemListModelFactory { get; set; }

        public OrderController()
        {
            _storeContext = new StoreDb();
            _itemListModelFactory = new ItemListModelFactory();
        }


        [HttpGet]
        public ActionResult Index()
        {
            var items = _storeContext.BasketItem.Where(a => a.Basket.UserId == 1).Select(a => a.Item); //TODO:Auth -  Add UserId from current login user
            var model = _itemListModelFactory.Create(items);
            return View(model);
        }

        [HttpGet]
        public bool Add()
        {
            //Must have a basket to create an order
            if(_storeContext.Basket.Count(a => a.UserId == 1) == 1) //TODO:Auth -  Add UserId from current login user
            {
                _storeContext.Order.Add(new Order
                {
                    BasketId = _storeContext.Basket.Single(a => a.UserId == 1).Id //TODO:Auth -  Add UserId from current login user
                });
                _storeContext.SaveChanges();
                return true;
            } else
            {
                //No Valid Basket
                return false;
            }
        }
    }
}