using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using MVNwin.Models;
using MVNwin.Modelscls;



 

namespace MVNwinControllers
{
    public class OrderController : Controller
    {
        private readonly RepositoryOrder _repositoryorder;



        public OrderController(RepositoryOrder repository)
        {
            _repositoryorder = repository;
        }
        // GET: OrderController
        public ActionResult Index()
        {


            List<int> orderIds = _repositoryorder.GetAllOrderId();
            OrderIdsViewModel idsViewModel = new OrderIdsViewModel(orderIds);




            return View(idsViewModel);
        }

        public ActionResult Details(int id)
        {
            Order order = _repositoryorder.FindOrderById(id); //need to have all the details in the db 
            List<OrderDetail> detail = _repositoryorder.FindOrderDetailByOrderId(id);
            ViewData["OrderDetail"] = detail;
            return View(order);
        }

        // GET: OrderController/Details/5
        //[HttpPost]
        //public ActionResult Details(RepositoryOrder orderRep)
        //{
        //    Order orders = order.FindOrderById(orderRep.SelectedId);
        //    return View(orders);
        //}




        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }



        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }



        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }



        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}