// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

namespace BasicBlockFinalWork
{
    internal class Program
    {
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
        }
    }
}