using Ajax_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax_Crud.Service
{
    public class ProductService : IProductService
    {
        private readonly ProductContext _db;

        public ProductService(ProductContext db)
        {
            _db = db;
        }

        public List<Product> ListProduct()
        {
            return _db.Product.Where(x=> x.status == true).ToList();
        }

        public void Add(Product product)
        {
            product.status = true;
            _db.Product.Add(product);
            _db.SaveChanges();
        }

        public void Update(Product product)
        {
            var pro = _db.Product.FirstOrDefault(x => x.id == product.id);
            pro.name = product.name;
            pro.price = product.price;
            pro.quantity = product.quantity;
            _db.Product.Update(pro);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var pro = _db.Product.FirstOrDefault(x => x.id == id);
            pro.status = false;
            _db.Product.Update(pro);
            _db.SaveChanges();
        }
       
    }
}
