using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDemoWithGenerics
{
    public class Jewellery
    {
        public int OrnamentID { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public string MetalName { get; set; }
    }


    public class JewelleryDetails
    {
        public List<Jewellery> Jewelleries { get; set; }


    }
}
