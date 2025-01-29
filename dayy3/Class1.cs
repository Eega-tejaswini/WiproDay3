using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dayy3
{
    class Student

    {
        int studid;
        string studname;
        int studmarks;

    
    public Student(int sdid, string sdname, int sdmarks)
        {
            studid = sdid;
            studname = sdname;
            studmarks = sdmarks;
        }
        private void SampleMthd()
        {
            Console.WriteLine("Private Method");
        }
        public void display()
        {
            Console.WriteLine("display student details:" + studid + " " + studname + " " + studmarks); 
        }
    }

}
