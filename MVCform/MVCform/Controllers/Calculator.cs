using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCform.Controllers
{
    public class Calculator : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        // GET: Calculator/Details/5
        public int Add(int x,int y)
        {
            return x + y;
        }
       
    }
}
