using Microsoft.AspNetCore.Mvc;
namespace Product.controller;

public class ProductController : ControllerBase 
{

  [HttpGet]
  [Route("/product/all")]
  public IActionResult GetAll()
  {
    return Ok("Product list");
  }
}
