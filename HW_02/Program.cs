// Подсчитать сумму цифр в числе
//Ввод ч, модуль ч, с=0 р=0, для с=0 и ч>0 с=с+р, р=ч%10 ч=ч/10, Вывод с

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
num = Math.Abs(num);
int sum = 0;
int res = 0;

for (sum = 0; num > 0; sum += res)
{
    res = num % 10;
    num = num / 10;
}
Console.WriteLine($"Сумма цифр во введенном числе = {sum}");