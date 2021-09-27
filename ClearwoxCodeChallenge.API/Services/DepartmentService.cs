using ClearwoxCodeChallenge.API.Entities;
using ClearwoxCodeChallenge.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.API.Services
{
    public class DepartmentService : IDepartmentService
    {
        List<Department> departments = new List<Department>
        {
            new Department{
                Id = 1,
                Name ="Administration",
            },
            new Department{
                Id = 2,
                Name = "ICT"
            }
        };

        public IEnumerable<Department> GetAllDepartments()
        {
            return departments;
        }

        public Department GetDepartment(int id)
        {
            return departments.Where(m => m.Id == id).FirstOrDefault();
        }

        public IList<Department> ListAllDepartments()
        {
            return departments;
        }

    }
}
