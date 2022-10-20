// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input int number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input int number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2)
{
    Console.WriteLine($"{num2} greater than {num1}");
}
else
{
   Console.WriteLine($"{num1} greater than {num2}"); 
}


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (num1 > num2)
{
    max = num1;
}
else
{
    max = num2;
}
if (max > num3)
{
    Console.WriteLine($"{max} is maximum");
}
else{
    Console.WriteLine($"{num3} is maximum");
}


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 2;

if (result == 0)
{
    Console.WriteLine($"{num} is even"); //even - четное
}
else{
    Console.WriteLine($"{num} is odd"); //odd - нечетное
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input int number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;

while (current <= num)
{
    Console.Write(current + " ");
    current = current + 2; 
}