using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.ViewModels
{
    public class CarItemViewModel
    {
        public CarItemViewModel(int id, string brad, string model, decimal price)
        {
            Id = id;
            Brad = brad;
            Model = model;
            Price = price;
        }

        public int Id { get; set; }
        public string Brad { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}
