using coreAPI.Server.IDataService;
using coreAPI.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreAPI.Server.DataService
{
    public class DataService : coreAPI.Server.IDataService.IDataService
    {
        private readonly MyDbContext _db;

        public DataService(MyDbContext db)
        {
            _db = db;
        }

        public List<Category> getAllCategory()
        {
            var categoty = _db.Categories.ToList();
            return categoty;
        }

        public Category getCategoryById(int id)
        {
            var category = _db.Categories.FirstOrDefault(c => c.Id == id);
     
                return category; //200
        }

        public Category getCategoryByName(string name)
        {
            var category = _db.Categories.FirstOrDefault(x => x.Name == name);
 
                return category;

         
        }

        public Category getFirstCategory()
        {
            var FirstCategory = _db.Categories.First();
            return FirstCategory;
        }

        public bool  deleteCategory(int id)
        {
            var category = _db.Categories.Find(id);
            if (category != null)
            {
                _db.Categories.Remove(category);
                _db.SaveChanges();
               return true;
            }
            return false;
          
        }


        public List<Product> getAllProduct()
        {
            var Products = _db.Products.ToList();
            return Products;
        }

        public Product getProductById(int id)
        {
            var Product = _db.Products.FirstOrDefault(p => p.Id == id);

                return Product;
          
        }

        public Product getProductByName(string name)
        {
            var Product = _db.Products.FirstOrDefault(x => x.Name == name);
           
                return Product;
          
        }

        public Product getFirstProduct()
        {
            var FirstProduct = _db.Products.First();
            return FirstProduct;
        }

     

        public bool deleteProduct(int id)
        {
            var product = _db.Categories.Find(id);
            if (product != null)
            {
                _db.Categories.Remove(product);
                _db.SaveChanges();
                return true;
            }
            return false;

        }

    }
}
