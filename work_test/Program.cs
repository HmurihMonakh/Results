
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите элемены массива:");
string[] array = new string[size];

for (int i = 0; i < size; i++)
{
    array[i] = Console.ReadLine()!;
}

string[] newArray = new string[size];

Massive(size);
Console.WriteLine("Вывод массива: ");
for (int i = 0; i < size; i++)
{
    if (newArray[i] is not null)
    {
        Console.Write($"{newArray[i]}, ");

    }
}

void Massive(int size)
{
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }

    }
}
