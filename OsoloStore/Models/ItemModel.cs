using System.ComponentModel.DataAnnotations;

namespace OsoloStore.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        [DisplayFormat(DataFormatString = "{0:$#.##}")]
        public int Price { get; set; }
    }
}