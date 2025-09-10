using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.Core.Services
{
    public class GroceryListItemsService : IGroceryListItemsService
    {
        private readonly IGroceryListItemsRepository _groceriesRepository;
        private readonly IProductRepository _productRepository;

        public GroceryListItemsService(IGroceryListItemsRepository groceriesRepository, IProductRepository productRepository)
        {
            _groceriesRepository = groceriesRepository;
            _productRepository = productRepository;
            foreach (GroceryListItem g in _groceriesRepository.GetAll())
            {
                g.Product = _productRepository.Get(g.ProductId) ?? new(0, "", 0);
            }
        }

        public List<GroceryListItem> GetAll()
        {
            return _groceriesRepository.GetAll();
        }

        public List<GroceryListItem> GetAllOnGroceryListId(int groceryListId)
        {
           //List<GroceryListItem> listItems = _groceriesRepository.GetAll().Where(g => g.GroceryListId == groceryListId).ToList();
           //foreach (GroceryListItem listItem in listItems)
           //{
               
           //}
           return _groceriesRepository.GetAll().Where(g => g.GroceryListId == groceryListId).ToList();
        }

        public GroceryListItem Add(GroceryListItem item)
        {
            throw new NotImplementedException();
        }

        public GroceryListItem? Delete(GroceryListItem item)
        {
            throw new NotImplementedException();
        }

        public GroceryListItem? Get(int id) =>  _groceriesRepository.Get(id);

        public GroceryListItem? Update(GroceryListItem item)
        {
            throw new NotImplementedException();
        }
    }
}
