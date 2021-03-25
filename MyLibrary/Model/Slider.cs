using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Model
{
    [Table("Sliders")]
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(155)]
        public string Name { get; set; }
        public string Link { get; set; }
        public string Position { get; set; }
        public string Img { get; set; }
        public int Order { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Updated_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int? Status { get; set; }
    }
}
