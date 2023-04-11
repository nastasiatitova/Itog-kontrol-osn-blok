string[] Print()
    {
    Console.Write("Введите массив строк через пробел: ");
    string[] array = Console.ReadLine().Split();
    return array;
    }



string[] array = Print();

void GeneratArray(string[] array)
{
string[] newarray = new string[array.Length];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <=3)
    newarray[j] = array[i];
    j++;
}
for (int i = 0; i < j; i++)
        {
            Console.Write(newarray[i] + " ");
}
}

Console.WriteLine();
Console.Write("Новый массив строк:");
GeneratArray(array);
Console.WriteLine();