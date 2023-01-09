// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении задачи не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


//тело программы

Console.Clear();

Console.WriteLine($"Введите элементы массива через запятую");
string newString = Console.ReadLine();

string[] array = StringToStringArray(newString);
PrintArray(array, "[", ", ", "]", "\"");

string[] finalArray = GetNewStringArrayFromOld(array, 3);
PrintArray(finalArray, " -> [", ", ", "]", "\"");

//методы

string[] StringToStringArray(string str)
{
    string[] arrString = str.Split(',');
    return arrString;
}

void PrintArray(string[] arr, string beginStr, string separatorElems, string endStr, string framing)
{
    Console.Write(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{framing}{arr[i]}{framing}{separatorElems}");
        else Console.Write($"{framing}{arr[i]}{framing}");
    }
    Console.Write(endStr);
}

string[] GetNewStringArrayFromOld(string[] arr, int ElementLength)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= ElementLength) size++;
    }
    string[] arr1 = new string[size];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= ElementLength) arr1[index++] = arr[i];
    }
    return arr1;
}
