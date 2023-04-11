*Итоговая контрольная работа по основному блоку*

1. Создание репозитория https://github.com/nastasiatitova/Itog-kontrol-osn-blok.git
2. Блок схема крешению задачи:
![](blok.jpg)
3. Описание решения задачи:
* Вводится массива из строк
* Создание пустого массива для новых строк
* Установка счетчика для нового массива в 0
* Перебор каждой строки в исходном массиве
* Если длина строки меньше или равна 3 символам, то добавление ее в новый массив и увеличение счетчика
* Вывод нового массива.

*Программа:*

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