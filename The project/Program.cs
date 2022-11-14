// Написать программу, которая из имеющегося массива строк
// 1. Формирует массив из строк, длина которых меньше либо равна 3 символа.
// (первоначальный массив вводится с клавиатуры или задается на старте выполнения алгоритма)

//Создание массива элементов
String[] CreateArrayElements(int numberOfElems)
{
    string[] array = new string[numberOfElems];
    for (int i = 0; i < numberOfElems; i++)
    {
        Console.WriteLine($"Элемент номер {i + 1} равен: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

//Вывод массива в консоль
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

//Вычисление размера итогового массива
int amountOfElemsInResultArray(string[] array, int targetLength)
{
    int amountOfElements = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= targetLength)
        {
            amountOfElements = amountOfElements + 1;
        }
    }
    return amountOfElements;
}

//Отбор элементов, соответствующих заданной длине, в результирующий массив
string[] FormResultArray(string[] array, int targetLength)
{
    int numberOfElements = 0;
    string[] resultingArray = new string[amountOfElemsInResultArray(array, targetLength)];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= targetLength)
        {
            resultingArray[numberOfElements] = array[i];
            numberOfElements++;
        }
    }

    return resultingArray;
}


Console.WriteLine("Введите цифру, которая является размером массива"); //Пользователь задает длину массива
int numberOfElements = Convert.ToInt32(Console.ReadLine());


string[] userArray = CreateArrayElements(numberOfElements);//Пользователь вводит с клавиатуры элементы массива
Console.WriteLine("Введенный пользователем массив:");
PrintArray(userArray);//Изначальный массив выводится в консоль

string[] resultArray = FormResultArray(userArray, 3);//Происходит отбор в новый массив по длине элемента
Console.WriteLine("Массив с отобранными элементами:");
PrintArray(resultArray);//Результирующий массив выводится в консоль
