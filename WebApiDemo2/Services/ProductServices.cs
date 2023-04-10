using WebApiDemo2.Data;
using WebApiDemo2.Models;

namespace WebApiDemo2.Services
{
    public class ProductServices : IProductServices
    {
        private readonly ApplicationDbContext _db;
        public ProductServices(ApplicationDbContext db)
        {
            _db = db;
        }
        public int AddProduct(Product prod)
        {
            throw new NotImplementedException();
        }

        public int DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Product getProducyById(int id)
        {
            throw new NotImplementedException();
        }

        public int UpdateProduct(Product prod)
        {
            throw new NotImplementedException();
        }
    }
}
