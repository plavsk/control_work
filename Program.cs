using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива: ");
        int m = Convert.ToInt32(Console.ReadLine());
        string[] originalArray = new string[m];
        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.WriteLine($"Введите {i + 1} элемент массива");
            originalArray[i] = Console.ReadLine();
        }
        string[] newArray = new string[originalArray.Length];
        int newIndex = 0;

        for (int i = 0; i < originalArray.Length; i++)
        {
            if (originalArray[i].Length <= 3)
            {
                newArray[newIndex] = originalArray[i];
                newIndex++;
            }
        }
        Console.WriteLine("Новый массив строк:");
        for (int i = 0; i < newIndex; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}