// Программа выводит массив из строк, состоящих из элементов исходного текстового массива, длина которых меньше или равна 3
Console.Clear();

string[] text = new string[]  {"1", "22", "333", "4444", "abc", "Fhkljh", "Rtewne"};
Console.WriteLine("Исходный массив:");
Console.Write($"[{string.Join("  ", text)}]");
Console.WriteLine();
Console.WriteLine("Элементы, длина которых меньше или равна 3:");
Console.Write($"[{string.Join("  ", GetArraySpecElements(text, 3))}]");

string[] GetArraySpecElements(string[] array, int len) //Метод возврвщает массив из элементов строкового массива array, длина которых меньше или равна заданной - len
{
    string[] result = new string[GetNumberSpecElements(array, len)];
    int index = 0;
    for (int i = 0; i < array.Length-1; i++)
    {
        if (array[i].Length <= len)
        {
            result[index] = array[i];
            index++;
        }
    }
return result;
}

int GetNumberSpecElements(string[] array, int len) //Метод возврвщает количество элементов в строковом массиве array, длина которых меньше или равна заданной - len
{
int number = 0;
for (int i = 0; i < array.Length-1; i++)
{
    if (array[i].Length <= len) number++;
}
return number;
}