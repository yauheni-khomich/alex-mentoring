using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alex.WebApi.Employees.Models
{
    public class CreateEmployeeRequestDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal Salary { get; set; }

        public AddressDto Address { get; set; }
    }
}
