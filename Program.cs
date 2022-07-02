/*
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

int MaxSize = 3;
int N = ArraySize("размер массива: ");
string[] array = new string[N];
string[] ArrayAfterFind = new string[N];

InputArray(array);
PrintArray(array, N);
int SizeArray = FindMaxSizeInArray(array, ArrayAfterFind, MaxSize);
Console.WriteLine();
PrintArray(ArrayAfterFind, SizeArray);


int ArraySize (string element) {
    int value;
    Console.Write($"Введите {element}");
    while(!int.TryParse(Console.ReadLine(), out value) || value <= 0){
        Console.Write($"Ошибка ввода. Введите {element}");
    }
    return value;
}

void InputArray (string[] arr) {
    for (int i = 0; i < arr.Length; i++){
        Console.Write("Введите значение в массив: ");
        arr[i] = Console.ReadLine()!;
    }
}

void PrintArray (string[] arr, int Sizearr) {
    if (Sizearr == 0) Console.Write("[]");
    else if (Sizearr == 1) Console.Write($"[\"{arr[0]}\"]");
    else { 
        for (int i = 0; i < Sizearr; i++) {
            if (i == 0) Console.Write($"[\"{arr[i]}\", ");
            else if (i == Sizearr-1) Console.Write($"\"{arr[i]}\"]");
            else Console.Write($"\"{arr[i]}\", ");
        }
    }
}

int FindMaxSizeInArray (string[] ArrStart, string[] ArrEnd, int Size) {
    int j = 0;
    for (int i = 0; i < ArrStart.Length; i++){
        if (ArrStart[i].Length <= Size) {
            ArrEnd[j] = ArrStart[i];
            j++;
        }
    }
    return j;
}