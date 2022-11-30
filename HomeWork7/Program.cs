/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] Create2dArray() //создание 2хмерного массива
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of column: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());

    double [,] createdArray = new double[rows,columns]; 

    for (int i = 0; i < rows; i++)   
        for (int j = 0; j < columns; j++)
            createdArray [i,j] = new Random().Next(minvalue, maxvalue + 1) + new Random().NextDouble();
    return  createdArray;  
}
void Show2dArray (double [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(Math.Round(array[i,j],1) + " "); // округление
        } 
        Console.WriteLine(); // переход на новую строку
    }
    Console.WriteLine();
}

double[,] newArray = Create2dArray(); 
Show2dArray(newArray); 

*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
//  массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1; 7 -> такого числа в массиве нет

int [,] Create2dArray() 
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of column: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());

    int [,] createdArray = new int[rows,columns]; 

    for (int i = 0; i < rows; i++)   
        for (int j = 0; j < columns; j++)
            createdArray [i,j] = new Random().Next(minvalue,maxvalue + 1);
    return  createdArray;  
}
void Show2dArray (int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)  
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i,j] + " "); 
        } 
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowElement(int [,] newArray)
{

Console.Write("Input row you want show: ");
int findI = Convert.ToInt32(Console.ReadLine());;
Console.Write("Input column you want show: ");
int findJ = Convert.ToInt32(Console.ReadLine());;

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (i == findI && j == findJ)
                {
                    Console.WriteLine($"Your value is {newArray[i,j]}");
                }
        }
    }
    if (findI >= newArray.GetLength(0) || findJ >= newArray.GetLength(1))
        {
            Console.WriteLine("Your value is absent");
        }
}


int[,] newArray = Create2dArray(); 
Show2dArray(newArray);
ShowElement(newArray);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
/*
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double [,] Create2dArray() 
{
    Console.Write("Input numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input numbers of column: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());

    double [,] createdArray = new double[rows,columns]; 

    for (int i = 0; i < rows; i++)   
        for (int j = 0; j < columns; j++)
            createdArray [i,j] = new Random().Next(minvalue,maxvalue + 1);
    return  createdArray;  
}
void Show2dArray (double [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)  
    {
        for (int j = 0; j < array.GetLength(1); j++) 
        {
            Console.Write(array[i,j] + " "); 
        } 
        Console.WriteLine();
    }
    // Console.WriteLine();
}

double [] FindAverageOfColm(double [,] array)
{
    double [] sumColmVal = new double[array.GetLength(1)];
    double [] newarray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {        
            sumColmVal[j] = sumColmVal[j] + array[i,j];
            newarray[j] = sumColmVal[j] / array.GetLength(0);
        }
    }
    return newarray;
}
void ShowArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(Math.Round(array[i],2) + " "); 
    }
    Console.WriteLine();
}

double[,] newArr = Create2dArray(); 
Show2dArray(newArr);
double[] newArr1 = FindAverageOfColm(newArr);

Console.WriteLine($"Arithmetic mean of each column is: ");
ShowArray(FindAverageOfColm(newArr));

*/