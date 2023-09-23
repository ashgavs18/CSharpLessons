using Microsoft.AspNetCore.Mvc.Rendering;
using MVNwin.Modelscls;



using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MVNwin.Models

{


    public class RepositoryOrder
    {
        private NorthwindContext _context;
        public RepositoryOrder(NorthwindContext context)
        {
            _context = context;
        }
        public List<int> GetAllOrderId()
        {
            List<int> orderIds = new List<int>();
            foreach (var order in _context.Orders)
            {
                orderIds.Add(order.OrderId);
            }
            return orderIds;
        }
        public List<OrderDetail> FindOrderDetailByOrderId(int id)
        {
            //Order order = _context.Orders.Find(id);
            //return order.OrderDetails.ToList(); //for every single order there are order details
            //                                    //using order object we will fetch order based on the object

            List<Order> orderWithOrderDetails =
              _context.Orders.Include(d => d.OrderDetails).ToList();
            Order order = orderWithOrderDetails.FirstOrDefault(x => x.OrderId == id);
            return order.OrderDetails.ToList();

        }

        public Order FindOrderById(int id)
        {
            var order = _context.Orders.Find(id);
            return order;
        }
       

    }

}
