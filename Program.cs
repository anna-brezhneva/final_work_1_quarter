//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.
// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

using System;
using static System.Console;
Clear();
string[] elements = new string[4] {"Hello", "2", "world", ":-)"};
string[] elements2 = NewArray(elements);
PrintArray(elements2);

string[] NewArray(string[] stringArray)
{
    string[] result = new string[stringArray.Length];
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
         {
            result[count] = stringArray[i];
            count++;
         }
     }
     return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
         Write($"{array[i]} ");
    }
    WriteLine();
}