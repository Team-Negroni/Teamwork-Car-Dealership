﻿using Dealership.DataSeed.Contracts;

namespace Dealership.DataSeed.Seeders
{
    public class EmployeeSeedUtil
    {
        private readonly IEmployeeReader employeeReader;

        private readonly IEmployeeSeeder employeeSeeder;

        public EmployeeSeedUtil(IEmployeeReader employeeReader, IEmployeeSeeder employeeSeeder)
        {
            this.employeeReader = employeeReader;
            this.employeeSeeder = employeeSeeder;
        }

        public void Seed()
        {
            var isDataSeeded = employeeSeeder.IsDataSeeded();
            if (!isDataSeeded)
            {
                var employees = this.employeeReader.ReadEmployees();

                this.employeeSeeder.Seed(employees);
            }
        }
    }
}
