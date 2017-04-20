namespace OsoloStore.Db
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Basket")]
    public partial class Basket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
