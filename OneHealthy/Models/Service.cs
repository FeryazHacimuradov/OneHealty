using System;
using System.ComponentModel.DataAnnotations;

namespace OneHealthy.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
    }
}
