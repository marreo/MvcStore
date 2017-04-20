namespace OsoloStore.Db
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Item")]
    public partial class Item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Price { get; set; }
    }
}
