using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemoWithGenerics
{
    public class Orders
    {
        public int OrderID { get; set; }
        public DateOnly OrderDate { get; set; }

        public Customer CustomerDetails { get; set; }

        public List<Products> MyCart { get; set; }
    }
}
