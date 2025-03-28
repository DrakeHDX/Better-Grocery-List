using Microsoft.AspNetCore.Mvc;
using MyAPI.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroceryController : ControllerBase
    {
        private static readonly List<Grocery> _grocery = Grocery.GetItems();
        private readonly ILogger _logger;

        public GroceryController(ILogger<Grocery> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetGroceryList")]
        public IEnumerable Get() => Grocery.GetItems();
    }
}
