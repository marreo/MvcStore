namespace OsoloStore.Db
{
    using System.Data.Entity;

    public partial class StoreDb : DbContext
    {
        //TODO: Make Interface of StoreDb to be able to Moq it, can make all controllers "testable"
        public StoreDb()
            : base("name=StoreDb")
        {
            Database.SetInitializer(new CreateInitializer());
        }

        public virtual DbSet<Basket> Basket { get; set; }
        public virtual DbSet<BasketItem> BasketItem { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        internal void Seed(StoreDb context)
        {
            context.Item.Add(new Item
            {
                Id = 1,
                ImageUrl = "audi.png",
                Name = "Audi",
                Price = 19000
            });
            context.Item.Add(new Item
            {
                Id = 2,
                ImageUrl = "bentley.png",
                Name = "Bentley",
                Price = 95000
            });
            context.Item.Add(new Item
            {
                Id = 3,
                ImageUrl = "bmw.png",
                Name = "BMW",
                Price = 45000
            });
            context.Item.Add(new Item
            {
                Id = 4,
                ImageUrl = "mc.png",
                Name = "MC",
                Price = 30000
            });
            context.Item.Add(new Item
            {
                Id = 5,
                ImageUrl = "vintage.png",
                Name = "Vintage",
                Price = 9000
            });

            context.SaveChanges();
        }
    }

    /// <summary>
    /// Kör DropCreateDatabaseAlways när jag utvecklar, tycker jag brukar slippa problem då
    /// </summary>
    public class CreateInitializer : DropCreateDatabaseAlways<StoreDb>
    {
        protected override void Seed(StoreDb context)
        {
            context.Seed(context);

            base.Seed(context);
        }
    }
}
