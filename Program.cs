string[] basicArray = {"Hello", "2", "world", ":-)"};  // исходный массив
string[] resultArray = GetArray3Symbols(basicArray);  // сгенерировать новый массив строк из исходного
string firstArray = PrintArray(basicArray);  // печать исходного массива в строчку
string secondArray = PrintArray(resultArray);  // печать нового массива в строчку
Console.WriteLine(firstArray + " -> " + secondArray);  // вывод обеих массивов на консоль

int CountSymbols(string[] basicArray)   // метод подсчета элементов в массиве, длина которых меньше либо равна 3 символа
{
    int count = 0;
    foreach (string item in basicArray)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] GetArray3Symbols(string[] basicArray)  // для создания нового массива, состоящего из строк, длина которых меньше либо равна 3 символа
{
    int resultArrayLength = CountSymbols(basicArray);
    string[] resultArray = new string[resultArrayLength];
    int i = 0;
    foreach (string item in basicArray)
    {
        if (item.Length <= 3)
        {
            resultArray[i] = item;
            i++;
        }
    }
    return resultArray;
}

/*tring PrintArray(string[] array)   // метод печати исходного массива
{
    string stringArray = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            stringArray += $"\"{array[i]}\"";
            break;
        }
        stringArray += ($"\"{array[i]}\", ");
    }
    stringArray += "]";
    return stringArray;
}*/
