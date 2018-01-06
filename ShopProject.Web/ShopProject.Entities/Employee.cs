using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public DateTime EmploymentDate { get; set; }
    }
}
