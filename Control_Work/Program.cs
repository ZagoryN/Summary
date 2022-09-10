/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

void FillArray(string?[] array)  //метод наполнения массива
{
    int length = array.Length;
    int index = 0;
    Console.WriteLine("Введите через Enter элементы массива:");
    while (index < length)
    {
        array[index] = Console.ReadLine();
        index++; 
    }
    
}

Console.Write("Введите количество элементов массива: ");
int numberOfElements = Convert.ToInt32(Console.ReadLine());

string[] arrayOfString;
arrayOfString = new string[numberOfElements];

FillArray(arrayOfString);
Console.WriteLine($"Исходный массив: [{string.Join(", ", arrayOfString)}]"); // напечатаем получившийся массив

