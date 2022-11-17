// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B (Math.Pow НЕ использовать)
// 3, 5 -> 243 (3⁵)
// 0, 0 - >1
// 2, 4 -> 16
/*
int FindDegree(int a, int b)
{
    int deg = 1;
     for (int i = 1; i <= b; i++)
    {
        deg = deg * a;
    } 
    return deg;
}

Console.Write("Input number a: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number b: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"{num1} in degree {num2} is {FindDegree(num1,num2)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumOfDigits(int num)
{
    //int count = 0;
    int sum = 0;
    int num1 = 0;
    while (num > 0)
    {
    
        num1 = num % 10;
        sum = sum + num1;
        num = num / 10;

    }
    return sum;
}

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits in {number} is {SumOfDigits(number)}");
*/

// Задача 29: Напишите программу, которая создает массив заданного пользователем размера, 
//заполняет массив элементами от 1 до 99 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreatRandArray (int n, int minVal, int maxVal)
{
    int [] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(0,100);
    }
    return arr;
}
void PrintArray(int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("\b\b]"); 
}
Console.Write("Input length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
PrintArray(CreatRandArray(size, 0, 100));
