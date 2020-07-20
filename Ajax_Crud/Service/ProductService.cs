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
            try
            {
                return _db.ProductViewModel.FromSqlRaw("SP_GetProductsByFilter @p0, @p1, @p2, @p3, @p4, @p5",
                objectProduct.Keyword, objectProduct.Top, objectProduct.Page, objectProduct.Status, objectProduct.FirstDate, objectProduct.LastDate).ToList();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            
        }

        public bool AddOrUpdate(Product product)
        {
            try
            {
                if(product.Id == 0)
                {
                    if (_db.Product.Any(x => x.Name.ToLower().Equals(product.Name.ToLower())))
                    {
                        return false;
                    }
                    product.Status = 1;
                    product.Createdate = DateTime.Now;
                    _db.Product.Add(product);
                }
                else
                {
                    var pro = _db.Product.FirstOrDefault(x => x.Id == product.Id);
                    if (_db.Product.Any(x => x.Name.ToLower().Equals(product.Name.ToLower()) && pro.Name != product.Name ))
                    {
                        return false;
                    }                 
                    pro.Name = product.Name;
                    pro.Price = product.Price;
                    pro.Quantity = product.Quantity;
                    _db.Product.Update(pro);
                }
                _db.SaveChanges();
                _db.Dispose();
                return true;
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }
        public void ActiveStatus(int Id, EProductStatus eProductStatus)
        {
            try
            {
                var pro = _db.Product.FirstOrDefault(x => x.Id == Id);
                pro.Status = (short)eProductStatus;
                _db.Product.Update(pro);
                _db.SaveChanges();
                _db.Dispose();
            }
            catch(Exception ex)
            {
                throw (ex);
            }
        }
    }
}