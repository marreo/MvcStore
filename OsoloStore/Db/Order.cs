namespace OsoloStore.Db
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Order")]
    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int BasketId { get; set; }
        [ForeignKey("BasketId")]
        public Basket Basket { get; set; }
    }
}
