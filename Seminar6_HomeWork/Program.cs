// // Задача 41: Пользователь вводит с клавиатуры числа через запятую. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int result = 0;
// int i = 0;
// int[] inputs = new int[99];
// int number = InputNum("Введите число:");
// Console.WriteLine("Чтобы выйти, наберите: 999");
// while (number != 999)
// {
//     inputs[i] = number;
//     number = InputNum("Введите число:");
//     i++;
//     if (number > 0)
//     {
//         result++;
//     }
// }

//     PrintArray(inputs);
//     Console.WriteLine();
//     Console.WriteLine($"{result} - количество чисел больше 0");

// void PrintArray(int[] array)

// {
//     for (int j = 0; j < i; j++)
//     {
//         Console.Write(array[j] + " ");
//     }
// }
// int InputNum(string msg)

// {
//     Console.WriteLine(msg);
//     return Convert.ToInt16(Console.ReadLine());
// }


// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// int k1 = InputNum("Введите k1:");
// int b1 = InputNum("Введите b1:");
// int k2 = InputNum("Введите k2:");
// int b2 = InputNum("Введите b2:");

// int firstCoodrdinate = (-b2 + b1) / (k2 - k1);
// int secondCoordinate = k1 * firstCoodrdinate + b1;

// Console.WriteLine();
// Console.Write($"M [{firstCoodrdinate};{secondCoordinate}] - точка пересечения прямых A и B.");

// int[] StringToNumber(string input)
// {
//     int countNumbers = 1;

//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             countNumbers++;
//         }
//     }
//     int[] numbers = new int[countNumbers];
//     int index = 0;
//     for (int i = 0; i < input.Length; i++)
//     {
//         string tempString = "";

//         while (input[i] != ',')
//         {
//             if (i != input.Length - 1)
//             {

//                 tempString += input[i].ToString();
//                 i++;
//             }
//             else
//             {
//                 tempString += input[i].ToString();
//                 break;
//             }
//         }
//         numbers[index] = Convert.ToInt32(tempString);
//         index++;
//     }
//     return numbers;
// }

// Console.WriteLine("Введите числа через запятую:");
// int[] numbers = StringToNumber(Console.ReadLine());
// PrintArray(numbers);



// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
