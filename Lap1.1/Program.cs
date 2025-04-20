////bai01
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập tên của bạn: ");
//        string name = Console.ReadLine();
//        Console.Write("Nhập tuổi của bạn: ");
//        int age = int.Parse(Console.ReadLine());
//        Console.WriteLine($"Xin chào {name}, bạn {age} tuổi!");
//    }
//}

//bai02
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập chiều dài: ");
//        double length = double.Parse(Console.ReadLine());
//        Console.Write("Nhập chiều rộng: ");
//        double width = double.Parse(Console.ReadLine());
//        double area = length * width;
//        Console.WriteLine($"Diện tích hình chữ nhật là: {area}");
//    }
//}

//bai03
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập nhiệt độ (độ C): ");
//        double celsius = double.Parse(Console.ReadLine());
//        double fahrenheit = (celsius * 9 / 5) + 32;
//        Console.WriteLine($"{celsius} độ C = {fahrenheit} độ F");
//    }
//}

//bai04
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập một số nguyên: ");
//        int number = int.Parse(Console.ReadLine());
//        if (number % 2 == 0)
//        {
//            Console.WriteLine($"{number} là số chẵn.");
//        }
//        else
//        {
//            Console.WriteLine($"{number} không phải là số chẵn.");
//        }
//    }
//}

//bai05
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập số thứ nhất: ");
//        double num1 = double.Parse(Console.ReadLine());
//        Console.Write("Nhập số thứ hai: ");
//        double num2 = double.Parse(Console.ReadLine());
//        double sum = num1 + num2;
//        double product = num1 * num2;
//        Console.WriteLine($"Tổng: {sum}, Tích: {product}");
//    }
//}

//bai06
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập một số: ");
//        double number = double.Parse(Console.ReadLine());
//        if (number > 0)
//        {
//            Console.WriteLine("Số dương.");
//        }
//        else if (number < 0)
//        {
//            Console.WriteLine("Số âm.");
//        }
//        else
//        {
//            Console.WriteLine("Số không.");
//        }
//    }
//}

//bai07
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập một năm: ");
//        int year = int.Parse(Console.ReadLine());
//        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
//        if (isLeapYear)
//        {
//            Console.WriteLine($"{year} là năm nhuận.");
//        }
//        else
//        {
//            Console.WriteLine($"{year} không phải là năm nhuận.");
//        }
//    }
//}

//bai08
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            for (int j = 1; j <= 10; j++)
//            {
//                Console.WriteLine($"{i} x {j} = {i * j}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//bai09
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập số nguyên dương n: ");
//        int n = int.Parse(Console.ReadLine());
//        long factorial = 1;
//        for (int i = 1; i <= n; i++)
//        {
//            factorial *= i;
//        }
//        Console.WriteLine($"{n}! = {factorial}");
//    }
//}

////bai10
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập một số nguyên dương: ");
//        int number = int.Parse(Console.ReadLine());
//        bool isPrime = true;
//        if (number < 2)
//        {
//            isPrime = false;
//        }
//        else
//        {
//            for (int i = 2; i <= Math.Sqrt(number); i++)
//            {
//                if (number % i == 0)
//                {
//                    isPrime = false;
//                    break;
//                }
//            }
//        }
//        if (isPrime)
//        {
//            Console.WriteLine($"{number} là số nguyên tố.");
//        }
//        else
//        {
//            Console.WriteLine($"{number} không phải là số nguyên tố.");
//        }
//    }
//}