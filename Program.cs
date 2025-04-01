
using LibraryDemoWithGenerics;

internal class Program
{
    private static void Main(string[] args)
    {
        //WorkingWithGenericSimpleDataTypes();

        //WorkingWithList();

        //WorkingWithSortedSet();

        //WorkingWithStack();

        Queue<Orders> queue = new Queue<Orders>();
        
        Orders o1=new Orders();
        o1.OrderID = 101;
        o1.OrderDate = new DateOnly(2025, 04, 01);
        o1.CustomerDetails = new Customer { CustID = 1, CustName = "Hari", City = "Pune", Rating = 5 };

        List<Products> products = new List<Products>() 
        { 
            new Products {ProductID=1,ProdName="Chai",Price=10,Qty=1,UnitOfMeasurement="PerNo"},
            new Products{ ProductID=3,ProdName="Coffee",Price=30,Qty=2,UnitOfMeasurement="PerNo"},
            new Products{ ProductID=11,ProdName="Cold Coffee",Price=50,Qty=2,UnitOfMeasurement="PerNo"}

        };
        o1.MyCart=products;
        queue.Enqueue(o1);

        Orders o2 = new Orders
        {
            OrderID = 2,
            OrderDate = new DateOnly(2025, 03, 31),
            CustomerDetails = new Customer { CustID = 12, CustName = "Harish", City = "Bangalore", Rating = 5 },
            MyCart = new List<Products>
            {
                new Products {ProductID=2,ProdName="Green Tea",Price=30,Qty=1,UnitOfMeasurement="PerNo"},
            new Products{ ProductID=4,ProdName="Hot Coffee",Price=30,Qty=2,UnitOfMeasurement="PerNo"},
            new Products{ ProductID=10,ProdName="Maggi",Price=50,Qty=2,UnitOfMeasurement="PerNo"}
            }


        }; ;
        queue.Enqueue(o2);  


        foreach (var item in queue)
        {
            Console.WriteLine($" OrderID=   {item.OrderID}   OrderDate=  { item.OrderDate}   Customer ID={item.CustomerDetails.CustID} CustomerName= {item.CustomerDetails.CustName}  City= {item.CustomerDetails.City} Rating= {item.CustomerDetails.Rating}");
            string s = string.Format("|{0,5} | {1,15}| {2,5} | {3,3}|{4,4}", "ProductID", "ProductName", "Price", "Qty", "Amt(Rs)");
            Console.WriteLine(s);
            foreach (var item1 in item.MyCart)
            {
                
                string s1 = string.Format("|{0,5} | {1,15}| {2,15} | {3,3}|{4,4}", item1.ProductID, item1.ProdName, item1.Price, item1.Qty, item1.Price * item1.Qty);
                Console.WriteLine(s1);
                //Console.WriteLine($"{item1.ProductID} {item1.ProdName} {item1.Price} {item1.Qty} {item1.UnitOfMeasurement} {item1.Price * item1.Qty}" ) ;
            }
            Console.WriteLine();
            
        }

    }

    private static void WorkingWithStack()
    {
        Stack<Customer> stack = new Stack<Customer>();
        stack.Push(new Customer { CustID = 4, CustName = "Amol", City = "Pune", Rating = 5 });//collection initializer

        Customer c = new Customer();
        c.CustID = 2;
        c.CustName = "Krishna";
        c.City = "Banglore";
        c.Rating = 5;
        stack.Push(c);

        Customer c1 = new Customer { CustID = 3, CustName = "Gauri", City = "Chennai", Rating = 4 }; //object initializer
        stack.Push(c1);

        Customer c2 = new Customer { CustID = 1, CustName = "Seema", City = "Chennai", Rating = 4 }; //object initializer
        stack.Push(c2);
        Print(stack);
    }

    private static void Print(Stack<Customer> stack)
    {
        string s2 = string.Format("-{0,5} - {1,9}- {2,15} - {3,3}-", "", "", "", "");
        Console.WriteLine(s2);
        string s1 = string.Format("|{0,5} | {1,9}| {2,15} | {3,3}|", "CustID", "CustName", "City", "Rating");
        Console.WriteLine(s1);
        string s3 = string.Format("-{0,5} - {1,9}- {2,15} - {3,3}", "", "", "", "");
        Console.WriteLine(s3);

        foreach (var item in stack)
        {
            string s = string.Format("|{0,5} | {1,10}| {2,15} | {3,3}|", item.CustID, item.CustName, item.City, item.Rating);
            Console.WriteLine(s);
        }
    }

    private static void WorkingWithSortedSet()
    {
        SortedSet<string> strs = new SortedSet<string>();
        strs.Add("Jack");
        strs.Add("Anamika");
        strs.Add("Bobby");
        strs.Add("Zarina");
        strs.Add("Harini");


        foreach (var item in strs)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("===================================");

        SortedSet<Customer> SortedSetOfcustomers = new SortedSet<Customer>(new CustomerIDComparer());

        SortedSetOfcustomers.Add(new Customer { CustID = 4, CustName = "Amol", City = "Pune", Rating = 5 });//collection initializer

        Customer c = new Customer();
        c.CustID = 2;
        c.CustName = "Krishna";
        c.City = "Banglore";
        c.Rating = 5;
        SortedSetOfcustomers.Add(c);

        Customer c1 = new Customer { CustID = 3, CustName = "Gauri", City = "Chennai", Rating = 4 }; //object initializer
        SortedSetOfcustomers.Add(c1);

        Customer c2 = new Customer { CustID = 1, CustName = "Seema", City = "Chennai", Rating = 4 }; //object initializer
        SortedSetOfcustomers.Add(c2);

        foreach (var item in SortedSetOfcustomers)
        {
            Console.WriteLine(item.CustID + "---" + item.CustName + "---" + item.City + "---" + item.Rating);
            Console.WriteLine();
        }
    }

    private static void WorkingWithList()
    {
        List<Customer> customerlist = new List<Customer>();
        char answer = 'N';
        do
        {
            Customer c = new Customer();
            Console.WriteLine("Enter Customerid");
            c.CustID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer Name");
            c.CustName = Console.ReadLine();
            Console.WriteLine("Enter Customer City");
            c.City = Console.ReadLine();
            Console.WriteLine("Enter Customer Rating");
            c.Rating = Convert.ToInt32(Console.ReadLine());

            customerlist.Add(c);
            Console.WriteLine("Do u want to add customer data");
            answer = Convert.ToChar(Console.ReadLine());
        }
        while (answer == 'Y');

        foreach (var item in customerlist)
        {
            Console.WriteLine($"CustomerId= {item.CustID}");
            Console.WriteLine($"Cusotemr Name ={item.CustName}");
            Console.WriteLine($"City= {item.City}");
            Console.WriteLine($"Rating= {item.Rating}");
            Console.WriteLine();
        }
    }

    private static void WorkingWithGenericSimpleDataTypes()
    {
        List<int> intlist = new List<int>();
        intlist.Add(11);
        intlist.Add(12);
        intlist.Add(13);
        intlist.Add(140);

        foreach (var item in intlist)
        {
            Console.WriteLine(item);
        }

        List<string> s = new List<string>();
        s.Add("Amita");
        s.Add("Sunita");
        s.Add("Ankita");
        s.Add("Arnima");
        s.Add("Soham");

        foreach (var item in s)
        {
            Console.WriteLine(item);
        }
    }
}