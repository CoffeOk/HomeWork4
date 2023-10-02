/* На ввод: число num
на вывод: сума цифр числа num  */

int SumDigit (int x)
{
    int n;
    int sum = 0;
    while (x != 0)
    {
        n = x % 10;
        sum += n;
        x /= 10;
    }
    return sum;
}
int num;
Console.Write("Введите целое число: ");
while(!int.TryParse(Console.ReadLine(), out num))
    Console.Write("Ошибка ввода. Введите целое число: ");

int sd = SumDigit (num);
Console.Write ($"{num} -> {sd} ");