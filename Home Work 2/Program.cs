/*
//Задача 10. Написать программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

int FindSecondDigit (int num)
{
    int digit2 = num / 10 % 10;    
    
    return digit2;
}

Console.WriteLine("Input three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit2 = FindSecondDigit(num);
Console.WriteLine(digit2);

//Задача 13. Написать программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
*/
int FindThirdDigit (int num)
{   
    int result = -1;
    int num1 = num;
    while (num > 999){   
        num1 = num / 10;
        num = num1;
    }
        int thirdDigit1 = num % 10;
        result = thirdDigit1;
    if (num < 100)
       Console.WriteLine($"number digits of {num} less than 3");
    
    else if (num > 99 & num < 1000)
        {
        //Console.WriteLine($"Third digit of {num} is {num % 10}");
        int thirdDigit2 = num % 10; 
        result = thirdDigit2;}
    return result;    
}
Console.WriteLine("Input number: "); 
int num = Convert.ToInt32(Console.ReadLine());

int thirdDigit = FindThirdDigit(num);
Console.WriteLine($"Third digit of {num} is {thirdDigit}"); 
// не удалось сделать так, чтобы при num < 99 выводился только один результат. В чеи ошибка, подскажите, пожалуйста 
/*

//Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.



bool CheckDay (int dayNum)
{    
    while (dayNum < 1 | dayNum > 7)
    {
        Console.WriteLine("Wrong number");
        break; 
    } 
    
    if (dayNum == 6 | dayNum == 7) 
    return true;
    else return false;
    
   }

Console.WriteLine("Input day number: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

bool result = CheckDay(dayNum);
if (result)
{
    Console.WriteLine("$This is holliday");
} 
else
{
    Console.WriteLine("$This is not holliday");
}
*/