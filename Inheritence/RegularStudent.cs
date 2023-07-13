using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class RegularStudent : Student  
    {
        public string attendace;

       
        public RegularStudent(string attendace)
        {
            this.attendace = attendace;
        }

        public void TodaysAttendance()
        {
            Console.WriteLine($"Attendance: {attendace}");
        }
    }
}
