
// д з 
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNumbers (int n)
{
    Console.Write(n + " ");
    if (n > 1) ShowNumbers(n - 1);
}
Console.WriteLine("Inpt number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNumbers(num);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int ShowSumMN (int n, int m)
{
    if (m > n) return n + ShowSumMN(n + 1, m); 
    if (n > m) return m + ShowSumMN(m + 1, n);
    else return Math.Min(n,m); 
}

Console.WriteLine("Inpt N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpt M: ");
int m = Convert.ToInt32(Console.ReadLine());
int res = ShowSumMN(n, m);
Console.WriteLine(res);
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman (int m, int n)
{
    if (m == 0) return n + 1; 
    if (m != 0 && n==0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1)); 
    return Akkerman(m,n);
}

Console.WriteLine("Inpt M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inpt N: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = Akkerman(m, n);
Console.WriteLine(res);