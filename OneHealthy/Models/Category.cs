using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OneHealthy.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
