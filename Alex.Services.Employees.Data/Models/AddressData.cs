using System;

namespace Alex.Services.Employees.Data.Models
{
    public class AddressData
    {
        public Guid Id { get; set; }

        public string CountryCode { get; set; }

        public string City { get; set; }
    }
}
