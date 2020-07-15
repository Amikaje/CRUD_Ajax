using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax_Crud.Models
{
    public class ObjectProduct
    {
        public string Keyword { get; set; }
        public int Top { get; set; }
        public int Page { get; set; }
        public int Status { get; set; }
        public DateTime? FirstDate { get; set; }
        public DateTime? LastDate { get; set; }
    }
}
