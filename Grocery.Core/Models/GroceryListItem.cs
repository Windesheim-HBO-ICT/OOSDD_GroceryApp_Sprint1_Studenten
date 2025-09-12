namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get; private set; }
        public int ProductId { get; private set; } 
        public int Amount { get; private set; }

        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            this.GroceryListId = groceryListId;
            this.ProductId = productId;
            this.Amount = amount;
        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
