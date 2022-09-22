// Задача 3: (*)
// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
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
int[,] Array(int lines, int columns)
{
    int[,] array = new int[lines, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void SetOutput(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
int SumMinColumns(int[,] array)
{
    int index1 = 0;
    int min = array[0, index1];
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (array[j, i] < min)
            {
                min = array[j, i];
            }
        }
        sum = sum + min;
        min = array[0, index1+1];
    }
    return sum;
}
int SumMaxLines(int[,] array)
{
    int index1 = 0;
    int max = array[index1, 0];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
            }
        }
        sum = sum + max;
        max = array[index1+1, 0];
    }
    return sum;
}
int lines = Prompt("Введите количество строк -> ");
int columns = Prompt("Введите количество столбцов -> ");
int[,] array = Array(lines, columns);
SetOutput(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма максимальных значений по каждой строке = {SumMaxLines(array)}");
System.Console.WriteLine();
System.Console.WriteLine($"Сумма минимальных значений по каждому столбцу = {SumMinColumns(array)}");