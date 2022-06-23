Console.Clear(); // Не забудьте "разморозить" методы в самомой нижней части работы

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// int number = TypeIn("Введите число А: _");
// int stepen = TypeIn("Введите число B: _");
// int result = number;

// for (int count = 1; count < stepen; count++)
// {
//     result *= number;
// }
// Console.Write(result);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int number = TypeIn("Введите число: ");
// int result = 0;
// int fixedNumber = number;

// while (number > 0)
// {
//     result += number % 10;
//     number = number / 10;
// }
// Console.WriteLine($"Сумма цифр в числе {fixedNumber} равна {result}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.

// int[] array = new int[8];
// int[] array = {1,2,3,4,5,6,7,8};
// Console.Write("[ ");
// for (int digit = 0; digit < array.Length; digit++)
// {
//     // array[digit] = new Random().Next(0, 10);
//     PrintArray(array[digit]);
// }  
// Console.Write("]");







// int PrintArray(int array)
// {
//     Console.Write(array + " ");
//     return array;
// }



// int TypeIn(string output)
// {
//     Console.WriteLine(output);
//     return Convert.ToInt32(Console.ReadLine());
// }

