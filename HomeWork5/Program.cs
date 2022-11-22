// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*

int [] CreateThreeDigitArray (int size, int minVal, int maxVal)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}
void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int FindEvenCount(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}
Console.Write("Input length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int minVal = 100;
int maxVal = 999;

int [] newArray = CreateThreeDigitArray(size, minVal, maxVal);
ShowArray(newArray);
Console.Write($"Count of even numbers is {FindevenCount(newArray)}");



// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов,
//  стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] CreateNewArray (int size, int minVal, int maxVal)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}
void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
int FindSumOfEven(int [] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum +=array[i];
    }
    return sum; 
}
Console.Write("Input length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of array: ");
int minVal = Convert.ToInt32(Console.ReadLine());;
Console.Write("Input max value of array: ");
int maxVal = Convert.ToInt32(Console.ReadLine());;

int [] newArray = CreateNewArray(size, minVal, maxVal);
ShowArray(newArray);
Console.Write($"Sum of even numbers is {FindSumOfEven(newArray)}");

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
//  минимальным элементов массива.
// [3.0 7.2 22.7 2.1 78.3] -> 76.2

double [] CreateNewArray (int size, int minVal, int maxVal)
{
    double [] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal + 1) + new Random().NextDouble();
    }
    return array;
}
void ShowArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


double FindDiffMinMax(double [] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        else if (min > array[i])
        {
            min = array[i];
        }
    }
    min = Math.Round(min, 2); 
    max = Math.Round(max, 2);   
    Console.WriteLine($"Max {max}, Min {min}");    
    diff = max - min;
    return diff; 
}
 
Console.Write("Input length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of array: ");
int minVal = Convert.ToInt32(Console.ReadLine());;
Console.Write("Input max value of array: ");
int maxVal = Convert.ToInt32(Console.ReadLine());;

double [] newArray = CreateNewArray(size, minVal, maxVal);
ShowArray(newArray);
Console.WriteLine($"Difference between max and min numbers is {FindDiffMinMax(newArray)}");

