using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Model
{
    [Table("Orders")]
    public class Order
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int Userid { get; set; }
        [Required]
        [StringLength(155)]
        public DateTime? Createddate { get; set; }
        public DateTime? Exportdate { get; set; }
        public string Deliveryaddress { get; set; }
        [Required]
        public string Deliveryname { get; set; }
        [Required]
        public string Deliveryphone { get; set; }
        [Required]
        public string Deliveryemail { get; set; }
        [Required]
        public int? Updated_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int? Status { get; set; }

    }
}
