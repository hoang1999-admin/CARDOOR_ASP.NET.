using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Model
{
    [Table("Links   ")]
    public class Link
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Title { get; set; }
        public int Access { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Updated_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int? Status { get; set; }
    }
}
