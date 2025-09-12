namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    { //variiabelen omgezet naar properties
        public int GroceryListId { get; set; } //To do: change it to a property
        public int ProductId { get; set; }     //To do: change it to a property
        public int Amount { get; set; }
        
        //Constructor wijst de waarden toe aan de properties
        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            GroceryListId = groceryListId; //To do:assign values to the properties
            ProductId = productId;
            Amount = amount;
        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}
