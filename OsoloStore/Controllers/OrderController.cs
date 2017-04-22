using Microsoft.AspNet.Identity;
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
            var userId = User.Identity.GetUserId();
            var items = _storeContext.BasketItem.Where(a => a.Basket.UserId == userId).Select(a => a.Item);
            var model = _itemListModelFactory.Create(items);
            return View(model);
        }

        [HttpGet]
        public bool Add()
        {
            var userId = User.Identity.GetUserId();
            //Must have a basket to create an order
            if (_storeContext.Basket.Count(a => a.UserId == userId) == 1)
            {
                _storeContext.Order.Add(new Order
                {
                    BasketId = _storeContext.Basket.Single(a => a.UserId == userId).Id
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