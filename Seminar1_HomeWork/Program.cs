// // Задача №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Console.Clear();
// Console.WriteLine("Введите первое число:");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber<secondNumber)
// {
//     Console.WriteLine("наибольшее число:"+ secondNumber);
// }
// else
// {
//     Console.WriteLine("Наибольшее число:"+ firstNumber);
// }

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Console.Clear();
// Console.WriteLine("Введите первое число:");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// int thirdNumber = Convert.ToInt32(Console.ReadLine());

// int A = firstNumber;
// int B = secondNumber;
// int C = thirdNumber;
// int max = 0;

// if (A > B)
// {
//     max = A;
// }
// else if (B > C)
// {
//     max = B;
// }
// else if (C > A)
// {
//     max = C;
// }
// Console.WriteLine("Максимальное число:" + max);

// // Задача №6 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Console.Clear();
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number %2 == 0)
// {
//     Console.WriteLine("Число чётное");
// }
// else
// {
//     Console.WriteLine("Число нечётное");
// }

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 1)
{
    if (number % 2 == 0)
    {
        Console.Write(number + ", ");
        number = number - 1;
    }
    else
    {
        number = number - 1;
    }
}