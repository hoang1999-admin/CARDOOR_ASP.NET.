using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Model
{
    [Table("Contacts")]
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Replaydetail { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Updated_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int? Status { get; set; }

    }
}
