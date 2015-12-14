using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeedConnection.Models;
using SeedConnection.Data;

namespace SeedConnection.Services
{
    public class ProductService
    {
        DbConnection _context;

        public ProductService()
        {
            _context = new DbConnection();
        }

        public List<Product> GetProductsByUserId(string userId)
        {
            return _context.Products.Where(p => p.UserId == userId).ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.ProductId == id);
        }

        public void CreateProduct(Product product)
        {
            Product newProduct = new Product
            {
                Name = product.Name,
                UserId = product.UserId,
                Type = product.Type,
                Quantity = product.Quantity,
                DataAvailable = product.DataAvailable,
                Selling = product.Selling
            };

            _context.Products.Add(newProduct);
            _context.SaveChanges();
        }

        public bool UpdateProduct(Product product)
        {
            Product updateProduct = GetProductById(product.ProductId);
            if (updateProduct == null) return false;

            updateProduct.Name = product.Name;
            updateProduct.Type = product.Type;
            updateProduct.Quantity = product.Quantity;
            updateProduct.DataAvailable = product.DataAvailable;
            updateProduct.Selling = product.Selling;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteProduct(int id)
        {
            Product product = GetProductById(id);
            if (product == null) return false;

            _context.Products.Remove(product);
            _context.SaveChanges();

            return true;
        }
    }
}
