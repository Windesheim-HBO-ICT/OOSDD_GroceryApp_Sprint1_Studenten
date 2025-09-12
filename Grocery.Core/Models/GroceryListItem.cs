namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get; set; } //To do: change it to a property. Done
        public int ProductId { get; set; }     //To do: change it to a property. Done
        public int Amount { get; set; }
        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            Id = id;
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;                //To do:assign values to the properties. Done
        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
