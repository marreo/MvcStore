using OsoloStore.Db;
using System.Linq;
using System.Web.Mvc;

namespace OsoloStore.Controllers
{
    public class BasketController : Controller
    {
        private StoreDb _storeContext { get; set; }

        public BasketController()
        {
            _storeContext = new StoreDb();
        }

        [HttpPost]
        public bool Add(int id)
        {
            //Find basket
            var basketItemList = _storeContext.BasketItem.Where(a => a.Basket.UserId == 1); //TODO:Auth -  Add UserId from current login user

            //If basket exists
            if (basketItemList.Count() > 0 )
            {
                if (basketItemList.Any(a => a.ItemId == id))
                {
                    //Item already exists, only allowed one
                    return false;
                }

                CreateBasketItem(id, basketItemList.First().BasketId);
            }
            else
            {
                //If no basket
                _storeContext.BasketItem.Add(new BasketItem
                {
                    ItemId = id,
                    Basket = new Basket
                    {
                        UserId = 1
                    }
                });
            }
            
            _storeContext.SaveChanges();

            return true;
        }

        private void CreateBasketItem(int id, int basketId)
        {
            _storeContext.BasketItem.Add(new BasketItem
            {
                BasketId = basketId,
                ItemId = id
            });
        }

        [HttpPost]
        public bool Remove(int id)
        {
            //Basket exist for user?
            var currUserBasket = _storeContext.Basket.FirstOrDefault(a => a.UserId == 1); //TODO:Auth -  Add UserId from current login user

            if (currUserBasket != null)
            {
                //if yes Remove item
                _storeContext.Basket.Remove(currUserBasket);
            }
            
            _storeContext.SaveChanges();

            return true;
        }
    }
}