using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Model
{
    [Table("Topic")]
    public class Topic
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public String Slug { get; set; }
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
