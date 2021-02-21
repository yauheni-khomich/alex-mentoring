using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alex.WebApi.Employees.Models
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }

        public string DisplayName { get; set; } // should be FirstName and LastName separated by space.

        public DateTime BirthDate { get; set; }

        public AddressDto Address { get; set; }
    }
}
