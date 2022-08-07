1.Для того чтобы создать новый массив, необходимо знать количество эллементов в нём. Заранее мы не можем знать сколько же будет  строк с 3-х знаной и менее длиной.
Поэтому, в первую очередь запустим цикл for по первому массиву(array) и через условие if найдём количество (count) нужных строк.

    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i].Length <=3 )
        {
            count ++;
        }
    }

2.После нахождения count переходим к созданию к заполнению массива (newarra)
Так же пробегаемся по первому массиву и уже не считаем а добавляем нужную строку в новый массив используя цикл for  и условие if:

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

3.Новый массив получен. Осталось только вывести его.
Используем функцию PrintArray

    void PrintArray(string [] array)
    {
        Console.Write("[" + array[0]);
        for (int y = 1; y < array.Length; y++)
        {
            Console.Write(", " + array[y]);
        }  
        Console.Write("]");
    }


