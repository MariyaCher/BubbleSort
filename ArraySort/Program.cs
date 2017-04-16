using System;
using System.Collections.Generic;

namespace ArraySort
{
    class Program
    {
        // Метод вывода массива в консоль. Безопасный к исключениям
        static void PrintArray<T>(IList<T> array)
        {
            try
            {
                foreach (T item in array)
                {
                    Console.Write("{0} ", item);
                }

                Console.WriteLine();
            }
            catch
            {
                // "Проглатывание" исключения, т.к. вывод не должен влиять на тест
            }
        }

        // Метод выполняющий сортироку и выводящий результат в консоль
        static void Test<T>(IList<T> array) where T : IComparable<T>
        {
            Console.WriteLine("Массив до сотриорвки:");
            PrintArray(array);
            Console.WriteLine();

            ArraySorter.BubbleSort(array);

            Console.WriteLine("Массив после сотриорвки:");
            PrintArray(array);
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            try
            {
                String[] arrayString = { "C", "#", "-", "объектно", "-", "ориентированный", "язык", "программирования" };
                Test(arrayString);

                Int32[] arrayInt32 = { 3, 1, 4, 1, 5, 9, 2, 6, 1, 2, 3, 5, 8, 4, 4 };
                Test(arrayInt32);

                Double[] emptyArrayDouble = { };
                Test(emptyArrayDouble);

                List<String> listString = new List<String> { "C", "#", "относится", "к", "семье", "языков", "с", "C", "-", "подобным", "синтаксисом" };
                Test(listString);

                List<Int32> listInt32 = new List<Int32> { 2, 5, 8, 6, 2, 1, 5, 5, 6, 2, 1, 5, 5 };
                Test(listInt32);

                List<Double> emptyListDouble = new List<Double>();
                Test(emptyListDouble);

                // Пример явного нарушения контракта
                // Test(null as List<Double>);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
