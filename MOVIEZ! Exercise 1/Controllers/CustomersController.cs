using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MOVIEZ_.Models;

namespace MOVIEZ_.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Marcus Fenix", street_address="342 Lancer Blvd.", city_address="Sera", state_address="UT", zip_address= 46461, phone_address=5465486897, email_address="grumblygear234@gmail.com"
                },
                new Customer { Id = 2, Name = "Donna Noble", street_address="Belmont Primary", city_address="Cardiff", state_address="UT", zip_address= 46462, phone_address=5485855753, email_address="dr.donna@live.com" }
            };
        }
    }
}
