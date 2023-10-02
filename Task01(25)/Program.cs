/* Ввод: числа "а" и "b"
Вывод: "а" в натуральной степени "b" */


bool NatureNum (int y)
{
    if (y > 0) return true;
    return false;
}

int Stepen (int x, int y)
{
    int degree = 1;
    for (int i = 1; i <= y; i++)
    {
        degree *= x;
    }
    return degree;
}

int a, b;
Console.Write ("Введите целое число a: ");
while (!int.TryParse (Console.ReadLine(), out a))
    Console.Write ("Ошибка ввода. Введите целое число: ");

EnterB:
Console.Write ("Введите целое число b: ");
while (!int.TryParse (Console.ReadLine(), out b))
    Console.Write ("Ошибка ввода. Введите целое число: ");

bool nn = NatureNum (b);
int s = Stepen (a, b);
if (nn == true)
{
    Console.Write ($"{a}, {b} -> {s} ");
}
else
{
    Console.WriteLine ($"Ошибка ввода. {b} не является натуральным числом");
    goto EnterB;
}


