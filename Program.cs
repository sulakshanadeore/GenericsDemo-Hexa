
using LibraryDemoWithGenerics;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //WorkingWithGenericSimpleDataTypes();

        //WorkingWithList();

        //WorkingWithSortedSet();

        //WorkingWithStack();

        //WorkingWithQueue();


        //WorkingWithQueueSimpleExample();

        //WorkingWithQueueComparision();

        //SimpleDictionary();
        //WorkingWithClassInDictionary();

        Dictionary<string, JewelleryDetails> allData = new Dictionary<string, JewelleryDetails>();

        allData.Add("A Jewellers", new JewelleryDetails 
        {
            Jewelleries=new List<Jewellery> 
            {
         new Jewellery{OrnamentID=1,Name="Bangles",MetalName="Gold",Weight=10 },
         new Jewellery{OrnamentID=2,Name="Rings",MetalName="Gold",Weight=10 },
         new Jewellery{ OrnamentID=3,Name="Something",MetalName="Silver",Weight=20}
            
            } 
        });



        allData.Add("B Jewellers", new JewelleryDetails
        {
            Jewelleries = new List<Jewellery>
            {
         new Jewellery{OrnamentID=1,Name="Bangles",MetalName="Gold",Weight=10 }
         

            }
        });



        allData.Add("C Jewellers", new JewelleryDetails
        {
            Jewelleries = new List<Jewellery>
            {
         new Jewellery{OrnamentID=1,Name="Bangles",MetalName="Gold",Weight=10 },
         new Jewellery{OrnamentID=2,Name="Rings",MetalName="Gold",Weight=10 }
         

            }
        });



        foreach (var item in allData)
        {
            Console.WriteLine("Jeweller Name = " + item.Key);
            Console.WriteLine("Deals in");
            foreach (var item1 in item.Value.Jewelleries)
            {
                Console.WriteLine("ItemName= " + item1.Name);
                Console.WriteLine("OrnamentID= " + item1.OrnamentID);
                Console.WriteLine("Weight= " + item1.Weight);
                Console.WriteLine("MetalName= " + item1.MetalName);
                    Console.WriteLine();
            }
            Console.WriteLine("===============");
           

        }
    }

    private static void WorkingWithClassInDictionary()
    {
        Dictionary<int, Jewellery> jewelleryBook = new Dictionary<int, Jewellery>();
        jewelleryBook.Add(1, new Jewellery { OrnamentID = 1, MetalName = "Gold", Name = "Bangles", Weight = 10 });
        jewelleryBook.Add(2, new Jewellery { OrnamentID = 2, MetalName = "Gold", Name = "Rings", Weight = 11 });
        jewelleryBook.Add(3, new Jewellery { OrnamentID = 3, MetalName = "Silver", Name = "Something", Weight = 5 });

        foreach (KeyValuePair<int, Jewellery> item in jewelleryBook)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value.OrnamentID + " " + item.Value.Name + item.Value.MetalName + item.Value.Weight);
        }
    }

    private static void SimpleDictionary()
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(1, "One");
        dic.Add(2, "Two");
        dic.Add(3, "Three");

        foreach (KeyValuePair<int, string> item in dic)
        {
            Console.WriteLine(item.Key + " " + item.Value);


        }
    }

    private static void WorkingWithQueueComparision()
    {
        Queue<Employee> empQ = new Queue<Employee>();
        empQ.Enqueue(new Employee { Empid = 1, EmpName = "Sudhir", Salary = 10000, JoiningDate = new DateTime(2025, 01, 11) });

        empQ.Enqueue(new Employee { Empid = 2, EmpName = "Suhasini", Salary = 10000, JoiningDate = new DateTime(2021, 01, 11) });

        empQ.Enqueue(new Employee { Empid = 3, EmpName = "Sumedh", Salary = 10000, JoiningDate = new DateTime(2023, 01, 11) });

        empQ.Enqueue(new Employee { Empid = 4, EmpName = "Girish", Salary = 10000, JoiningDate = new DateTime(2024, 01, 11) });

        foreach (var item in empQ)
        {
            Console.WriteLine(item.Empid + " " + item.EmpName + " " + item.Salary + "  " + item.JoiningDate);
        }

        Console.WriteLine("============Reversing the Queue================");

        IEnumerable<Employee> emps = empQ.Reverse();//reverses the Queue
        foreach (var item in emps)
        {
            Console.WriteLine(item.Empid + " " + item.EmpName + " " + item.Salary + "  " + item.JoiningDate);
        }




        Console.WriteLine("================After sorting====================");
        Employee[] empArr = empQ.ToArray();
        Array.Sort(empArr);


        foreach (var item in empArr)
        {
            Console.WriteLine(item.Empid + " " + item.EmpName + " " + item.Salary + "  " + item.JoiningDate);
        }





        Console.WriteLine("=================After Reverse==========================");
        Array.Reverse(empArr);
        foreach (var item in empArr)
        {
            Console.WriteLine(item.Empid + " " + item.EmpName + " " + item.Salary + "  " + item.JoiningDate);
        }
    }

    private static void WorkingWithQueueSimpleExample()
    {
        Queue<Products> pq = new Queue<Products>();//FIFO---first in , first out
        Products p1 = new Products { ProductID = 1, ProdName = "A", Price = 10, Qty = 1, UnitOfMeasurement = "Kg" };

        pq.Enqueue(p1);

        pq.Enqueue(new Products { ProductID = 2, ProdName = "B", Price = 20, Qty = 2, UnitOfMeasurement = "gms" });
        pq.Enqueue(new Products { ProductID = 3, ProdName = "C", Price = 30, Qty = 2, UnitOfMeasurement = "gms" });

        pq.Dequeue();//p1

        foreach (var item in pq)
        {
            Console.Write(item.ProductID);
            Console.Write("  " + item.ProdName);
            Console.Write("  " + item.Price);
            Console.Write("  " + item.Qty);
            Console.WriteLine();
        }

        Console.WriteLine("Number of Products in the Queue are= " + pq.Count);
    }

    private static void WorkingWithQueue()
    {
        Queue<Orders> queue = new Queue<Orders>();

        Orders o1 = new Orders();
        o1.OrderID = 101;
        o1.OrderDate = new DateOnly(2025, 04, 01);
        o1.CustomerDetails = new Customer { CustID = 1, CustName = "Hari", City = "Pune", Rating = 5 };

        List<Products> products = new List<Products>()
        {
            new Products {ProductID=1,ProdName="Chai",Price=10,Qty=1,UnitOfMeasurement="PerNo"},
            new Products{ ProductID=3,ProdName="Coffee",Price=30,Qty=2,UnitOfMeasurement="PerNo"},
            new Products{ ProductID=11,ProdName="Cold Coffee",Price=50,Qty=2,UnitOfMeasurement="PerNo"}

        };
        o1.MyCart = products;
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
            Console.WriteLine($" OrderID=   {item.OrderID}   OrderDate=  {item.OrderDate}   Customer ID={item.CustomerDetails.CustID} CustomerName= {item.CustomerDetails.CustName}  City= {item.CustomerDetails.City} Rating= {item.CustomerDetails.Rating}");
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