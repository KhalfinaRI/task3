//  Одномерный массив из 10 int чисел (1; 100). Найти кол-во элементов массива, 
// значения которых лежат в отрезке [20,90].

void FillArray(int[] array)
{
    Console.WriteLine("Введите 10 чисел в отрезке от 1 до 100: ");
    for (int index = 0; 
        index < array.Length; 
        index++)
    {
        Console.WriteLine($"Введите число №[{index}] массива из {array.Length} элементов: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] ar, int min, int max)

{
    int count = 0;

    for (int position = 0; 
        position < ar.Length; 
        position++)
    {
        if((ar[position] < 1) || (ar[position] > 100))
    {
        Console.WriteLine($"Элемент №{position} в массиве не входит в заданный отрезок от {min} до {max}");
    }    
    else if ((ar[position] >= min) && (ar[position] <= max))
        {
            count++;
        }
    }
    
    Console.WriteLine($"Количество элементов массива со значением в отрезке от {min} до {max}: " + count);
}

int[] array = new int[10];

FillArray(array);
PrintArray(array, 20, 90);