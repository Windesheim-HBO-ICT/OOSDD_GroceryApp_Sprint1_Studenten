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
                /* 
                 * initieer de lijst met 4 nieuwe producten: 
                 * Melk[voorraad 300], 
                 * Kaas[voorraad 100], 
                 * Brood[voorraad 400] en 
                 * Cornflakes[voorraad 0]
                */


				];
        }
        public List<Product> GetAll()
        {
            return []; //wijzig dit in de gemaakte lijst uit de constructo
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
