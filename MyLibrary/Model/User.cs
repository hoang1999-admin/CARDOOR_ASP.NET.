using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyLibrary.Model
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Fullname { get; set; }
        [Required]
        [StringLength(100)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Gender { get; set; }
        public int Phone { get; set; }
        public string Img { get; set; }
        public int Access { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Updated_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int? Status { get; set; }
    }
}
