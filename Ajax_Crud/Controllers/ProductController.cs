using System;
using System.Collections.Generic;
using System.Globalization;
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

        [HttpPost]
        public PartialViewResult _ListProduct(ObjectProduct objectProduct)
        {
            // khi load Keyword = null
            if (objectProduct.Keyword == null)
            {
                objectProduct.Keyword = string.Empty;
            }

            var product = _productService.ListProduct(objectProduct);
            var totalRow = 0;
            var totalPage = 0;

            if (product.Any()) {
                totalRow = product.FirstOrDefault().TotalRow;
                totalPage = (int)Math.Ceiling((float)totalRow / objectProduct.Top);
            }
             
            ViewBag.page = objectProduct.Page;
            ViewBag.totalPage = totalPage;
            ViewBag.totalRow = totalRow;

            return PartialView(product);
        }

        [HttpPost]
        public JsonResult AddOrUpdate(Product product)
        {
            try
            {
                if (_productService.AddOrUpdate(product) == false)
                {
                    return Json(new {Code = 1, Message = "Tên không được trùng"});
                }
                 return Json(product);
            }
            catch (Exception ex)
            {

                return Json(new { Code = -1, Message = ex });
            }
        }

        [HttpPost]
        public JsonResult ActiveStatus(int Id, EProductStatus eProductStatus)
        {
            try
            {
                _productService.ActiveStatus(Id, eProductStatus);
                return Json(new { Code = 1, Message = "Success" });
            }
            catch
            {
                return Json(new { Code = 0, Message = "Error" });
            }
        } 
    }
}
