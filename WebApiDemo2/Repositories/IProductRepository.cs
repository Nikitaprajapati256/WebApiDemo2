using WebApiDemo2.Models;

namespace WebApiDemo2.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product>GetAllProducts();
        Product getProducyById(int id);
        int AddProduct(Product prod);
        int UpdateProduct(Product prod);
        int DeleteProduct(int id);

    }
}
