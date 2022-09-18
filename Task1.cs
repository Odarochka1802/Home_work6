/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите числа через пробел: ");
int[] array = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();

void possitiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"В массиве больше 0: {count} элемента");
}


try
{
    possitiveNumbers(array);
}
catch (FormatException)
{
    Console.WriteLine("Неверный формат ввода!");
}
