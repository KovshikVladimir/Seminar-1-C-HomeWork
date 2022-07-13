int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
}
// Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, 
// так чтобы в одной группе все числа в группе друг на друга не делились? 
// Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.


int number = Input("Введите число N: ");
int[] array = new int[number];
int count = 1;
Console.WriteLine("");
FillArray(array);
PrintArray(array);
if (number < Math.Pow(10, 22))
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            int index = 0;
            int[] arraySecond = new int[array.Length];
            for (int f = i; f < array.Length; f++)
            {
                if (array[f] % array[i] != 0 || array[f] / array[i] == 1)
                {
                    arraySecond[index] = array[f];
                    index++;
                }
            }
            for (int j = 1; j < arraySecond.Length; j++)
            {
                for (int l = j + 1; l < arraySecond.Length; l++)
                {
                    if (arraySecond[j] != 0 && arraySecond[l] % arraySecond[j] == 0)
                    {
                        arraySecond[l] = 0;
                    }
                }
            }
            for (int f = 0; f < array.Length; f++)
            {
                for (int m = 0; m < arraySecond.Length; m++)
                {
                    if (arraySecond[m] == array[f])
                    {
                        array[f] = 0;
                    }
                }
            }
            Console.Write($"Группа {count++}: ");
            for (int k = 0; k < arraySecond.Length; k++)
            {
                if (arraySecond[k] != 0)
                {
                    Console.Write(arraySecond[k] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
else
    Console.WriteLine("ERROR: N не может быть больше и равно 10^22");
