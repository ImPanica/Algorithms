namespace Algorithms.Sort
{
    internal class Selection
    {
        /// <summary>
        /// Сортировка выбором
        /// </summary>
        /// <param name="array">Масcив для сортировки</param>
        /// <param name="toMore">Вариант сортировки от меньшего в большему == true</param>
        /// <returns></returns>
        public static int[] SelectionSort(int[] array, bool toMore = false)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                // Переменная для хранения минимального значения
                int min = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    // Если текущее знаечние меньше, то заносим его в переменную Min
                    if (toMore == false ? array[min] < array[j] : array[min] > array[j])
                        min = j;
                }

                // меняем переменные местами
                (array[min], array[i]) = (array[i], array[min]);
            }
            return array;
        }
    }
}
