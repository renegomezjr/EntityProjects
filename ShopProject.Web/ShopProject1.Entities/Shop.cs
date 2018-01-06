using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopProject.Entities
{
    public class Shop
    {
        [Key]
        public int ShopId { get; set; }

        public string ShopName { get; set; }

        public string ShopAddress { get; set; }

        public string ShopTelephone { get; set; }
    }
}
