using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ajax_Crud.Models
{
    public partial class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Column("price")]
        public int Price { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("status")]
        public short Status { get; set; }
        [Column("createdate", TypeName = "datetime")]
        public DateTime Createdate { get; set; }
    }
}
