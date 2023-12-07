// Задача 2: Задайте массив на 10 целых чисел.  
// Определите количество чётных чисел в массиве.

void FillArray(int[] array)
{
    Console.WriteLine("Введите целые числа для создания массива: ");
    for (int index = 0; 
        index < array.Length; 
        index++)
    {
        Console.WriteLine($"Введите [{index}] элемент массива из {array.Length}: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
}


void EvenArray(int[] array)
{
    int position = 0;

    for (int index = 0; 
        index < array.Length; 
        index++)
    {
        if (array[index] % 2 == 0)
        {
            position++;
        }
    }

    Console.WriteLine($"Количество четных элементов массива = {position}");
}

int[] array = new int[10];
FillArray(array);
EvenArray(array);


