namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get; set; } 
        public int ProductId { get; set; }     
        public int Amount { get; set; }
        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            
            int GroceryListId = id;
            int ProductId = productId;
            int Amount = amount;
        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
