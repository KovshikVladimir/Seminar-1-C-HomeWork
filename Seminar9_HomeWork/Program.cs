int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
int NaturalNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    if (m > n)
    {
        Console.Write($"{NaturalNumbers(m, n + 1)}, ");
    }
    return n;
}
int CountSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountSum(m, n - 1);
}
int AkkermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;   // Сначала написал n++, и 15 минут возмущался, что не работает
    if (m > 0 && n == 0)
        return AkkermanFunction(m - 1, 1);
    else
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));

}

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1

// int number = InputInt("Введите число N: ");
// int numberTo = 1;
// Console.WriteLine(NaturalNumbers(number, numberTo));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int m = InputInt("Введите M:");
// int n = InputInt("Введите N:");
// Console.WriteLine($"Сумма элементов от {m} до {n} = {CountSum(m,n)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.WriteLine("Введите два положительных числа: M и N.");
// int m = InputInt("Введите M: ");
// int n = InputInt("Введите N: ");
// Console.WriteLine(AkkermanFunction(m, n));