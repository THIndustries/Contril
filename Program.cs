Console.Clear();
// Написать программу, которая из имеющегося массива строк формиркет массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", ":-)"] -> ["2", ":-)"]


string[] CreateArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}й эллемент: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

string[] SortedArray(string[] array)
{
    int size = 0;
    for (int k = 0; k < array.Length; k++)
    {
        if (array[k].Length <= 3)
        {
            size = size + 1;
        }
    }
    string[] sortArray = new string[size];
    int i = 0;
    int j = 0;
    while (i < sortArray.Length)
    {
        for (j = 0; j < array.Length; j++)
        {
            if (array[j].Length < 4)
            {
                sortArray[i] = array[j];
                i++;
            }
        }
    }
    return sortArray;
}


    Console.Write("Заполним массив. Введите размер вашего массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] myArray = CreateArray(size);
    Console.Write("Изначальный массив: ");
    ShowArray(myArray);
    Console.Write("Отсортированный массив: ");
    string[] sortedArray = SortedArray(myArray);
    ShowArray(sortedArray);