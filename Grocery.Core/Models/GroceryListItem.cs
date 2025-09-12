namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        // Eigenschappen i.p.v. velden
        public int GroceryListId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        // Navigation property
        public Product Product { get; set; } = new(0, "None", 0);

        // Constructor
        public GroceryListItem(int id, int groceryListId, int productId, int amount)
            : base(id, "")
        {
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;
        }
    }
}
