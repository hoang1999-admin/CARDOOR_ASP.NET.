using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Model
{
    [Table("Menus")]
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Type { get; set; }
        public int Tableid { get; set; }
        public int Orders { get; set; }
        public string Position { get; set; }
        public int Parentid { get; set; }
        [Required]
        [StringLength(155)]
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Updated_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int? Status { get; set; }
    }
}
