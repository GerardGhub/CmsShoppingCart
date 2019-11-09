using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CmsShoppingCart.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace CmsShoppingCart.Controllers
{
    public class CartController : Controller
    {
        private readonly CmsShoppingCartContext context;

        public CartController(CmsShoppingCartContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}