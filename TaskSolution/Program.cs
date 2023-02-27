// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами


string[] array = InitialArray();
PrintArray(array);
string[] result = CreateNewArray(array, 3);
Console.Write("->");
PrintArray(result);

string[] InitialArray()
{
    Console.Write("Введите строки через запятую: ");
    return Console.ReadLine().Split(",");
}
//Метод реализует пользовательский ввод значений элементов массива
int FindNumbersOfRows(string[] arr, int elength)
{

    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= elength)
        {
            count++;
        }
    }

    return count;
}
//Метод находит количетво строк с символами <= elength или в нашем случае 3

string[] CreateNewArray(string[] arr1, int elength)
{
    string[] arr2 = new string[FindNumbersOfRows(arr1, elength)];

    for (int i = 0, j = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= elength)
        {
            arr2[j] = arr1[i];
            j++;
        }
    }

    return arr2;
}
//Метод создает новый массив и заполняет его строками исходного массива, чья длина < 3 символов

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
//Метод распечатывает массив