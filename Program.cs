/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 симвла. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциям, лучше обойтсь исключительно массивами.
Примеры:
["hello","2","world",";-)"]->["2",";-)"] */

string str = Console.ReadLine();
string[] words = str.Split(new char[] { ' ' });
string[] res = new string[words.Length];
res = FillArr(words);
Console.Write("[ ");
PrintArr(words);
Console.Write("] -> [ ");
PrintArr(res);
Console.WriteLine("]");

string[] FillArr(string[] arr)
{
    int tmp = 0;
    string[] resArr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resArr[tmp] = arr[i];
            tmp++;
        }
    }
    Array.Resize(ref resArr, tmp);
    return resArr;
}
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"'{arr[i]}' ");
    }
}