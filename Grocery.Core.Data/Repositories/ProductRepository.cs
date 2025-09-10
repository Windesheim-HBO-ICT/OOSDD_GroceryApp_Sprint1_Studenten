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
                new Product(0, "Melk", 300),
                new Product(1, "Kaas", 100), 
                new Product(2, "Brood", 100), 
                new Product(3, "Cornflakes", 100),
                ];
        }
        public List<Product> GetAll()
        {
            return products;
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            if(item == null)
            {
                return null;
            }
            products.Add(item);
            return item;
        }

        public Product? Delete(Product item)
        {
            Product inst = products.Where(x => x.Id == item.Id).First();
            products.Remove(inst);
            return item;
        }

        public Product? Update(Product item)
        {
            Product inst = products.Where(x => x.Id == item.Id).First();
            if (inst != null)
            {
                inst = item;
                return inst;
            }
            return null;
        }
    }
}
