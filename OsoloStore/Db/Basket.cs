namespace OsoloStore.Db
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Basket")]
    public partial class Basket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserId { get; set; }
    }
}
