using Grocery.Core.Services;

namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get; set; }
        public int ProductId { get; set; }
        public int _Amount;
        public Product Product { get; set; } = new(0, "None", 0);

        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            Id = id;
            GroceryListId = groceryListId;
            ProductId = productId;
            _Amount = amount;
        }

        public int Amount
        {
            get { return _Amount; }
            set
            {
                if (value > 0)
                {
                    _Amount = value;
                }
                else
                {
                    throw new ArgumentException("Amount must be greater than 0");
                }
            }
        }
    }
}
