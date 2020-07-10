using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax_Crud.Models
{
    public class ProductViewModel
    {
        public int id { get; set; }

        public string name { get; set; }

        public int price { get; set; }

        public int quantity { get; set; }

        public bool status { get; set; }

        public int TotalRow { get; set; }
    }
}
