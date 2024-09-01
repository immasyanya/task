// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void Main()
{
int arraySize = ReadInt("Введите размер массива: ");
string[] array = GenerateArray(arraySize);
PrintArray(array);

}

void PrintArray(string[] arrayForPrint)
{
for (int i = 0; i < arrayForPrint.Length; i++)
System.Console.Write(arrayForPrint[i] + " ");

System.Console.WriteLine();
}

string[] GenerateArray(int size)
{
string[] tempArray = new string[size];

for (int i = 0; i < tempArray.Length; i++){
    System.Console.Write("Введите элемент: ");
    tempArray[i] = Console.ReadLine();
}
return tempArray;
}

int ReadInt(string msg)
{
System.Console.Write(msg);
return Convert.ToInt32(Console.ReadLine()); // 13
}

Main();