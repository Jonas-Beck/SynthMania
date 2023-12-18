using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SynthManiaAPI.Data;
using SynthManiaAPI.Models;

namespace SynthManiaAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : Controller
{

    private readonly SynthManiaContext SynthManiaContext;

    public ProductController(SynthManiaContext synthManiaContext)
    {
        SynthManiaContext = synthManiaContext;
    }

    // GET
    [EnableCors("AnyOrigin")]
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GeAllProducts()
    {
        var products = SynthManiaContext.Products.ToList();
        return Ok(products);
    }
}