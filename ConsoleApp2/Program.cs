//ЗАДАНИЕ 1

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Введите первое число:");
//        int num1 = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Введите второе число:");
//        int num2 = Convert.ToInt32(Console.ReadLine());

//        int sum = AddNumbers(num1, num2);

//        Console.WriteLine("Сумма чисел " + num1 + " и " + num2 + " равна " + sum);
//    }

//    public static int AddNumbers(int a, int b)
//    {
//        return a + b;
//    }
//}



//ЗАДАНИЕ 2

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Введите радиус окружности:");
//        double radius = Convert.ToDouble(Console.ReadLine());

//        double area = CalculateCircleArea(radius);

//        Console.WriteLine("Площадь окружности с радиусом " + radius + " равна " + area);
//    }

//    public static double CalculateCircleArea(double radius)
//    {
//        return Math.PI * radius * radius;
//    }
//}


//ЗАДАНИЕ 3

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Введите строку:");
//        string inputString = Console.ReadLine();

//        int length = GetStringLenght(inputString);

//        Console.WriteLine("Длина введенной строки равна " + length);
//    }

//    public static int GetStringLenght(string input)
//    {
//        return input.Length;
//    }
//}


//ЗАДАНИЕ 4

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Введите целые числа через пробел:");
//        string input = Console.ReadLine();
//        string[] numbersStr = input.Split(' ');
//        int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

//        int max = GetMaxValue(numbers);

//        Console.WriteLine("Наибольшее значение в массиве: " + max);
//    }

//    public static int GetMaxValue(int[] array)
//    {
//        int max = array[0];
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] > max)
//            {
//                max = array[i];
//            }
//        }
//        return max;
//    }
//}


//ЗАДАНИЕ 5

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Введите число:");
//        int input = Convert.ToInt32(Console.ReadLine());

//        long factorial = GetFactorial(input);

//        Console.WriteLine("Факториал числа " + input + " равен " + factorial);
//    }

//    public static long GetFactorial(int number)
//    {
//        if (number == 0)
//        {
//            return 1;
//        }
//        else
//        {
//            long result = 1;
//            for (int i = 1; i <= number; i++)
//            {
//                result *= i;
//            }
//            return result;
//        }
//    }
//}


//ЗАДАНИЕ 6

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Введите строку:");
//        string inputString = Console.ReadLine();

//        if (IsPalindrome(inputString))
//        {
//            Console.WriteLine("Введенная строка является палиндромом.");
//        }
//        else
//        {
//            Console.WriteLine("Введенная строка не является палиндромом.");
//        }
//    }

//    public static bool IsPalindrome(string input)
//    {
//        input = input.ToLower();
//        int left = 0;
//        int right = input.Length - 1;

//        while (left < right)
//        {
//            if (input[left] != input[right])
//            {
//                return false;
//            }
//            left++;
//            right--;
//        }
//        return true;
//    }
//}


//ЗАДАНИЕ 7

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        int[] array1 = { 1, 2, 3 };
//        int[] array2 = { 4, 5, 6 };

//        int[] mergedArray = MergeArrays(array1, array2);

//        Console.WriteLine("Результирующий массив: " + string.Join(", ", mergedArray));
//    }

//    public static int[] MergeArrays(int[] array1, int[] array2)
//    {
//        int totalLength = array1.Length + array2.Length;
//        int[] mergedArray = new int[totalLength];

//        Array.Copy(array1, mergedArray, array1.Length); // Копируем элементы первого массива в начало результирующего массива
//        Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length); // Копируем элементы второго массива в конец результирующего массива

//        return mergedArray;
//    }
//}


//ЗАДАНИЕ 8

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Введите число:");
//        int number = Convert.ToInt32(Console.ReadLine());

//        if (IsPrimeNumber(number))
//        {
//            Console.WriteLine("Введенное число является простым.");
//        }
//        else
//        {
//            Console.WriteLine("Введенное число не является простым.");
//        }
//    }

//    public static bool IsPrimeNumber(int number)
//    {
//        if (number <= 1)
//        {
//            return false;
//        }
//        for (int i = 2; i <= Math.Sqrt(number); i++)
//        {
//            if (number % i == 0)
//            {
//                return false;
//            }
//        }
//        return true;
//    }
//}


//ЗАДАНИЕ 9

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        Console.WriteLine("Введите строку:");
//        string inputString = Console.ReadLine();

//        string reversedString = ReverseString(inputString);

//        Console.WriteLine("Развернутая строка: " + reversedString);
//    }

//    public static string ReverseString(string input)
//    {
//        char[] charArray = input.ToCharArray();
//        Array.Reverse(charArray);
//        return new string(charArray);
//    }
//}


//ЗАДАНИЕ 10

//using System;

//public class Program
//{
//    public static void Main()
//    {
//        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//        int sum = SumOfArrayElements(array);

//        Console.WriteLine("Сумма всех элементов массива: " + sum);
//    }

//    public static int SumOfArrayElements(int[,] array)
//    {
//        int sum = 0;
//        for (int i = 0; i < array.GetLength(0); i++)
//        {
//            for (int j = 0; j < array.GetLength(1); j++)
//            {
//                sum += array[i, j];
//            }
//        }
//        return sum;
//    }
//}
