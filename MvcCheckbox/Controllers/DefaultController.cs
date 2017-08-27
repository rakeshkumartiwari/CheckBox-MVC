using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCheckbox.Models;
using System.Text;

namespace MvcCheckbox.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [HttpGet]
        public ActionResult Index()
        {
            var model = Class1.GetUser();
            return View(model);
        }

        [HttpPost]
        public string Index(Class1 obj)
        {

            StringBuilder sb = new StringBuilder();

            if (obj.IsMonday || obj.IsTuesday || obj.IsWednesday || obj.IsThrusday || obj.IsFriday || obj.IsSaturday || obj.IsSunday)
            {
                sb.Append("You selected - ");
                if (obj.IsMonday)
                    sb.Append("Monday" + ",");
                if (obj.IsTuesday)
                    sb.Append("Tuesday" + ",");
                if (obj.IsWednesday)
                    sb.Append("Wednesday" + ",");
                if (obj.IsThrusday)
                    sb.Append("Thrusday" + ",");
                if (obj.IsFriday)
                    sb.Append("Friday" + ",");
                if (obj.IsSaturday)
                    sb.Append("Saturday" + ",");
                if (obj.IsSunday)
                    sb.Append("Sunday" + ",");

                sb.Remove(sb.ToString().LastIndexOf(","), 1);
            }
            else
            {
                sb.Append("You didn't select any day.");
            }



            return sb.ToString();
        }
    }

}