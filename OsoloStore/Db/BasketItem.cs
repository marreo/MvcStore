namespace OsoloStore.Db
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BasketItem")]
    public partial class BasketItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public int BasketId { get; set; }
        [ForeignKey("BasketId")]
        public virtual Basket Basket { get; set; }
        public int ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
    }
}
