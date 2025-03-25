using Microsoft.AspNetCore.Mvc;
using Order.models;
using Order.services;

namespace Order.controller;

public class OrderController (IOrderService orderService): ControllerBase {

  [HttpGet]
  [Route("/order/all")]
  public IActionResult GetAll()
  {
    return Ok(orderService.GetAll());
  }


  [HttpPost]
  [Route("/order/add")]
  public IActionResult Add([FromBody] OrderM model)
  {
    if (!ModelState.IsValid){
      return BadRequest("Invalid model");
    }
    return Ok(orderService.Create(model));
  }


  [HttpDelete]
  [Route("/order/delete")]
  public IActionResult Delete([FromQuery] int id)
  {
    return Ok(orderService.Delete(id));
  }



  [HttpPatch]
  [Route("/order/update")]
  public IActionResult Update([FromBody] OrderModel model)
  {
    return Ok(orderService.Update(model));
  }

}
