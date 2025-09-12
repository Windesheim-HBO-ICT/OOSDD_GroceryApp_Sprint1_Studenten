using Grocery.Core.Services;

namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        private int _Id { get; set; }
        private int _MyGroceryList { get; set; }
        private int _MyProduct { get; set; }
        private int _Amount;

        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            Id = id;
            _MyGroceryList = groceryListId;
            _MyProduct = productId;
            Amount = amount;
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
