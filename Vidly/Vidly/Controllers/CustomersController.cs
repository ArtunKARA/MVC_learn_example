using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private IEnumerable<Customer> GetCustomers()
        {
           return new List<Customer>
            {
                new Customer {Name = "Artun KARA",id = 1},
                new Customer {Name = "Artyom BLACK", id = 2}
            };
        }
        
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.id == id);
            return View(customer);
        }
    }
}