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
void PrintMatrixTripleWithCoordinates(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} [{i + 1},{j + 1},{k + 1}] ");
            }
        }
    }
}
void FillMatrix(int[,] matrix)

{
    for (int k = 0; k < matrix.GetLength(0); k++)
    {
        for (int f = 0; f < matrix.GetLength(1); f++)
        {
            matrix[k, f] = new Random().Next(1, 6);
        }
    }

}
int MakeUniqueNumbers(int[,,] array)
{
    int number;
    while (true)
    {
        bool check = true;
        number = new Random().Next(10, 100);
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(2); j++)
                {
                    if (array[k, i, j] == number) check = false;
                }
            }
        }
        if (check == true) return number;
    }
}
void FillMAtrixUnique(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = MakeUniqueNumbers(array);
            }
        }
    }
}
void SortLines(int[,] array, int k)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            if (array[k, i] < array[k, j])
            {
                int temp = array[k, i];
                array[k, i] = array[k, j];
                array[k, j] = temp;
            }
        }
    }
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] matrix = new int[4, 4];
// FillMatrix(matrix);
// PrintMatrix(matrix);
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     SortLines(matrix, i);
// }
// Console.WriteLine();
// Console.WriteLine("Отсортированные по убыванию строки представлены ниже: ");
// Console.WriteLine();
// PrintMatrix(matrix);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] array = new int[5, 4];
// FillMatrix(array);
// PrintMatrix(array);
// Console.WriteLine();
// int sumMin = 0;
// int sum = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i == 0)
//         {
//             sum += array[i, j];
//             sumMin = sum;
//         }
//         else
//         {
//             sum += array[i, j];
//         }
//     }
//     if (sum < sumMin)
//     {
//         sumMin = sum;
//     }
//     Console.WriteLine($"Сумма {i + 1} строки: {sum}");
// }
// Console.WriteLine();
// Console.WriteLine("Минимальная сумма: " + sumMin);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// !!! Произведение матриц AxB определено, если количество столбцов первой матрицы равно количеству строк второй матрицы.

// int[,] firstMatrix = new int[3, 3];

// FillMatrix(firstMatrix);
// PrintMatrix(firstMatrix);
// Console.WriteLine();

// int[,] secondMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
// FillMatrix(secondMatrix);
// PrintMatrix(secondMatrix);

// int[,] resultMarix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
// for (int i = 0; i < firstMatrix.GetLength(0); i++)
// {
//     for (int j = 0; j < firstMatrix.GetLength(1); j++)
//     {
//         for (int q = 0; q < firstMatrix.GetLength(1); q++)
//         {
//             resultMarix[i, j] += firstMatrix[i, q] * secondMatrix[q, j];
//         }
//     }
// }
// Console.WriteLine();
// PrintMatrix(resultMarix);

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] tripleMatrix = new int[2, 5, 5];
// FillMAtrixUnique(tripleMatrix); // Часть кода подсказали одногруппники, но для себя открыл то, как работает bool
// PrintMatrixTripleWithCoordinates(tripleMatrix); // Вывод адаптирован под обычную систему координат матрицы

// Задача 62: Заполните спирально массив 4 на 4.

// int[,] spiralArray = new int[4, 4];
// int growingNumber = 0;
// for (int j = 0; j < spiralArray.GetLength(1)-1; j++)
// {
//     int i = 0;
//     growingNumber++;
//     spiralArray[i, j] = growingNumber;
// }
// for (int i = 0; i < spiralArray.GetLength(0)-1; i++)
// {

//     int k = 3;
//     growingNumber++;
//     spiralArray[i, k] = growingNumber;
// }
// for (int j = 3; j > 0; j--) 
// {
//     int i = 3;
//     growingNumber++;
//     spiralArray[i, j] = growingNumber;
// }
// for (int i = 3; i > 1; i--)
// {
//     int j = 0;
//     growingNumber++;
//     spiralArray[i, j] = growingNumber;
// }
// for (int j = 0; j < 2; j++) // 
// {
//     int i = 1;
//     growingNumber++;
//     spiralArray[i, j] = growingNumber;
// }
// for (int i = 1; i < 2; i++)
// {
//     int j = 2;
//     growingNumber++;
//     spiralArray[i, j] = growingNumber;
// }
// for (int j = 2; j > 0; j--)
// {
//     int i = 2;
//     growingNumber++;
//     spiralArray[i, j] = growingNumber;
// }

// PrintMatrix(spiralArray);