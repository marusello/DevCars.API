using DevCars.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Persistence
{
    public class DevCarsDbContext
    {
        public DevCarsDbContext()
        {
            Cars = new List<Car>
            {
                new Car(1, "123ABC", "HONDA", "CIVIC", 2021, 10000, "Cinza", new DateTime(2021, 1, 1)),
                new Car(2, "123CDF", "TOYOTA", "COROLLA", 2021, 100000, "Amarelo", new DateTime(2021, 1, 2)),
                new Car(3, "456CDF", "CHEVROLET", "CELTA", 2007, 13000, "Prata", new DateTime(2021, 1, 1)),
            };

            Customers = new List<Customer>
            {
                new Customer(1, "Marcelo Augusto", "409380799", new DateTime(1993, 09, 17)),
                new Customer(2, "Emerson Lima", "409385689", new DateTime(1994, 12, 20)),
                new Customer(3, "Everton Adriel", "458380799", new DateTime(1995, 01, 06)),
            };
        }

        public List<Car> Cars { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
