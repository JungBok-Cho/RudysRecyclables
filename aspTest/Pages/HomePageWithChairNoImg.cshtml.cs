﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspTest.Models;
using aspTest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RudysRecyclables.Pages
{
    /// <summary>
    /// The HomePageWithChairNoImgModel Page
    /// </summary>
    public class HomePageWithChairNoImgModel : PageModel
    {
        // local Logger reference
        private readonly ILogger<HomePageWithChairNoImgModel> _logger;

        // The product service reference
        public JsonFileProductService ProductService;

        // The list of products
        public IEnumerable<Product> Products { get; private set; }

        /// <summary>
        /// Constructor
        /// Injecting the Logger
        /// Injecting the Product Service service
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="productService"></param>
        public HomePageWithChairNoImgModel(ILogger<HomePageWithChairNoImgModel> logger, JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        /// <summary>
        /// Get for the Index page
        /// 
        /// Returns all the products for reviewing
        /// </summary>
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}