﻿Console.Write("Введите число, для которого необходимо найти сумму его цифр: ");
int a = Convert.ToInt32(Console.ReadLine());
int b =0, c, v = a;
while (v>0)
{
    c = v % 10;
    b = b + c;
    v = v/10;
}
Console.Write("Сумма цифр числа {0} равна {1}", a, b);
