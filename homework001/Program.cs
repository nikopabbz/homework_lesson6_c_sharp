// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int Prompt(string msg)
{
    Console.Write(msg);
    bool count = int.TryParse(Console.ReadLine(), out int number);
    if (count)
    {
        return number;
    }
    throw new Exception("Вы ввели не число");
}
int[] Array(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите {i+1}-й элемент массива -> ");
        array[i] = int.Parse(Console.ReadLine() ?? "0");
        System.Console.WriteLine();
    }
    return array;
}
int PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) 
        {
            count++;
        }
    }
    return count;
}
void SetOutput(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}
void Check(int count)
{
    if (count > 0)
    {
        int[] array = Array(count);
        SetOutput(array);
        System.Console.WriteLine();
        System.Console.WriteLine($"Количество чисел больше 0 -> {PositiveNumbers(array)}");
    }
    else
    {
        System.Console.WriteLine("Вы ввели отрицательное число");
    }
}
int count = Prompt("Введите размер массива -> ");
Check(count);