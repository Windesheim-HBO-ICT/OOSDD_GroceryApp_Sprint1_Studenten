namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get; set; } //Done: change it to a property
        public int ProductId { get; set; }    //Done: change it to a property
        public int Amount { get; set; }
        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            this.GroceryListId = groceryListId;
            this.ProductId = productId;
            this.Amount = amount;
            //Done:assign values to the properties
        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
