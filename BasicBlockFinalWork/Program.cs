// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace BasicBlockFinalWork
{
    internal class Program
    {
        // Creates new string array with strings of 3 symbols or less.

        static string[] CreateNewArray(string[] array, string[] finalArray)
        {
            int finalArrayIndex = 0;
            int comparingValue = 3;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].ToString().Length <= comparingValue) finalArray[finalArrayIndex++] = array[i];
            }
            return finalArray;
        }

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
                if (flag) arraySize++;
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
            string value = string.Empty;
            bool isWrong = false;
            Console.Write(text);

                do
            {
                value = Console.ReadLine() ?? string.Empty;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        isWrong = true;
                        Console.Write("Wrong input! Enter the array size again: ");
                        break;
                    }
                    else if (char.IsDigit(value[value.Length - 1])) isWrong = false;
                }
            } while (isWrong);
            return Convert.ToInt32(value);
        }

        static void Main(string[] args)
        {
            string[] strings = new string[SetIntValue("Enter the array size: ")];
            FillByHandStringArray(strings);
            Console.WriteLine("Values of array:");
            Output1DStringArray(strings);
            Console.WriteLine();
            string[] finalStrings = new string[CompareStringLength(strings)];
            CreateNewArray(strings, finalStrings);
            Console.WriteLine("Values of final array:");
            Output1DStringArray(finalStrings);
        }
    }
}