using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Model
{
    [Table("Orderdetails")]
    public class Orderdetail
    {
        public int Id { get; set; }
        public int Orderid { get; set; }
        [Required]
        [StringLength(155)]
        public int Productid { get; set; }
        [Required]

        public float Price { get; set; }
        public int Quantity { get; set; }
        public float Amount { get; set; }
    }
}
