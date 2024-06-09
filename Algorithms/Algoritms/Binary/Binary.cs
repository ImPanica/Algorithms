namespace Algorithms.Binary
{
    internal class Binary
    {
        public static int BinarySearchToInt(List<int> list, int value)
        {
            // Переменные для хранения границ
            int low = 0;
            int high = list.Count - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2; // Делим список на 2
                int tempValue = list[mid]; // заносим во временную переменную

                if (tempValue == value) // Если равно, то возвращаем
                    return mid;

                if (tempValue > value) // Много
                    high = mid - 1;
                else                   // Мало
                    low = mid + 1;
            }

            return -1; // значение отсутствует
        }

        public static int BinarySearchToString(List<string> list, string value)
        {
            // Переменные для хранения границ
            int low = 0;
            int high = list.Count - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2; // Делим список на 2
                string tempValue = list[mid]; // заносим во временную переменную
                int compareResult = tempValue.CompareTo(value); // Получаем результат сравнения слов в интовом числе
                                                                // -1 число меньше
                                                                // 0 равно
                                                                // 1 число больше

                if (compareResult == 0) // Если равно, то возвращаем индекс
                    return mid;

                if (compareResult > 0) // Если значение больше, то ищем в левой стороне
                    high = mid - 1;
                else
                    low = mid + 1; // Если значение меньше, то ищем в правой стороне

            }
            return -1; // Значение не найдено
        }
    }
}
