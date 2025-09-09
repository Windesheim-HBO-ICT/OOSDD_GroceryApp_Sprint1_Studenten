namespace Grocery.Core.Models
{
 
    public class GroceryListItem : Model
    {
        // Properties set private since we dont want to change them freely. constructor only
        public int GroceryListId { get; private set; }
        public int ProductId { get; private set; }
        public int Amount { get; private set; }
        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;

        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
