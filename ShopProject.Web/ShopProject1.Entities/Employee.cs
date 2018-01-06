using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ShopProject.Entities
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string EmpPhoneNumber { get; set; }

        public string EmpAddress { get; set; }

        public DateTime EmploymentDate { get; set; }

        public string EmpType { get; set; }
    }
}
