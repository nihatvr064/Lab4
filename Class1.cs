using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region 1
//namespace Lab4
//{
//    internal class Student
//    {
//        private string _name;
//        private int _age;

//        public string Name
//        {
//            get { return _name; }
//            set { _name = value; }
//        }

//        public int Age
//        {
//            get { return _age; }
//            set
//            {
//                if (value >= 18)
//                {
//                    _age = value;
//                }
//                else
//                {
//                    throw new ArgumentException("Age must be at least 18.");
//                }
//            }
//        }
//    }
//}
#endregion
#region 2
//namespace Lab4
//{
//    class BankAccount
//    {
//        private decimal _balance;
//        public decimal Balance
//        {
//            get { return _balance; }
//            set { _balance = value; }
//        }
//        public void Deposit(int amount)
//        {
//            if (amount > 0)
//            {
//                Balance += amount;
//            }
//            else
//            {
//                throw new Exception("menfi mebleg yaratmaq olmaz");
//            }
//        }
//        public decimal GetBalance()
//        {
//            return _balance;
//        }
//    }
//}
#endregion
#region 3
//namespace Lab4
//{
//    class MathPractise
//    {
//        public double Add(double x, double y) { return x + y; }
//        public double Subtract(double x, double y) { return x - y; }
//        public double Multiply(double x, double y) { return x * y; }
//        public double Divide(double x, double y) { return x / y; }
//    }
//}
#endregion
#region 4
//namespace Lab4
//{
//    class Book
//    {
//        public string Title { get; set; }
//        public string Author { get; set; }
//        public int Pages { get; set; }
//    }
//}
#endregion
#region 5
//namespace Lab4
//{
//    class Product
//    {
//        private int _stock;
//        public int Stocks {  get { return _stock; } }
//        public void AddStock(int amount)
//        {
//            _stock+=amount; 
//        }
//        public void sell(int amount)
//        {
//            if(_stock>= amount)
//            {
//                _stock-=amount;
//            }
//            else
//            {
//                Console.WriteLine("Not enough stock");
//            }
//        }
//    }
//}
#endregion

#region 7
//namespace Lab4
//{
//    class NumberTools
//    {
//        public void Increase(ref int number)
//        {
//            number++;
//        }
//    }
//}
#endregion

#region 8
//namespace Lab4
//{
//    class TryTools
//    {
//        public bool TryDivide(int a, int b, out int result)
//        {
//            if (b == 0)
//            {
//                result = 0;
//                return false;
//            }

//            result = a / b;
//            return true;
//        }
//    }
//}
#endregion

#region 9
//namespace Lab4
//{
//    class Student
//    {
//        private string _name;
//        private int _score;
//        public string Name { get { return _name; } set { _name = value; } }
//        public int Score { get { return _score; } set { _score = value; } }
//        public void PrintInfo()
//        {
//            Console.WriteLine($"Name: {_name}, Score: {_score}");
//        }
//    }
//}
#endregion

#region 10
//namespace Lab4
//{
//    class Car
//    {
//        private string _model;
//        private int _maxspeed;
//        public string Model { get { return _model; } set { _model = value; } }
//        public int Maxspeed { get { return _maxspeed; } set { _maxspeed = value; } }

//        public void PrintInfo()
//        {
//            Console.WriteLine($"Model: {_model}, MaxSpeed: {_maxspeed}");
//        }
//    }
//}
#endregion

#region 11
//namespace Lab4
//{
//    class Product
//    {
//        private int _price;
//        public int Price { get { return _price; } set { if (value > 0) { _price = value; } else { throw new Exception("Menfi ola bilmez"); }  } }
//    }
//}
#endregion

#region 12
//namespace Lab4
//{
//    class Phone
//    {
//        public string Brand { get; set; }
//        public int Battery { get; set; }

//        public Phone()
//        {
//            Battery = 100;
//        }

//        public void DecreaseBattery(int amount)
//        {
//            Battery -= amount;
//            if (Battery < 0)
//            {
//                Battery = 0;
//            }

//        }
//        public void PrintInfo()
//        {
//            Console.WriteLine($"Brand: {Brand} \t Battery: {Battery}%");
//        }
//    }
//}
#endregion

#region 13

//namespace Lab4
//{
//    class Password
//    {
//        private string _password;
//        public Password(string password)
//        {
//            if(password.Length>=6)
//            {
//                _password = password;
//            }
//            else
//            {
//                throw new Exception("Password minimum 6 simvol olmalidir");
//            }
//        }
//        public void ChangePassword(string newPassword)
//        {
//            if (newPassword.Length >= 6)
//            {
//                _password = newPassword;
//            }
//            else
//            {
//                throw new Exception("Password minimum 6 simvol olmalidir");
//            }
//        }
//        public void PrintPassword()
//        {
//            Console.WriteLine($"Password: {_password}");
//        }


//    }
//}
#endregion

#region 14
//namespace Lab4
//{
//    class BankAccount
//    {
//        private decimal _balance;
//        public decimal Balance { get; private set; }

//        public void Deposit(int amount)
//        {
//            if (amount > 0)
//            {
//                Balance += amount;
//            }
//            else
//            {
//                throw new Exception("Invalid deposit amount.");
//            }

//        }
//        public void WithDraw(decimal amount)
//        {
//            if (amount > 0 && amount <= Balance)
//            {
//                Balance -= amount;
//            }
//            else
//            {
//                throw new Exception("Invalid withdrawal amount.");
//            }
//        }
//        public void ShowBalance()
//        {
//            Console.WriteLine($"Current Balance: {Balance}");
//        }
//    }
//}
#endregion

#region 15
//namespace Lab4
//{
//    class Employee
//    {
//        private decimal Salary;

//        public string Name { get; }
//        public string Position { get; }

//        public Employee(string _name, string _position, decimal salary)
//        {
//            Name = _name;
//            Position = _position;

//            if (salary > 0)
//                Salary = salary;
//            else
//                throw new Exception("Initial salary must be greater than 0");
//        }

//        public void ChangeSalary(decimal amount)
//        {
//            if (amount > 0)
//                Salary = amount;
//            else
//                throw new Exception("Salary can't be less than 0");
//        }

//        public void ShowInfo()
//        {
//            Console.WriteLine($"Name: {Name}, Position: {Position}, Salary: {Salary}");
//        }
//    }
//}

#endregion

#region 16
//namespace Lab4
//{
//    class User
//    {
//        public string UserName { get; set; }
//        private string _email;
//        public void Email(string email)
//        {
//                if (email.Contains("@"))
//                {
//                    _email = email;
//                }
//                else
//                {
//                    throw new Exception("Invalid email format");
//                }
//        }
//        public void PrintInfo()
//        {
//            Console.WriteLine($"UserName: {UserName}, Email: {_email}");
//        }


//    }
//}
#endregion

#region 17
//namespace Lab4
//{
//    class Rectangle
//    {
//        private decimal _width;
//        private decimal _height;
//        public void SetValues(decimal width, decimal height)
//        {
//            _width = width; _height = height;
//            Console.WriteLine(width * height);
//        }
//    }


//}
#endregion

#region 18


#endregion
