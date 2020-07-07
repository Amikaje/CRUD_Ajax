using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ajax_Crud.Models;
using Ajax_Crud.Service;
using Microsoft.AspNetCore.Mvc;

namespace Ajax_Crud.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult ListProductPartial()
        {
           var product = _productService.ListProduct();
            return PartialView(product);
        }

        [HttpPost]
        public JsonResult AddOrUpdate(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.id == 0)
                {
                    _productService.Add(product);
                }
                else
                {
                    _productService.Update(product);
                }
                return Json(product);
            }
            else
            {

                return Json("Fail");
            }
           
        } 
        
        [HttpPost]
        public JsonResult DeleteProduct(int id)
        {
            _productService.Delete(id);
            return Json("Success");
        }
    }
}
