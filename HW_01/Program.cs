// Найти кубы чисел от 1 до N
// Ввод ч, для (сч = 1, сч <= ч, сч++), р = куб из сч, вывод результат

Console.WriteLine("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine() ?? "0");

for (int i = 1; i <= num; i++)
{
    double result = Math.Pow(i, 3);
    Console.WriteLine(result);
}
