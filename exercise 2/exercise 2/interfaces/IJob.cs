using exercise_2.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2.interfaces
{
    internal interface IJob
    {
        public void AddJob(Job job);

        public Job[] GetJob(); 
    }
}
