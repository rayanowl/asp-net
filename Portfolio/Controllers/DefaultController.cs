using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Portfolio.Controllers
{

    public class DefaultController : Controller
    {

        // GET: Default

        public ActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public ActionResult About()
        {
            return View();
        }

        [Route("experience")]
        public ActionResult Experience()
        {
            return View();
        }
        [Route("projects")]
        public ActionResult Projects()
        {
            return View();
        }

        [Route("other")]
        public ActionResult Other()
        {
            return View();
        }

        [Route("other/postman")]
        public ActionResult Project1()
        {
            return View();
        }

        [Route("other/pendulum")]
        public ActionResult Project2()
        {
            return View();
        }

        [Route("other/flower")]
        public ActionResult Project3()
        {
            return View();
        }

        [Route("other/dots")]
        public ActionResult Project4()
        {
            return View();
        }
        [Route("other/snowflake")]
        public ActionResult Project5()
        {
            return View();
        }
        [Route("other/space-flowers")]
        public ActionResult Project6()
        {
            return View();
        }
        [Route("other/sunsetrise")]
        public ActionResult Project7()
        {
            return View();
        }
        [Route("other/wind-mill")]
        public ActionResult Project8()
        {
            return View();
        }

    }
}