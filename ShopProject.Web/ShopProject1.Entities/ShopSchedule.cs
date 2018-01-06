using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ShopProject.Entities
{
    public class ShopSchedule
    {
        [Key]
        public int ShopScheduleId { get; set; }
        public DateTime ScheduleOpen { get; set; }
        public DateTime ScheduleClose { get; set; }

        public Employee EmpId { get; set; }
        public Employee EmpName { get; set; }
        public Employee EmpPhoneNumber { get; set; }
        public Shop ShopId { get; set; }
        public Shop ShopName { get; set; }

    }
}
