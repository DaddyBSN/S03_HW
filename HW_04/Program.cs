// Показать кубы чисел от 1 до N, заканчивающихся на четную цифру
//

Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine() ?? "0");
double res = 0;
int i = 0;

for (i = 1; i <= num; i++)
{
    res = Math.Pow(i, 3);
    if (res%2 == 0) Console.WriteLine(res);
}
