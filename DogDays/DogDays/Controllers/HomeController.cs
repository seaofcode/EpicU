using Dapper;
using DogDays.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogDays.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection Conn = new SqlConnection("Server=localhost;Database=Example;Trusted_Connection=True;");

        // GET: Home
        public ActionResult Index()
        {
            var list = Conn.Query<Dog>("Select DogID, DogName from Table_1");
            return View(list);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && Conn != null)
            {
                Conn.Dispose();
                Conn = null;

            }

            base.Dispose(disposing);
        }
    }
}