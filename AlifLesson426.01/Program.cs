using System;

namespace AlifLesson426._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //task2
            //Console.WriteLine("Please enter first side of Rectangle: ");
            //double side1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please enter second side of Rectangle: ");
            //double side2= Convert.ToDouble(Console.ReadLine());
            //Rectangle rectangle = new Rectangle(side1,side2);
            //Console.WriteLine($"Area of Rectangle is: {rectangle.AreaCalculator()}");
            //Console.WriteLine($"Perimeter of Rectangle is: {rectangle.PerimeterCalculator()}");

            //task3

            //Book book1 = new Book("Rules", "Jack Canfield", "Self Development");
            //book1.Show();

            //task5
            //        Converter converter = new Converter(11.30, 13.30, 0.15);
            //        Console.WriteLine("Enter amount: ");
            //        var isChecked = int.TryParse(Console.ReadLine(),  out var amount);
            //        if (isChecked == true)
            //        {
            //            if (amount > 0)
            //            {
            //                Console.WriteLine(@"Please select conversion: 
            //                            1. USD --> TJS  --- 1
            //                            2. EUR --> TJS  --- 2
            //                            3. RUB --> TJS  --- 3
            //                            4. TJS --> USD  --- 4
            //                            5. TJS --> EUR  --- 5
            //                            6. TJS --> RUB  --- 6");
            //                Console.Write("My choice: ");
            //                int userSelection = Convert.ToInt32(Console.ReadLine());
            //                if (userSelection > 0 && userSelection < 7)
            //                {
            //                    switch (userSelection)
            //                    {
            //                        case 1:
            //                            {
            //                                Console.WriteLine($"Result = {converter.DollarToSomoni(amount)} Somoni");
            //                            }
            //                            break;
            //                        case 2:
            //                            {
            //                                Console.WriteLine($"Result = {converter.EurToSomoni(amount)} Somoni");
            //                            }
            //                            break;
            //                        case 3:
            //                            {
            //                                Console.WriteLine($"Result = {converter.RubToSomoni(amount)} Somoni");
            //                            }
            //                            break;
            //                        case 4:
            //                            {
            //                                Console.WriteLine($"Result = {converter.SomoniToDollar(amount)} Dollars");
            //                            }
            //                            break;
            //                        case 5:
            //                            {
            //                                Console.WriteLine($"Result = {converter.SomoniToEur(amount)} Euro");
            //                            }
            //                            break;
            //                        case 6:
            //                            {
            //                                Console.WriteLine($"Result = {converter.SomoniToRub(amount)} Rubles");
            //                            }
            //                            break;
            //                    }

            //                }
            //                else
            //                {
            //                    Console.WriteLine("You have entered invalid number");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Amount can't be less or equal to zero");
            //            }
            //        }
            //        else
            //            Console.WriteLine("You have entered non numeric numbers");                                             
            //    }
            //}

            //task6
            //Console.WriteLine($"We have this positions available: \n" +
            //    $"Developer\n" +
            //    $"Tester\n" +
            //    $"Product Owner\n" +
            //    $"Accounter\n" +
            //    $"Scrum Master\n");

            //Console.WriteLine($"Please enter your information and position that you are applying for \n");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine($"Please enter your Last Name: ");
            //string lastName = Console.ReadLine();
            //Console.WriteLine($"Please enter your First Name: ");
            //string firstName = Console.ReadLine();
            //Console.WriteLine($"Please enter position: ");
            //string position = Console.ReadLine();
            //Console.WriteLine($"Please enter years of your expierence: ");
            //int expierence = Convert.ToInt32(Console.ReadLine());
            //Employee employee1 = new Employee(lastName, firstName, position, expierence);
            //employee1.positionInfo();
            //employee1.getInfo();
        }
            //task2
            //public class Rectangle
            //{
            //    public double side1, side2;
            //    public Rectangle(double side1, double side2)
            //    {
            //        this.side1 = side1;
            //        this.side2 = side2;
            //    }
            //    public double AreaCalculator()
            //    {
            //        return side1 * side2;
            //    }
            //    public double PerimeterCalculator()
            //    {
            //        return (side1 + side2) * 2;
            //    }
            //    double Area
            //    {
            //        get
            //        {
            //            return AreaCalculator();
            //        }
            //    }
            //    double Perimeter
            //    {
            //        get
            //        {
            //            return PerimeterCalculator();
            //        }
            //    }


            //task3
            //class Book
            //{
            //    Title title;
            //    Author author;
            //    Content content;
            //    public Book(string title, string author, string content)
            //    {
            //        this.title = new Title(title);
            //        this.author = new Author(author);
            //        this.content = new Content(content);
            //    }
            //    public void Show()
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //        title.Show();
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        author.Show();
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        content.Show();
            //    }
            //}

            //class Title
            //{
            //    string title;
            //    public Title(string title)
            //    {
            //        this.title = title;
            //    }
            //    public void Show()
            //    {
            //        Console.WriteLine(title);
            //    }
            //}
            //class Author
            //{
            //    string author;
            //    public Author(string author)
            //    {
            //        this.author = author;
            //    }
            //    public void Show()
            //    {
            //        Console.WriteLine(author);
            //    }
            //}
            //class Content
            //{
            //    string content;
            //    public Content(string content)
            //    {
            //        this.content = content;
            //    }
            //    public void Show()
            //    {
            //        Console.WriteLine(content);
            //    }
            //}
            //class Converter
            //{
            //    public double usd { get; set; }
            //    public double eur { get; set; }
            //    public double rub { get; set; }

            //    public Converter(double usd, double eur, double rub)
            //    {
            //        this.usd = usd;
            //        this.eur = eur;
            //        this.rub = rub;
            //    }
            //    public double DollarToSomoni(double usd)
            //    {
            //        return usd * this.usd;
            //    }
            //    public double EurToSomoni(double eur)
            //    {
            //        return eur * this.eur;
            //    }
            //    public double RubToSomoni(double rub)
            //    {
            //        return rub * this.rub;
            //    }
            //    public double SomoniToDollar(double somoni)
            //    {
            //        return somoni / this.usd;
            //    }
            //    public double SomoniToEur(double somoni)
            //    {
            //        return somoni / this.eur;
            //    }
            //    public double SomoniToRub(double somoni)
            //    {
            //        return somoni / this.rub;
            //    }

            //task6
            //class Employee
            //{
            //public string lastName { get; set; }
            //public string firstName { get; set; }
            //public string position { get; set; }
            //public int expierence { get; set; }
            //public Employee(string lastName, string firstName, string position, int expierence)
            //{
            //    this.lastName = lastName;
            //    this.firstName = firstName;
            //    this.position = position;
            //    this.expierence = expierence;
            //}
            //public double salary;
            //public void getInfo()
            //{
            //    Console.WriteLine($"Last Name: {lastName} \n" +
            //        $"First Name: {firstName}\n" +
            //        $"Position: {position} \n" +
            //        $"Salary: {salary}");
            //}
            //public void positionInfo()
            //{
            //    if (position == "Developer")
            //    {
            //        if (expierence <= 1)
            //        {
            //            salary = 1500 - (1500 * 14 / 100);
            //            Console.WriteLine($"Your salary with deducted tax and pension fund is = {salary}");
            //        }
            //        else if (expierence >= 2)
            //        {
            //            salary = 2500 - (2500 * 14 / 100);
            //            Console.WriteLine($"Your salary with deducted tax and pension fund is = {salary}");
            //        }
            //    }
            //    else if (position == "Tester")
            //    {
            //        if (expierence <= 1)
            //        {
            //            salary = 1000 - (1000 * 14 / 100);
            //            Console.WriteLine($"Your salary with deducted tax and pension fund is = {salary}");
            //        }
            //        else if (expierence >= 2)
            //        {
            //            salary = 2000 - (2000 * 14 / 100);
            //            Console.WriteLine($"Your salary with deducted tax and pension fund is = {salary}");
            //        }
            //    }
            //    else if (position == "Product Owner")
            //    {
            //        if (expierence <= 1)
            //        {
            //            salary = 800 - (800 * 14 / 100);
            //            Console.WriteLine($"Your salary with deducted tax and pension fund is = {salary}");
            //        }
            //        else if (expierence >= 2)
            //        {
            //            salary = 1600 - (1600 * 14 / 100);
            //            Console.WriteLine($"Your salary with deducted tax and pension fund is = {salary}");
            //        }
            //    }
            //    else if (position == "Accounter")
            //    {
            //        if (expierence <= 1)
            //        {
            //            salary = 1100 - (1100 * 14 / 100);
            //            Console.WriteLine($"Your salary with deducted tax and pension fund is = {salary}");
            //        }
            //        else if (expierence >= 2)
            //        {
            //            salary = 2200 - (2200 * 14 / 100);
            //            Console.WriteLine($"Your salary with deducted tax and pension fund is = {salary}");
            //        }
            //        //else if(expierence)
            //    }
            //    else if (position == "Scrum Master")
            //    {
            //        if (expierence <= 1)
            //        {
            //            salary = 900 - (900 * 14 / 100);
            //            Console.WriteLine($"Your salary with deducted tax and pension fund is = {salary}");
            //        }
            //        else if (expierence >= 2)
            //        {
            //            salary = 1800 - (1800 * 14 / 100);
            //            Console.WriteLine($"Your salary with deducted tax and pension fund is = {salary}");
            //        }
            //    }
            //    else
            //        Console.WriteLine($"This position does" +
            //            $" not exist");
            //}
        }
    }


    }







