/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

int magic = 3;
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

if (numberOfElements <= 0) Console.WriteLine("Массив не может быть инициирован, количество элементов должно быть больше 0.");

else
{
    string[] arrayOfString;
    arrayOfString = new string[numberOfElements];

    FillArray(arrayOfString);
    
    int count = 0;
    //проверка: подсчет количества строк, состоящих из 3 или менее элементов
    /*
    for (int i = 0; i < arrayOfString.Length; i++) 
    {
        Console.WriteLine(arrayOfString[i].Length);
    }
    */

    for (int i = 0; i < arrayOfString.Length; i++)
    {
        if (arrayOfString[i].Length <= magic) count++;
    }
    //Console.WriteLine(count); 
    

    string[] resultArrayOfString;   // инициализация нового массива
    resultArrayOfString = new string[count];
    int j = 0;

    for (int i = 0; i < arrayOfString.Length; i++)
    {
        if (arrayOfString[i].Length <= magic)
        {
            resultArrayOfString[j] = arrayOfString[i];
            j++;
        }
    }

    Console.WriteLine($"Исходный массив: [{string.Join(", ", arrayOfString)}]"); // печатаем исходный массив
    Console.WriteLine($"Массив, состоящий из строк, длина которых три или менее символов: [{string.Join(", ", resultArrayOfString)}]"); // печатаем массив-результат
}
