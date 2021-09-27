using ClearwoxCodeChallenge.API.Entities;
using ClearwoxCodeChallenge.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee{
                EmployeeId = 1,
                DeptId = 2,
                FirstName ="John",
                LastName = "Doe",
                Address = "Ona Crescent Maitama",
                JobTitle = "Senior Developer"
            },
            new Employee{
                EmployeeId = 2,
                DeptId = 1,
                FirstName ="Lucy",
                LastName = "Doe",
                Address = "Ona Crescent Maitama",
                JobTitle = "HRM Manager"
            },
            new Employee{
                EmployeeId = 3,
                DeptId = 2,
                FirstName ="Mark",
                LastName = "Jack",
                Address = "FH Lugbe, Abuja",
                JobTitle = "Database Administrator"
            },
            new Employee{
                EmployeeId = 4,
                DeptId = 2,
                FirstName ="Smith",
                LastName = "Casidy",
                Address = "Area 11, Garki Abuja",
                JobTitle = "Front-end Developer"
            }
        };
        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public IEnumerable<Employee> GetAllByDeptId(int id)
        {
            return employees.Where(m => m.DeptId == id);
        }

        public Employee GetEmployee(int id)
        {
            var emp = employees.Where(m => m.EmployeeId == id).FirstOrDefault();
            return emp;
        }

        public IList<Employee> ListAll()
        {
            return employees;
        }
    }
}
