using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Model
{
    [Table("Categorys")]
    public partial class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Slug { get; set; }
        public int Parentid { get; set; }
        public int Order { get; set; }
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
