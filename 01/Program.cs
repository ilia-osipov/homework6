// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.Write("Введите любое количество чисел через пробел: ");
string numbers = Console.ReadLine();

int[] array = numbers.Split(' ').Select(int.Parse).ToArray();
Console.WriteLine($"Чисел больше 0: {Positive(array)}");

int Positive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count += 1;
    }
    return count;
}
