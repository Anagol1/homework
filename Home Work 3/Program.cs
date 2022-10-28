// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palindrom(int num){
//     if (num > 9999 & num < 99999){
//     int FirstDigit = num / 10000;
//     int LastDigit = num % 10;
//     int SecondDigit = (num / 1000) % 10;
//     int FourthDigit = (num / 10) % 10;
//         if (FirstDigit == LastDigit && SecondDigit == FourthDigit)
//         {
//             Console.WriteLine("This is palindrom!");
//         }
//         else Console.WriteLine("This is not palindrom");
//     }
//     else Console.WriteLine("Введите пятизначное число");  
// }
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Palindrom(num);


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//AB = √(xb - xa)^2 + (yb - ya)^2 + (za - zb)^2 - формула для трехмерного пространства

// double Distance(int xa, int xb, int ya, int yb, int za, int zb){
//     double ab = Math.Sqrt(((xb - xa)*(xb - xa)) + ((yb - ya)*(yb - ya))+((za - zb)*(za - zb)));
//     return ab;
// }
// Console.Write("Введите xa: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите xb: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите ya: ");
// int n3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите yb: ");
// int n4 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите za: ");
// int n5 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите zb: ");
// int n6 = Convert.ToInt32(Console.ReadLine());
// double result = Distance(n1, n2, n3, n4, n5, n6);
// Console.Write($"Расстояние между точками ({n1},{n3},{n5} и {n2},{n4},{n6} равно {result}");


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void TableOfCubes(int N){
    for(int i = 1; i <= N; i++){
        Console.Write($"{i*i*i} ");
    }
}
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
TableOfCubes(N);