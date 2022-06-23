// Console.Clear();

// int Input(string message)
// {
//     return Convert.ToInt32(Console.ReadLine());
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + ",");
//     }
//     Console.Write("]");
// }
// void RandomFillThree(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
// }
// void RandomFill(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 100);
//     }
// }

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] array = new int[8];
// RandomFillThree(array);
// PrintArray(array);
// int result = 0;
// Console.WriteLine();
// Console.Write("Четные числа: ");
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         result += 1;

//         // 
//         Console.Write(array[i]+" ");
//     }
// }

// Console.WriteLine();
// Console.WriteLine();
// Console.WriteLine("Количетсво четных чисел: " + result);

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] array = new int[8];
// RandomFill(array);
// PrintArray(array);
// int result = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (i % 2 != 0)
//     {
//         result += array[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine("Сумма нечетных элементов: " + result);

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int[] array = new int[5];
// RandomFill(array);
// PrintArray(array);
// int result = 0;
// int maxNum = 0;
// int i=0;
// int minNum = array[i];

// for (i = 0; i < array.Length; i++)
// {
//     if (array[i] > maxNum)
//     {
//         maxNum = array[i];
//     }
//     else if (array[i]<minNum)
//     {
//         minNum = array[i];
//     }
// }

// Console.WriteLine();
// Console.WriteLine($"Максимальное число: {maxNum}");
// Console.WriteLine($"Минимальное число: {minNum}");
// result = maxNum - minNum;
// Console.WriteLine($"Разница между макс. и мин. = {result}");