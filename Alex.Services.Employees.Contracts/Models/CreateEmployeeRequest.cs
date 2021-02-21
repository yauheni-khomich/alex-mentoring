using System;

namespace Alex.Services.Employees.Contracts.Models
{
    public class CreateEmployeeRequest
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal Salary { get; set; }

        public Address Address { get; set; }
    }
}
