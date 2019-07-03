using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace finhelp_back.Models.Categories
{
    public class Categories
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string description { get; set; }
        [Required]
        public bool status { get; set; }
    }
}
