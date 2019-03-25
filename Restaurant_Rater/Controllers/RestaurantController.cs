using Restaurant_Rater.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurant_Rater.Controllers
{
    public class RestaurantController : Controller
    {
        private RestaurantDBContext db = new RestaurantDBContext();

        // GET: Restaurant
        public ActionResult Index()
        {
            return View(db.Restaurants.ToList());
        }
    }
}