using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemoWithGenerics
{
    public class Employee:IComparable<Employee>
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public DateTime JoiningDate { get; set; }

        public int CompareTo(Employee? other)
        {
            return this.JoiningDate.CompareTo(other.JoiningDate);
        }
    }
}
