using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace codefistactivity1.models
{
    public class mark
    {
        [Key]
        public int markid { get; set; }

        [ForeignKey("student")]

        public int stdudentid { get; set; }

        public students students { get; set; }

        public int m1 { get; set; }
        public int m2 { get; set; }
        public int m3 { get; set; }



    }
}
