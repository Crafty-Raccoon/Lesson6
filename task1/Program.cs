//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)

//0, 7, 8, -2, -2-> 2

//1, -7, 567, 89, 223-> 3



void PrintArray(int[] arr)
{
    int length = arr.Length;
    int index = 0;
    Console.Write('[');
    while (index < length)
    {
        Console.Write($" {arr[index]}, ");
        index++;
    }
    Console.Write(']');
}

int[] NumsIntake(string nums)
{
    int[] arr = Array.ConvertAll(nums.Trim().Split(' '), Convert.ToInt32);
    return arr;
}

int AboveZero(int[] arr)
{
    int counter = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr[i] != 0 && arr[i] > 0)
        {
            counter++;
        }
    }
    
    return counter;
}

Console.WriteLine("Введите любое количество чисел через пробел");

int[] array = NumsIntake(Console.ReadLine() ?? "0");

PrintArray(array);
Console.Write($" -> Больше нуля {AboveZero(array)} чисел");