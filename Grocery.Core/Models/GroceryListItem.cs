namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get; private set; }//To do: change it to a property
        public int ProductId { get; private set; }   //To do: change it to a property
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
