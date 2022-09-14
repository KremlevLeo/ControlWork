/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 симвла. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциям, лучше обойтсь исключительно массивами.
Примеры:
["hello","2","world",";-)"]->["2",";-)"] */

string str = Console.ReadLine();
string[] arr = new string[] { str };
string[] res = new string[arr.Length];
FillArr(res);
PrintArr(res);

string[] FillArr(string[] arr)
{
    string[] resArr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        int res = arr[i].Length;
        if (res <= 3)
        {
            resArr[i] = arr[i];
        }
    }
    return resArr;
}
void PrintArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}