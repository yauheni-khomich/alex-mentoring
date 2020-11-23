using System;
using System.Collections.Generic;
using System.Text;
using Alex.Services.Employees.Data.Mappers.MapperProfiles;
using AutoMapper;

namespace Alex.Services.Employees.Data.Mappers
{
    public static class EmployeeMapperFactory
    {
        private static readonly IMapper Mapper;

        static EmployeeMapperFactory()
        {
            var mapperConfiguration = new MapperConfiguration(config =>
            {
                config.AddProfile<EmployeeProfile>();
            });

            mapperConfiguration.AssertConfigurationIsValid();
            Mapper = mapperConfiguration.CreateMapper();
        }

        public static IMapper Create()
        {
            return Mapper;
        }
    }
}
