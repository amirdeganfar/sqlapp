using AutoFixture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using sqlapp.Models;
using sqlapp.Services;

namespace sqlapp.Pages
{
    public class IndexModel : PageModel
    {
        public IProductService _productService;
        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }
        public List<Product> Products; 
        public void OnGet()
        {
            //Products= _productService.GetProducts();
            var fixture = new Fixture();
           Products= fixture.CreateMany<Product>(20).ToList();
        }
    }
}