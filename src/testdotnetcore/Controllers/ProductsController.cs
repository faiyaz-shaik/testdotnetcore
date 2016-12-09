using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testdotnetcore.Business;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace testdotnetcore.Controllers
{
    public class ProductsController : Controller
    {
        ProductsViewModel prodsvm = new ProductsViewModel();

        // GET: /<controller>/
        public IActionResult Index()
        {
            

            prodsvm.AddProduct(new Product { Name = "Product 1" });
            prodsvm.AddProduct(new Product { Name = "Product 2" });
            prodsvm.AddProduct(new Product { Name = "Product 3" });

           
            return View(prodsvm);
        }

        public IActionResult Add()
        {
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Save(Product model)
        {
            if (ModelState.IsValid) {
                
                prodsvm.AddProduct(new Product { Name = model.Name });

            }

            return RedirectToAction("Index");
        

        }

    }
}
