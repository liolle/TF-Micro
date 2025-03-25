using System.ComponentModel.DataAnnotations;

namespace Order.models;

public class OrderModel{
  public int Id {get;}
  public string ArticleName {get;set;} ="";
  public OrderModel(int id, string articleName)
  {
    Id = id;
    ArticleName = articleName;
  }
}

public class OrderM{
  public OrderM(string articleName)
  {
    ArticleName = articleName;
  }

  [Required]
  public string ArticleName {get;set;} ="";

  public bool AddNew(List<OrderModel> orders){
    Random rd = new();
    int id;
    do
    {
      id = rd.Next();
    } while (orders.Find(val=>val.Id == id) is not null);
    orders.Add(new OrderModel(id,ArticleName));
    return true;
  }
}
