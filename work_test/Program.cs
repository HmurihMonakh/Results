
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите элемены массива:");
string[] array = new string[size];

for (int i = 0; i < size; i++)
{
    array[i] = Console.ReadLine()!;
}

string[] newArray = new string[size];


