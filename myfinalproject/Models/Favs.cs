using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myfinalproject.Models 
{
    public class Favs
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string path { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]

        public string c { get; set; }
        public string songname()
        {
            return this.name + " ";
        }
    }
}