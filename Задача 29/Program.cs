// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] GetArray(int length)
{
    int[] array = new int[length];

    Random r = new Random();
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = r.Next(0, 100);
   }

    return array;
}

string GetArrayAsString(int[] array)
{
    string result = string.Empty;

    for (int i = 0; i < array.Length; i++)
   {
        result += $"{array[i]}, ";
    }

    return result;
}

Console.WriteLine(GetArrayAsString(GetArray(int.Parse(Console.ReadLine()))));
