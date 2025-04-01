namespace LibraryDemoWithGenerics
{
    public class Customer
    {
        //used for validation of data, as well as setting and getting the data

        int _custid;
        public int CustID 
        {
            get { return _custid; }
            set 
            {
                if ((value > 0) && (!string.IsNullOrEmpty(value.ToString())))
                {
                    _custid = value;
                }
                else
                {
                    Console.WriteLine("Enter a valid customer id....");
                
                }
            } 
        }
        public string CustName { get; set; }
        public int Rating { get; set; }
        public string City { get; set; }
    }

    public class CustomerIDComparer : IComparer<Customer>
    {
      

        public int Compare(Customer? x,Customer y)
        {
            return x.CustID.CompareTo(y.CustID);
        }
    }

    public class CompareNames : IComparer<Customer>
    {
        public int Compare(Customer? x, Customer? y)
        {
            return x.CustName.CompareTo(y.CustName);
        }
    }


}
