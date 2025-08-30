using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oop4
{
    internal class Manager : Employee  // Inheritance
    {
        public string Department { get; set; }

        public Manager(string name, int age, string department)
            : base(name, age)
        {
            Department = department;
        }

        // Hide ShowData (Bonus Part)
        public new void ShowData()
        {
            Console.WriteLine($"[Manager] Name: {Name}, Age: {Age}, Department: {Department}");

          
            //base.ShowData();

              
        }
    }
}
