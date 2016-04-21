using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloMVC.Models
{
    public class HelloModel
    {
        public static List<Car> GetCars()
        {
            List<Car> cars = new List<Car>
            {
                new Car { ID = 1, Make = "Toyota", Model = "Camery" },
                new Car { ID = 2, Make = "Honda", Model = "Cilantra"},
                new Car { ID = 3, Make = "Nissan", Model = "Altima"}
            };
            return cars;
        }
    }

    public class Car
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}