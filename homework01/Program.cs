// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
int[] Array()
{
    Console.Write("Введите сколько чисел вы будете вводить: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for(int i = 0; i<size; i++)
    {  
        Console.Write($"Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

void CountArray(int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++)
        if(array[i]>0)
            count++;
    Console.WriteLine(count);
    
}

int[] myArray = Array();
ShowArray(myArray);
CountArray(myArray);