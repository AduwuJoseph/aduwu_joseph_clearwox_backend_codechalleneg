using ClearwoxCodeChallenge.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.API.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();
        Employee GetEmployee(int id);
        IEnumerable<Employee> GetAllByDeptId(int id);
    }
}
