using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Model
{
    [Table("Products")]
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Catid { get; set; }
        public String Slug { get; set; }
        public string Img { get; set; }
        public string Detail { get; set; }
        public int Nunmber { get; set; }
        public float Price { get; set; }
        public float Pricesale { get; set; }
        public string Metakey { get; set; }
        [Required]
        [StringLength(155)]
        public string MetaDesc { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Updated_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int? Status { get; set; }



    }
}
