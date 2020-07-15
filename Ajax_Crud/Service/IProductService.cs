using Ajax_Crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax_Crud.Service
{
    public interface IProductService
    {
        List<ProductViewModel> ListProduct(ObjectProduct objectProduct);
        void Add(Product product);
        void Update(Product product);
        void ActiveStatus(int Id);
    }
}
