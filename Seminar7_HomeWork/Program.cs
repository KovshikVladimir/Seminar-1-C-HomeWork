int Input(string input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintMatrix(int[,] array)
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
void FillMatrix(int[,] matrix)
{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int f = 0; f < matrix.GetLength(1); f++)
        {
            matrix[k, f] = new Random().Next(1, 4);
        }
    }

}


// int m = Input("Введите m:");
// int n = Input("Введите n:");

// int[,] numbers = new int[m, n];

// // for (int i = 0; i < numbers.GetLength(0); i++)
// // {
// //     for (int j = 0; j < numbers.GetLength(1); j++)
// //     {
// //         numbers[i,j] = i+j;
// //     }
// // }

// int[,] numbers = new int[3, 4];
// FillMatrix(numbers);
// PrintArray(numbers);
// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         if (i % 2 != 0)
//         {
//             if (j % 2 != 0)
//             {
//                 numbers[i, j] *= numbers[i, j];
//             }
//         }
//     }
// }
// Console.WriteLine();
// PrintArray(numbers);

// int[,] numbers = new int[5, 5];
// FillMatrix(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         if (i == j)
//         {
//             sum += numbers[i,j];
//         }
//     }
// }
// Console.WriteLine();
// PrintMatrix(numbers);
// Console.WriteLine();
// Console.WriteLine(sum);

// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// int m = Input("Введите m:");
// int n = Input("Введите n:");

// int[,] numbers = new int[m, n];

// FillMatrix(numbers);
// PrintMatrix(numbers);

// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] numbers2 = new int[5, 5];
// FillMatrix(numbers2);
// PrintMatrix(numbers2);

// int first = Input("Введите номер строки:");
// int second = Input("Введите номер столбца:");

// for (int p = 0; p <= numbers2.GetLength(0); p++)
// {
//     if (first == p + 1)
//     {
//         for (int d = 0; d <= numbers2.GetLength(1); d++)
//         {
//             if (second == d + 1)
//             {
//                 Console.WriteLine(numbers2[p, d]);
//             }
//             if (second > numbers2.GetLength(1))
//             {
//                 Console.WriteLine("Такого элемента нет");
//                 break;
//             }
//         }
//     }
//     if (first > numbers2.GetLength(0))
//     {
//         Console.WriteLine("Такого элемента нет");
//         break;
//     }

// }


// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] arrayDouble = new int[5, 5];
FillMatrix(arrayDouble);
PrintMatrix(arrayDouble);
int y = 0;
int sum = 0;
int average = 1;

for (int i = 0; i < arrayDouble.GetLength(1); i++)
{
    y = 0;
    sum = 0;
    average = 1;
    while (y < arrayDouble.GetLength(0))
    {
        sum += arrayDouble[y, i];
        y++;
    }
    average = sum / arrayDouble.GetLength(0);
    Console.WriteLine($"Среднее арифметическое {i+1} столбца: " + average);
}





