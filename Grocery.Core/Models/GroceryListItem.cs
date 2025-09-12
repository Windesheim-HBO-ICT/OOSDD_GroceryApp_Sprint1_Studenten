namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
  
        public int GroceryListId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            //To do:assign values to the properties
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;

        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
