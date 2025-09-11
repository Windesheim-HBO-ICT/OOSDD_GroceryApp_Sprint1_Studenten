using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> products;

        public ProductRepository()
        {
            products = [
                new Product(1, "Melk", 300),        // Milk with stock 300
                new Product(2, "Kaas", 100),        // Cheese with stock 100
                new Product(3, "Brood", 400),       // Bread with stock 400
                new Product(4, "Cornflakes", 0)     // Cornflakes with stock 0
            ];
        }

        public List<Product> GetAll()
        {
            return products; // Return the initialized list from constructor
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}