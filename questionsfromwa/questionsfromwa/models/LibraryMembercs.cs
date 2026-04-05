using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionsfromwa.models
{
    public abstract class LibraryMembercs
    {
        public int MemberId;
        public string Name;


        public void CalculateFine(int overdueDays)
        { }
      

        public LibraryMembercs(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }

    }


    public class StudentMember : LibraryMembercs
    {
        public string Course;
        public StudentMember(int memberId, string name)
            : base(memberId, name)
        {

        }
        public new void CalculateFine(int overdueDays)
        {
            decimal fineAmount = overdueDays * 1m; 
            Console.WriteLine($"Fine for Student {Name} (ID: {MemberId}) is ${fineAmount}");
        }
    }

    public class FacultyMember : LibraryMembercs
    {
        public string Department;
        public FacultyMember(int memberId, string name)
            : base(memberId, name)
        {
            
        }
        public new void CalculateFine(int overdueDays)
        {
            decimal fineAmount = overdueDays * 0.5m; 
            Console.WriteLine($"Fine for Faculty {Name} (ID: {MemberId}) is ${fineAmount}");
        }
    }
}
