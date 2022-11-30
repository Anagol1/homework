//Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввел пользователь.
// (не получилось сделать так, чтобы программа считывала, сколько данных ввел 
// пользователь. Думала делать так: введенные числа считать как string, затем string 
// преобразовать в массив, но тогда знаки "-" у отрицательных чисел тоже становятся 
// элементами массива. На этом и запнулась. Поэтому, размер массива вводит пользователь)


int [] CreateNewArray (int size)
{
    int [] arr = new int [size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"input number ");
    
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
 void ShowArray(int [] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
}
int FindCountOfPositive(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)  
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }
    return count; 
}
Console.Write("Input length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = CreateNewArray(size);
ShowArray(array);
Console.WriteLine($"Count of positive numbers is {FindCountOfPositive(array)}");




//Задача 43. Напишите программу, которая найдет точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2  и k2 
//задаются пользователем.
/*
double [] FindPointOfIntersection (double k1, double k2, double b1, double b2)
{
    double x = ((b2 - b1) / (k1 - k2));
    double y = k1 * x + b1;
    double [] array = new double[2];
    array[0] = x;
    array[1] = y;
    return array;
}
void ShowArray(double [] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.WriteLine($"\b\b)");
}
Console.Write("Input b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double [] newArray = FindPointOfIntersection(k1,k2,b1,b2);

if (k1 != k2)
    {
        Console.Write($"Point of intersection of two lines, defined by equations y=k1*x + b1, y = k2*x + b2, is ");
        ShowArray(newArray);   
    }
      else
        Console.WriteLine($"The Lines do not intersect!");
*/
