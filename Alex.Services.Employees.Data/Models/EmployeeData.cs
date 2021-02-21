using System;

namespace Alex.Services.Employees.Data.Models
{
    public class EmployeeData
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal Salary { get; set; }

        public AddressData Address { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
