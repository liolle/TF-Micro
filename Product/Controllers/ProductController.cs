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

  [HttpGet("{id}")]
  [Route("/product/{id}")]
  public IActionResult GetById(int id)
  {
    return Ok($"You seleceted the product {id}");
  }

}
