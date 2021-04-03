using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerViewModel(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }

        public int Id { get; set; }
        public string FullName { get; set; }
    }
}
