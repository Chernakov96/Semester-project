// Написать программу, которая из имеющегося массива строк
// 1. Формирует массив из строк, длина которых меньше либо равна 3 символа.
// (первоначальный массив вводится с клавиатуры или задается на старте выполнения алгоритма)


String[] CreateArrayElements(int numberOfElems)
{
    string[] array = new string[numberOfElems];
    for (int i = 0; i < numberOfElems; i++)
    {
        Console.WriteLine($"Элемент номер {i+1} равен: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите цифру, которая является размером массива");
int numberOfElements = Convert.ToInt32(Console.ReadLine());
string[] userArray = CreateArrayElements(numberOfElements);
PrintArray(userArray);