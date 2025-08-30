using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop4
{
    public class Employee
    {
        // Properties
        public string Name { get; protected set; }
        public int Age { get; protected set; }

        // Constructor
        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Fields with different access modifiers
        internal string InternalField = "Internal Field";
        protected string ProtectedField = "Protected Field";
        protected internal string ProtectedInternalField = "Protected Internal Field";
        private protected string x = " inherited in the same assembly  only ";




        // Method
        public  void ShowData()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
