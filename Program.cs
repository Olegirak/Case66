/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
int GetDataFromUser(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    System.Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    Console.ResetColor();
    return result;
}
int SumNum(int n, int m, int sum)
{
    if (n <= m)
    {
        sum = n + sum + SumNum(n + 1, m, sum);
    }
    return sum;
}

int x = GetDataFromUser("Введите число N");
int y = GetDataFromUser("Введите число M");
int sum = 0;
Console.WriteLine(SumNum(x, y, sum));