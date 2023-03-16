using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mission09_nj236.Models;

namespace mission09_nj236.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent (Basket bservice)
        {
            basket = bservice;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
