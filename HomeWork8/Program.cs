// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/*
int [,] Create2dArray(int rows, int columns, int minvalue, int maxvalue) //создание 2хмерного массива
{
    int [,] createdArray = new int[rows,columns]; // резервируем место под массив
    for (int i = 0; i < rows; i++)   // фигурные скобки не ставим, т к в циклах фор по одному действию
        for (int j = 0; j < columns; j++)
            createdArray [i,j] = new Random().Next(minvalue,maxvalue + 1);
    return  createdArray;  
}
void Show2dArray (int [,] array) // вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)  // в многомерном массиве нужно использовать array.GetLength (если использовать array.Length, то подтянет все элементы 2дмассива )
    {
        for (int j = 0; j < array.GetLength(1); j++) // array.GetLength(0) - для строк, array.GetLength(1) для столбцов
        {
            Console.Write(array[i,j] + " "); // добавляет пробел после каждого символа
        } 
        Console.WriteLine(); // переход на новую строку
    }
    Console.WriteLine();
}

int [,] RegularRows(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < (array.GetLength(1)); j++)
            for (int k = 0; k < (array.GetLength(1)); k++)
        {
            int temp = array[i,j];
            if (array[i,j] >= array[i,k])
            {
                temp = array[i,k];
                array[i,k] = array[i,j];
                array[i,j] = temp;
            }            
        }
    return array;
}

// ввод данных пользователем
Console.Write("Input numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of column: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxvalue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dArray(rows, columns, minvalue, maxvalue); // вызов метода создания массива
Show2dArray(newArray); // вызов метода показа массива
Show2dArray(RegularRows(newArray));
*/
 
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка


int [,] Create2dArray(int rows, int columns, int minvalue, int maxvalue) //создание 2хмерного массива
{
    int [,] createdArray = new int[rows,columns]; // резервируем место под массив
    for (int i = 0; i < rows; i++)   // фигурные скобки не ставим, т к в циклах фор по одному действию
        for (int j = 0; j < columns; j++)
            createdArray [i,j] = new Random().Next(minvalue,maxvalue + 1);
    return  createdArray;  
}
void Show2dArray (int [,] array) // вывод массива
{
    for (int i = 0; i < array.GetLength(0); i++)  // в многомерном массиве нужно использовать array.GetLength (если использовать array.Length, то подтянет все элементы 2дмассива )
    {
        for (int j = 0; j < array.GetLength(1); j++) // array.GetLength(0) - для строк, array.GetLength(1) для столбцов
        {
            Console.Write(array[i,j] + " "); // добавляет пробел после каждого символа
        } 
        Console.WriteLine(); // переход на новую строку
    }
    Console.WriteLine();
}

int [] FindMinRow(int [,] array)
{
    {
        int [] sumRowVal = new int[array.GetLength(0)];
        for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {        
                sumRowVal[i] = sumRowVal[i] + array[i,j];
            }
            return sumRowVal;
    }
}

void FindMin (int [] array)
{
    int min = array[0];
    int imin = 0;
    for (int i = 1; i < array.Length; i++)
    if (min > array[i])
    {
        min = array[i];
        imin = i;
    }        
    Console.WriteLine($"Number of row with minimal sum of elements is: {imin} (sorry for my English)");
}

void ShowArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " "); 
    }
    Console.WriteLine();
}

// ввод данных пользователем
Console.Write("Input numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of column: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxvalue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Create2dArray(rows, columns, minvalue, maxvalue); // вызов метода создания массива
Show2dArray(newArray); 
int[] newArray1 = FindMinRow(newArray);
ShowArray(FindMinRow(newArray));
FindMin(newArray1);

 */
//  Задача 62 оказалась выше моего понимания, не смогла решить((