using Ajax_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax_Crud.Service
{
    public interface IProductService
    {
        List<Product> ListProduct();
       // Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
      

    }
}
