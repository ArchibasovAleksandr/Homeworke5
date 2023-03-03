// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void FindDecimal ( int[] array)
// {
//     int sum = 0;
//     for(int i=0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0) sum += 1;
        
//     }
//     Console.WriteLine(sum);
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное трехзначное число");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное трехзначное число");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray= CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);

// FindDecimal(myArray);


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0;i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void FindSum (int[] array)
// {
//     int sum = 0;
//     for(int i = 1; i < array.Length; i=i+2)
//     {
//         sum = sum + array[i];
//     }
//      Console.WriteLine(sum);
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray= CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// FindSum(myArray);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    var random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        double num = random.NextDouble() * (maxValue - minValue) + minValue;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void ShowArray (double[] array)
{
    for(int i = 0;i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double FindDifference(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        double max = array[i];
        double min = array[i];
        if(array[i] > max) max = array[i];
        else min = array[i];
    }
    Console.WriteLine(max, min);
} 

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of array element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of array element");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] array= CreateRandomArray(size, minValue, maxValue);
ShowArray(array);
Console.WriteLine(FindDifference(array));