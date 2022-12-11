// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число:  ");
int n = int.Parse(Console.ReadLine());    //945 9 + 4 + 5 = 18


int sum (int k)
{
    int res = 0;
    while (k > 0)
    {
        res = res + k % 10;
        k = k / 10;
    }
    return res;
}

Console.WriteLine(sum (n));