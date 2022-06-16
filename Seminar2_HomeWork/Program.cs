// Доп. задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// int firstNumber = Typein("Введите первое число: ");
// int secondNumber = Typein("Введите второе число: ");

// if (Square(firstNumber) == secondNumber || Square(secondNumber) == firstNumber)
// {
//   Console.WriteLine("Да, является");
// }
// else
// {
//     Console.WriteLine("Нет, не является");
// }

// int Typein(string output)
// {
//     Console.Write(output);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int Square(int a)
// {
//     return a * a;
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// int number = Typein("Введите цифру: ");

// if (number == 6 || number == 7)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }


// int Typein(string output)
// {
//     Console.Write(output);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// int number = Typein("Введите цифру: ");

// int thirdNumber = number % 10;

// Console.WriteLine(thirdNumber);


// int Typein(string output)
// {
//     Console.Write(output);
//     return Convert.ToInt32(Console.ReadLine());
// }
// Работает только для 3-х значных, нужен массив (возможно)

//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int number = Typein("Введите цифру: ");

int firstNumber = number / 100;
int thirdNumber = number % 10;

int secondNumber = Formula(number);

Console.WriteLine("Второе число: "+secondNumber);

int Formula(int number)
{
    return (number - (firstNumber * 100 + thirdNumber))/10;
}

int Typein(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}