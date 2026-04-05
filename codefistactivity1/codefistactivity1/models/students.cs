using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace codefistactivity1.models
{
    public class students
    {

        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string mobileno { get; set; }

        public ICollection<mark> marks { get; set; } = new List<mark>();









    }
}
