using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPiano.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
    {
        new Product
        {
            Id = 1,
            Title = "One Lesson",
            Descrition = "A single half hour lesson",
            ImageUrl = "https://images.unsplash.com/photo-1571974599782-87624638275e?q=80&w=1931&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
            Price = 20.99m
        },
        new Product
        {
            Id = 2,
            Title = "Two Lessons",
            Descrition = "Two half hour lessons",
            ImageUrl = "https://images.unsplash.com/photo-1571974599782-87624638275e?q=80&w=1931&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
            Price = 30.99m
        },
        new Product
        {
            Id = 3,
            Title = "Three Lessons",
            Descrition = "Three half hour lessons",
            ImageUrl = "https://images.unsplash.com/photo-1571974599782-87624638275e?q=80&w=1931&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
            Price = 35.99m
        }
    };

        [HttpGet]

        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}
