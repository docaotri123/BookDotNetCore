﻿using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;
using System.Linq;

namespace SportsStore.Controllers
{
    public class ProductController: Controller
    {
        private readonly IProductRepository repository;
        public int PageSize = 2;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category,int productPage = 1) 
            => View(new ProductsListViewModel
            {
            Products = repository.Products
            .Where(p => p.Category == null || p.Category == category)
            .OrderBy(p => p.ProductID)
            .Skip((productPage - 1) * PageSize)
            .Take(PageSize),

            PagingInfo = new PagingInfo {
            CurrentPage = productPage,
            ItemsPerPage = PageSize,
            TotalItems = category == null ?
                repository.Products.Count() :
                repository.Products.Where(e =>
                e.Category == category).Count()
            },
            CurrentCategory = category
        });
    }
}
