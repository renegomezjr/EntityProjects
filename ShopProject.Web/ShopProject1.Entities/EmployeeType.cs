using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.Entities
{
    public class EmployeeType
    {
        [Key]
        public int Id { get; set; }

        public decimal Salary { get; set; }

        public int EmpId { get; set; }
        public string EmpType { get; set; }

    }
}
