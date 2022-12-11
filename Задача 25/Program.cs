// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число а:  ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b:  ");
int b = int.Parse(Console.ReadLine());

int res = a;

for (int i = 1; i < b; i++)
{
    res = res * a;
}

Console.WriteLine(res);

