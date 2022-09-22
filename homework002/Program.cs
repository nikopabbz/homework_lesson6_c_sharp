// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
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
(double, double) LinearFunction(double k1, double k2, double b1, double b2)
{
    double x = 0;
    double y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * x) + b1;
    return (x, y);
}
void Check(double k1, double k2, double b1, double b2)
{
    if (k1 == k2 && b1 != b2) System.Console.WriteLine("Линии параллельны");
    else if (k1 == k2 && b1 == b2) System.Console.WriteLine("Линии совпадают");
    else System.Console.WriteLine($"Линии пересекаются в точке {LinearFunction(k1, k2, b1, b2)}");
}
double k1 = Prompt("Введите k1 -> ");
double k2 = Prompt("Введите k2 -> ");
double b1 = Prompt("Введите b1 -> ");
double b2 = Prompt("Введите b2 -> ");
Check(k1, k2, b1, b2);

