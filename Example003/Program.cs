// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементом массива.

void FillArray(double[] array)
{
    Console.Write("Задайте массив из вещественных чисел с ненулевой дробной частью: ");
    for (int index = 0; 
        index < array.Length; 
        index++) {
        Console.Write($"Введите число № [{index}] из [{array.Length}]: ");
        array[index] = Convert.ToDouble(Console.ReadLine());
    }
}


void PrintArray(double[] array)
{
    double min = array[0];
    double max = min;

        for(int index = 0; 
            index < array.Length; 
            index++)
        {
            if((array[index]*10)%10 == 0){
                Console.WriteLine($"Эллемент массива [{index}] введен с нулевой дробной частью! ");
            }
            else if(array[index] < min)
            {
                min = array[index];
            } else if (array[index] > max)
            {
            max = array[index];
            }
        }    
              
        Console.WriteLine($"Разница между макисмальным и минимальным значением элементов массива с ненулевой дробной частью: {(max - min)}");
}

double[] array = new double[5];

FillArray(array);
PrintArray(array);
