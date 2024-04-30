using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива: ");
        int m = Convert.ToInt32(Console.ReadLine());
        string[] originalArray = new string[m];

        void array(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент массива");
                stringArray[i] = Console.ReadLine();
            }
        }

        void printArray(string[] stringArray)
        {
            Console.WriteLine("Массив строк:");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }

        string[] newArray(string[] stringArray)
        {
            string[] newArray = new string[stringArray.Length];
            int newIndex = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length <= 3)
                {
                    newArray[newIndex] = stringArray[i];
                    newIndex++;
                }
            }
            return newArray;
        }

        array(originalArray);
        printArray(originalArray);
        printArray(newArray(originalArray));
    }
}