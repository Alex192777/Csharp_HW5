// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца
// Пример:
// 4 3 1  => 2 6
// 2 6 9     4 6
// 4 6 2


using System;

class Program
{
    static void Main()
    {
        int size = 3; // размер массива
        int[,] array = new int[size, size]; // создание двумерного массива

        // заполнение массива случайными числами
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                array[i, j] = random.Next(1, 100); // случайное число от 1 до 100
            }
        }

        // вывод исходного массива
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // поиск наименьшего элемента и его индексов
        int minElement = array[0, 0];
        int minRowIndex = 0;
        int minColumnIndex = 0;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minRowIndex = i;
                    minColumnIndex = j;
                }
            }
        }

        // создание нового массива без строки и столбца с минимальным элементом
        int[,] newArray = new int[size - 1, size - 1];
        for (int i = 0, k = 0; i < size; i++)
        {
            if (i == minRowIndex) continue; // пропустить строку с минимальным элементом
            for (int j = 0, l = 0; j < size; j++)
            {
                if (j == minColumnIndex) continue; // пропустить столбец с минимальным элементом
                newArray[k, l] = array[i, j];
                l++;
            }
            k++;
        }

        // вывод нового массива
        Console.WriteLine("Новый массив без строки и столбца с минимальным элементом:");
        PrintArray(newArray);
    }


    // метод для вывода двумерного массива в консоль
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
