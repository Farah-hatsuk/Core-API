using coreAPI.Server.Models;

namespace coreAPI.Server.IDataService
{
    public interface IDataService
    {
        public List<Category> getAllCategory();

        public Category getCategoryById(int id);

        public Category getCategoryByName(string name);

        public Category getFirstCategory();
        public bool deleteCategory(int id);

        public List<Product> getAllProduct();

        public Product getProductById(int id);

        public Product getProductByName(string name);

        public Product getFirstProduct();

        public bool deleteProduct(int id);
    }
}
