using Ajax_Crud.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        public List<ProductViewModel> ListProduct(ObjectProduct objectProduct)
        {
            return _db.ProductViewModel.FromSqlRaw("SP_GetProductsByFilter @p0, @p1, @p2, @p3, @p4, @p5",
            objectProduct.Keyword, objectProduct.Top, objectProduct.Page, objectProduct.Status, objectProduct.FirstDate, objectProduct.LastDate).ToList();  
        }

        public void Add(Product product)
        {
            try
            {
                product.Status = 1;
                product.Createdate = DateTime.Now;

                _db.Product.Add(product);
                _db.SaveChanges();
                _db.Dispose();
            }
            catch
            {
                
            }


        }

        public void Update(Product product)
        {
            try
            {
                var pro = _db.Product.FirstOrDefault(x => x.Id == product.Id);
                pro.Name = product.Name;
                pro.Price = product.Price;
                pro.Quantity = product.Quantity;

                _db.Product.Update(pro);
                _db.SaveChanges();
                _db.Dispose();
            }
            catch { }
           
        }
       
        public void ActiveStatus(int Id)
        {
            if (Id > 0)
            {
                var pro = _db.Product.FirstOrDefault(x => x.Id == Id);
                if (pro.Status == (int)EProductStatus.Block)
                {
                    pro.Status = (int)EProductStatus.Active;
                }
                else
                {
                    pro.Status = (int)EProductStatus.Block;
                }
                _db.Product.Update(pro);
            }
            else
            {
                Id = Id * (int)EProductStatus.Delete;
                var pro2 = _db.Product.FirstOrDefault(x => x.Id == Id);
                pro2.Status = (int)EProductStatus.Delete;
                _db.Product.Update(pro2);
            }
                      
            _db.SaveChanges();
            _db.Dispose();
            
        }
    }

    enum EProductStatus
    {
        Delete = -1,
        Block,
        Active
    }
}

// -1 : delete  , 0 = block , 1 unblock