//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//        Console.WriteLine($"Tổng số chẵn: {SumEvenNumbers(arr)}");
//    }

//    private static int SumEvenNumbers(int[] arr)
//    {
//        int sum = 0;
//        foreach (int num in arr)
//        {
//            if (num % 2 == 0) sum += num;
//        }
//        return sum;
//    }
//}

//bai02
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập số phần tử mảng: ");
//        int n = int.Parse(Console.ReadLine());
//        int[] arr = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhập phần tử thứ {i + 1}: ");
//            arr[i] = int.Parse(Console.ReadLine());
//        }

//        FindPrimesInArray(arr);
//    }

//    private static bool IsPrime(int num)
//    {
//        if (num < 2) return false;
//        for (int i = 2; i <= Math.Sqrt(num); i++)
//        {
//            if (num % i == 0) return false;
//        }
//        return true;
//    }

//    private static void FindPrimesInArray(int[] arr)
//    {
//        Console.WriteLine("Các số nguyên tố trong mảng:");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (IsPrime(arr[i]))
//            {
//                Console.WriteLine($"Vị trí [{i}]: {arr[i]}");
//            }
//        }
//    }
//}

//bai03
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập số phần tử mảng: ");
//        int n = int.Parse(Console.ReadLine());
//        double[] arr = new double[n];

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhập phần tử thứ {i + 1}: ");
//            arr[i] = double.Parse(Console.ReadLine());
//        }

//        CountPositivesNegatives(arr);
//    }

//    private static void CountPositivesNegatives(double[] arr)
//    {
//        int positive = 0, negative = 0;
//        foreach (double num in arr)
//        {
//            if (num > 0) positive++;
//            else if (num < 0) negative++;
//        }
//        Console.WriteLine($"Số dương: {positive}, Số âm: {negative}");
//    }
//}

//bai04
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        int[] arr = { 5, 1, 9, 3, 7, 4, 8 };
//        Console.WriteLine($"Số lớn thứ hai: {FindSecondLargest(arr)}");
//    }

//    private static int FindSecondLargest(int[] arr)
//    {
//        int first = int.MinValue, second = int.MinValue;
//        foreach (int num in arr)
//        {
//            if (num > first)
//            {
//                second = first;
//                first = num;
//            }
//            else if (num > second && num != first)
//            {
//                second = num;
//            }
//        }
//        return second;
//    }
//}

//bai05
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập số a: ");
//        int a = int.Parse(Console.ReadLine());
//        Console.Write("Nhập số b: ");
//        int b = int.Parse(Console.ReadLine());

//        Swap(ref a, ref b);
//        Console.WriteLine($"Sau hoán vị: a = {a}, b = {b}");
//    }

//    private static void Swap(ref int a, ref int b)
//    {
//        int temp = a;
//        a = b;
//        b = temp;
//    }
//}

//bai06
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.Write("Nhập số phần tử mảng: ");
//        int n = int.Parse(Console.ReadLine());
//        double[] arr = new double[n];

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"Nhập phần tử thứ {i + 1}: ");
//            arr[i] = double.Parse(Console.ReadLine());
//        }

//        SortArray(arr);
//        Console.WriteLine("Mảng sau khi sắp xếp:");
//        foreach (double num in arr)
//        {
//            Console.Write(num + " ");
//        }
//    }

//    private static void SortArray(double[] arr)
//    {
//        for (int i = 0; i < arr.Length - 1; i++)
//        {
//            for (int j = i + 1; j < arr.Length; j++)
//            {
//                if (arr[i] > arr[j])
//                {
//                    double temp = arr[i];
//                    arr[i] = arr[j];
//                    arr[j] = temp;
//                }
//            }
//        }
//    }
//}