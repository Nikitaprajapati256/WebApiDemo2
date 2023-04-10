using WebApiDemo2.Models;

namespace WebApiDemo2.Services
{
    public interface IProductServices
    {
        IEnumerable<Product> GetAllProducts();
        Product getProducyById(int id);
        int AddProduct(Product prod);
        int UpdateProduct(Product prod);
        int DeleteProduct(int id);
    }
}
