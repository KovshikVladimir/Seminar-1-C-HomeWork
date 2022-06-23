//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.Clear();
// int number = Input("Введите число:");
// int square = 1;

// while (square <= number)
// {
//     Console.Write(",");
//     int result = Pow(square);
//     Console.Write(result);
//     square++;

// }
// int Pow(int a)
// {
//     return a * a * a;
// }

// //Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Clear();
// int x1 = Input("Введите первую координату:");
// int y1 = Input($"Введите вторую координату: {x1} _");
// int z1 = Input($"Введите третью координату: {x1} {y1} _");
// Console.WriteLine($"A({x1};{y1};{z1})");
// int x2 = Input("Введите первую координату:");
// int y2 = Input($"Введите вторую координату: {x2} _");
// int z2 = Input($"Введите третью координату: {x2} {y2} _");
// Console.WriteLine($"A({x2};{y2};{z2})");

// int katet1 = Pow(x1-x2);
// int katet2 = Pow(y1-y2);
// int katet3 = Pow(z1-z2);

// double length = Math.Sqrt(katet1+katet2+katet3);
// int length2 = Convert.ToInt32 (Math.Sqrt(katet1+katet2+katet3));

// Console.WriteLine($"Расстояние от А до B = {length}");
// Console.WriteLine($"Расстояние от А до B (целое) = {length2}");

// //Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.Clear();
// int number = Input("Введите число: _");

// int firstNumber = number / 10000;
// int secondNumber = (number / 1000) % 10;
// int fourthNumber = (number % 100) / 10;
// int fifthNumber = number % 10;

// if (firstNumber == fifthNumber && secondNumber == fourthNumber)
// {
//     Console.WriteLine("Число является палиндромом");
// }
// else
// {
//     Console.WriteLine("Число не является палиндромом");
// }





// Методы

// int Pow(int a)
// {
//     return a * a;
// }

// int Input(string output)
// {
//     Console.WriteLine(output);
//     return Convert.ToInt32(Console.ReadLine());
// }