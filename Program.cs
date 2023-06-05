// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CheckArray(string[] array1)
{
    
    int count = 0;
    int countArrayCheck = 0;
    for(int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length < 4)
        {
            count++;
        }        
    }

    string[] arrayCheck = new string[count];
    for(int i = 0; i < array1.Length; i++)
    {

        if(array1[i].Length < 4)
        {
            arrayCheck[countArrayCheck] = array1[i];
            countArrayCheck++; 
        }
    }
    PrintArray(arrayCheck);
    return arrayCheck;
}

void PrintArray(string[] array2)
{
    for(int i = 0; i < array2.Length; i++)
    {
        System.Console.Write(array2[i] + " ");
    }
}


string[] array = {"Hello", "2", "wor", ":-)"};

CheckArray(array);
