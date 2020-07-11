using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ajax_Crud.Models;
using Ajax_Crud.Service;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

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

        [HttpPost]
        public PartialViewResult _ListProduct(string Keyword, int Top,int Page)
        {
            var totalRow = 0;
            var totalPage = 0;
            if (Keyword == null)
            {
                Keyword = string.Empty;
            }
            var product = _productService.ListProduct(Keyword,Top,Page);
            
            if (product.Any()) {
                totalRow = product.FirstOrDefault().TotalRow;
                totalPage = (int)Math.Ceiling((float)totalRow / Top);
            }

            ViewBag.page = Page;
            ViewBag.totalPage = totalPage;
            ViewBag.totalRow = totalRow;

            return PartialView(product);
        }

        [HttpPost]
        public JsonResult AddOrUpdate(Product product)
        {
            try
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
                    return Json(new { Code = 1, Message = "Lỗi gì" });
                }
            }
            catch (Exception ex)
            {

                return Json(new { Code = -1, Message = ex });
            }
           
        } 
        
        [HttpPost]
        public JsonResult DeleteProduct(int id)
        {
            _productService.Delete(id);
            return Json("Delete Product Success");
        }


       
    }
}
