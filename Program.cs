#region 1
//namespace Lab4
//{
//    public class Program
//    {
//        static void Main()
//        {
//           Student student = new Student();

//            student.Name = Console.ReadLine();
//            student.Age = int.Parse(Console.ReadLine());
//            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");

//        }
//    }
//}
#endregion
#region 2
//namespace Lab4
//{
//    public class Program 
//    {
//        static void Main()
//        {
//            BankAccount b = new BankAccount();

//            b.GetBalance();
//            Console.WriteLine(b.GetBalance());

//            b.Deposit(30);
//            Console.WriteLine(b.Balance);

//        }
//    }

//}
#endregion
#region 3
//namespace Lab4
//{
//    public class Program
//    {
//        static void Main()
//        {
//            MathPractise mathPractise = new MathPractise();
//            var a = double.Parse(Console.ReadLine());
//            var b = double.Parse(Console.ReadLine());
//            int k=int.Parse(Console.ReadLine());
//            if (k == 1)
//            {
//                Console.WriteLine(mathPractise.Add(a, b));
//            }
//            else if (k == 2)
//            {
//                Console.WriteLine(mathPractise.Subtract(a, b));
//            }
//            else if(k == 3)
//            {
//                Console.WriteLine(mathPractise.Multiply(a, b));
//            }
//            else
//            {
//                Console.WriteLine(mathPractise.Divide(a, b));
//            }
//        }
//    }
//}
#endregion
#region 4
//namespace Lab4
//{
//    public class Program
//    {
//        static void Main ()
//        { 
//            Book b = new Book ();
//            b.Title = "1984";
//            b.Author = "George Orwell";
//            b.Pages = 328;
//            Console.WriteLine(b.Author);
//            Console.WriteLine(b.Title);
//            Console.WriteLine(b.Pages);
//        }
//    }
//}
#endregion
#region 5
//namespace Lab4
//{
//    public class Program
//    {
//        static void Main()
//        {
//            Product product = new Product();
//            product.AddStock(50);
//            product.sell(20);
//            Console.WriteLine(product.Stocks);
//        }
//    }
//}
#endregion
#region 6
//namespace Lab4
//{
//    class Program
//    {
//        static void Increase(ref int number)
//        {
//            number++;
//        }
//        static void Main(string[] args)
//        {
//            int x = int.Parse(Console.ReadLine());
//            Console.WriteLine("Before: " + x);
//            Increase(ref x);
//            Increase(ref x);
//            Increase(ref x);
//            Increase(ref x);
//            Increase(ref x);
//            Console.WriteLine("After: " + x);
//        }
//    }
//}
#endregion

#region 7
//namespace Lab4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            NumberTools nt = new NumberTools();

//            int x = int.Parse(Console.ReadLine());
//            Console.WriteLine("Before: " + x);

//            nt.Increase(ref x);

//            Console.WriteLine("After: " + x);
//        }
//    }
//}
#endregion

#region 8
//namespace Lab4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            TryTools t = new TryTools();

//            int a = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());

//            int result;

//            if (t.TryDivide(a, b, out result))
//                Console.WriteLine("Result: " + result);
//            else
//                Console.WriteLine("Cannot divide by zero!");
//        }
//    }
//}
#endregion

#region 9
//namespace Lab4
//{
//    class Program
//    {
//        static void Main()
//        {
//            Student student = new Student();
//            student.Name = "Nihat";
//            student.Score = 95;

//            student.PrintInfo();
//        }


//    }
//}
#endregion

#region 10

//namespace Lab4
//{
//    class Program
//    {
//        static void Main()
//        {
//            Car car = new Car();
//            car.Model="Kia";
//            car.Maxspeed = 230;

//            car.PrintInfo();
//        }


//    }
//}
#endregion

#region 11
//namespace Lab4
//{
//    class Program
//    {
//        static void Main()
//        {
//            Product product = new Product();
//            product.Price = 10;
//            Console.WriteLine(product.Price);
//            product.Price = -10;
//            Console.WriteLine(product.Price);
//        }
//    }
//}
#endregion

#region 12

#endregion