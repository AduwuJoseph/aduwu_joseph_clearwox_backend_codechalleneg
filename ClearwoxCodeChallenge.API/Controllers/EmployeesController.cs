using ClearwoxCodeChallenge.API.Entities;
using ClearwoxCodeChallenge.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClearwoxCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;

        private readonly IEmployeeService _employeeService;
        private readonly IDepartmentService _departmentService;
        public EmployeesController(
            ILogger<EmployeesController> logger,
            IEmployeeService employeeService,
            IDepartmentService departmentService)
        {
            _logger = logger;
            _employeeService = employeeService;
            _departmentService = departmentService;
        }
        #region Employees End point
        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeService.GetAll();
        }
        [HttpGet]
        [Route("GetEmployeeByDepartment/{id}")]
        public IList<Employee> GetEmployeeByDepartment(int id)
        {
            return _employeeService.GetAllByDeptId(id).ToList();
        }
        [HttpGet]
        [Route("GetEmployee/{id}")]
        public Employee GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }
        #endregion

        #region Department End point

        // GET api/<EmployeesController>/5
        [HttpGet]
        [Route("Department/{id}")]
        public Department GetDepartment(int id)
        {
            return _departmentService.GetDepartment(id);
        }
        [HttpGet]
        [Route("GetAllDepartments")]
        public IList<Department> GetAllDepartments()
        {
            return _departmentService.ListAllDepartments();
        }
        #endregion
    }
}
