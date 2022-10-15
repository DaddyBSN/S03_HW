// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число больше 1: ");
int num = int.Parse(Console.ReadLine() ?? "0");
int res = 1;
int i;

if (num < 1) 
{
    Console.WriteLine("Число меньше 1");
}

else
{
    for (i = 1; i <= num; i++)
    {
        res = i * res;
    }
    Console.WriteLine(res);
}