using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dayy3
{
    public class Employ
    {
        public int emplyid { get; set; }
        public string emplyname { get; set; }


        public Employ(int emplyid, string emplyname)
        {
            this.emplyid = emplyid;
            this.emplyname = emplyname; 
        }
        public void display()
        {
            Console.WriteLine("details:");
            Console.WriteLine($"employee id  is : {emplyid} , employee name is : {emplyname}");
        }
        
        
    }
}
