using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportWeb.Entity;

namespace SportWeb.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _iProductRepository;
        int PageSize = 4;
        public ProductController(IProductRepository iProductRepository)
        {
            _iProductRepository = iProductRepository;
        }

        public IActionResult List(int productPage = 1) => View(_iProductRepository.List.OrderBy(p => p.ProductID).Skip((productPage - 1) * PageSize).Take(PageSize));
        
        
        //public IActionResult List()
        //{
        //    return View(_iProductRepository.List);
        //}
        //Calling the View method like this (without specifying a view name) tells MVC to render the default view for the action method. Passing the collection of Product objects
        //from the repository to the View method provides the framework with the data with which to populate the Entity object in a strongly typed view.
    }
}