// Задача :
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] array1 = new string[] { "hello","2","world",":-)","7t>", "hi" };
string[] array2 = new string[array1.Length];

void SaveInArray2(string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
        }
        j++;
    }
}
void PrintArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}" + ' ');
    }
    Console.WriteLine();
}
SaveInArray2(array1, array2);
Console.Clear();
PrintArray(array1);
PrintArray(array2);
