// Написать программу,которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 симмвола.

void PrintArray(string [] array)//------------------Функция для вывода массива
{
    Console.Write("[" + array[0]);
    for (int y = 1; y < array.Length; y++)
    {
        Console.Write(", " + array[y]);
    }
    Console.Write("]");
}

string []  Array (string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i].Length <=3 )
        {
            count ++;
        }
    }
    string [] newarray = new string [count];
    int j= 0;
    for(int i = 0;i < array.Length; i++)
    {
        if ( array[i].Length <= 3 )
        {
            newarray[j] = array[i];
            j++;   
        }
    }
    return newarray;
}

string [] array = { "Moscow", "123" , "Sity" , "abc", "New-York", "Pyt","frt"};
PrintArray(Array(array));

