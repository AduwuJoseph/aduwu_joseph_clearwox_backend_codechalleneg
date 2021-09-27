using ClearwoxCodeChallenge.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.API.Interfaces
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetAllDepartments();
        IList<Department> ListAllDepartments();
        Department GetDepartment(int id);
    }
}
