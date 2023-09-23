﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCform.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PartialViewController/Details/5
        public ActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are Good Friends";
            return View();
        }
        
    }
}
