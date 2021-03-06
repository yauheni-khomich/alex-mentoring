﻿using System;

namespace Alex.Services.Employees.Contracts.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal Salary { get; set; }

        public Address Address { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
