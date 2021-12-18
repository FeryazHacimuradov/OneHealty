using System;
using System.ComponentModel.DataAnnotations;

namespace OneHealthy.Models
{
    public class Messagee
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string Subject { get; set; }

        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
