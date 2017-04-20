using System.Collections.Generic;

namespace OsoloStore.Models
{
    public class ItemListModel
    {
        public List<ItemModel> Items { get; set; }
        public bool OrderActivated { get; set; }
    }
}