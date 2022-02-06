﻿using CityBusManagement.DAL.Repository;
using CityBusManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityBusManagement.BAL.services
{
    public class EmployeeService
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void AddEmployeeDetails(Employee employeedetails)
        {
            _employeeRepository.AddEmployeeDetails(employeedetails);
        }
        public void DeleteEmployeeDetails(int empNo)
        {
            _employeeRepository.DeleteEmployeeDetails(empNo);
        }
        public void UpdateEmployeeDetails(Employee employeedetails)
        {
            _employeeRepository.UpdateEmployeeDetails(employeedetails);
        }
        public void GetEmployeeNo(int empNo)
        {
            _employeeRepository.GetEmployeeNo(empNo);
        }
        public IEnumerable<Employee> GetEmployeeDetails()
        {
            return _employeeRepository.GetEmployeeDetails().ToList();
        }
    }
}
