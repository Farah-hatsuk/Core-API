using coreAPI.Server.IDataService;
using coreAPI.Server.DTOs;
using coreAPI.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public bool deleteCategory(int id)
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

        public bool addCategory(categoryDTO categoryDTO)
        {
            if (categoryDTO == null)
            {
                return false;
            }
            var obj = new Category
            {
                Name = categoryDTO.Name,
                Description = categoryDTO.Description,
            };
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return true;

        }

        public bool updateCategory(int id, Category category)
        {
            var cat = _db.Categories.Find(id);

            if (cat == null)
                return false;
            cat.Name = category.Name;
            cat.Description = category.Description;
            _db.SaveChanges();
            return true;
        }

    }
}
