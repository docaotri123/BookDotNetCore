﻿using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product[] productArray =
            {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            Func<Product, bool> nameFilter = delegate (Product prod) {
                return prod?.Name?[0] == 'S';
            };
            decimal priceFilterTotal = productArray
                .Filter(x => (x?.Price ?? 0) >=20)
                .TotalPrices(); 
            decimal nameFilterTotal = productArray
                .Filter(p => p?.Name?[0] == 'S')
                .TotalPrices();
            return View("Index", new string[] {
                        $"Price Total: {priceFilterTotal:C2}",
                        $"Name Total: {nameFilterTotal:C2}" }
            );
        }
    }
}
