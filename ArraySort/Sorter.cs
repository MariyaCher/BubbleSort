using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace ArraySort
{
    static class ArraySorter
    {
        /// <summary>
        /// Сортировка "Пузырьком"
        /// </summary>
        /// <param name="array">Массив для сортировки на месте</param>
        public static void BubbleSort<T>(IList<T> array) where T : IComparable<T>
        {
            // Следующие контракты доступны только при наличии установленного CCRewrite

            // Предусловие. Проверка аргумента
            // Contract.Requires<ArgumentNullException>(array != null);

            // Постусловие. Проверка того, что массив отсортирован
            //Contract.Ensures(IsSorted(array));

            for (Int32 i = 0; i < array.Count; ++i)
            {
                // Цикл до последнего "всплывшего" элемента
                for (Int32 j = 0; j < array.Count - 1 - i; ++j)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Проверка сортировки массива
        /// </summary>
        /// <param name="array">Массив для проверки</param>
        /// <returns>Возвращает true если массив отсортирован, в противном случае - false</returns>
        public static bool IsSorted<T>(IList<T> array) where T : IComparable<T>
        {
            for (Int32 i = 0; i < array.Count - 1; ++i)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
