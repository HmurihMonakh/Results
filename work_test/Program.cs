﻿
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите элемены массива:");
string[] array = new string[size];

for (int i = 0; i < size; i++)
{
    array[i] = Console.ReadLine()!;
}

string[] newArray = new string[size];
Console.WriteLine("Вывод массива: ");
for (int i = 0; i < size; i++)
{
    if (newArray[i] is not null)
    {
        Console.Write($"{newArray[i]}, ");

    }
}

