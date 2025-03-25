using Order.models;

namespace Order.services;

public interface IOrderService 
{
  bool Create(OrderM order);
  List<OrderModel> GetAll();
  bool Update(OrderModel order);
  bool Delete(int id);
}

public partial class OrderService : IOrderService{}

public partial class OrderService 
{
  List<OrderModel> orders = [];

  public bool Create(OrderM order)
  {
    return order.AddNew(orders);
  }

  public bool Delete(int id)
  {
    orders.RemoveAll(val=>val.Id == id);
    return true;
  }

  public List<OrderModel> GetAll()
  {
    return orders;
  }

  public bool Update(OrderModel order)
  {
    OrderModel? od = orders.Find(val=>val.Id == order.Id);
    if (od is null ){return false;}
    od.ArticleName = order.ArticleName;
    return true;
  }
}
