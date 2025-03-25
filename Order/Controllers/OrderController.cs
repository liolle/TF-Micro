using Microsoft.AspNetCore.Mvc;

namespace Order.controller;

public class OrderController: ControllerBase {

  [HttpGet]
  [Route("/order/all")]
  public IActionResult GetAll()
  {
    return Ok("Order List");
  }
}
