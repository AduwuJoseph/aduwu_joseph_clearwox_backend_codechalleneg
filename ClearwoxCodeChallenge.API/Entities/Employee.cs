using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClearwoxCodeChallenge.API.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [StringLength(100)]
        [Required]
        public string FirstName { get; set; }
        [StringLength(100)]
        [Required]
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }

    }
}
