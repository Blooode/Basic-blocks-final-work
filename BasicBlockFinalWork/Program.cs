// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

namespace BasicBlockFinalWork
{
    internal class Program
    {
        static int CompareStringLength(string[] array)
        {
            bool[] rightIndexes = new bool[array.Length];
            int comparingValue = 3;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToString().Length <= comparingValue) rightIndexes[i] = true;
                else rightIndexes[i] = false;
            }
            int arraySize = 0;
            foreach (bool flag in rightIndexes)
            {
                if (flag == true) arraySize++;
            }
            return arraySize;
        }

        static string[] FillByHandStringArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = SetStringValue($"Enter the {i} string: ");
            }
            return array;
        }

        static void Output1DStringArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++) Console.WriteLine(array[i]);
        }

        static string SetStringValue(string text)
        {
            Console.Write(text);
            string? value = Console.ReadLine() ?? string.Empty;
            return value;
        }

        static int SetIntValue(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            string[] strings = new string[SetIntValue("Enter the array size: ")];
            FillByHandStringArray(strings);
            Console.WriteLine();
            Output1DStringArray(strings);

            string[] finalStrings = new string[CompareStringLength(strings)];
        }
    }
}