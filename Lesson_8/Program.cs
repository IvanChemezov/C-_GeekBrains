//                      При запуске файла задания выполняются последовательно
using ClassNEW;

Console.WriteLine("Please enter lenght of array for ALL tasks");
int lenght_array = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter depth of array for ALL tasks");
int deepness_array = int.Parse(Console.ReadLine());                          //  Init variables

int[,] array_double = new int[deepness_array, lenght_array];
int[] array_shadow = new int[lenght_array];                                 //  Init arrays

//  Задача 57: Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

Console.WriteLine("\nTask #1\nSort arrays from max to min\n");
Console.WriteLine("Original Array");
for(int i = 0; i < deepness_array; i++)                                     //  Fill 2-deminsions array
{
    for(int j = 0; j < lenght_array; j++)
    {
        array_shadow[j] = array_double[i,j] = new Random().Next(0,10);
        Console.Write(array_double[i,j]);
    }
    Array.Sort(array_shadow);                                               //  Sort array which has all numbers in the line
    for(int k = 0; k < lenght_array; k++)
    {
        array_double[i, k] = array_shadow[lenght_array - 1 - k];            //  Equating Sorted and Original arrays
    }
    Console.WriteLine();
}
Console.WriteLine("\nNew Array");
for(int i = 0; i < deepness_array; i++)
{
    for(int j = 0; j < lenght_array; j++)
    {
        Console.Write(array_double[i,j]);
    }
    Console.WriteLine();
}

//  Задача 59: В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.WriteLine("\nTask #2\nFind the minimun sum of elements in 2 deminsion array");
int min_sum = 0, index_min = 0;
for (int i = 0; i < deepness_array; i++)                                        //  Fill 2-deminsions array
{
    int sum = 0;
    for (int j = 0; j < lenght_array; j++)
    {
        array_double[i, j] = new Random().Next(0, 10);
        Console.Write(array_double[i, j]);
        sum += array_double[i, j];                                              //  Find sum of a line
    }
    if (i == 0) min_sum = sum;
    Console.Write($"\t line #{i},\tsum = {sum}");                               //  show sum of a line
    if (sum < min_sum)                                                          //  compare minimun value and current value
    {
        index_min = i;
        min_sum = sum;
    }
    Console.WriteLine();
}
Console.WriteLine($"\nminimum sum of components on the line #{index_min}");


//  Задача 61: Найти произведение двух матриц.
Console.WriteLine("\nTask #3\nMultiple 2 matrix\n");
int[,] array_multiple = new int[lenght_array, deepness_array];
int[,] array_result = new int[deepness_array, deepness_array];

Console.WriteLine("First Matrix");                                          //  Show first matrix
for (int i = 0; i < deepness_array; i++)
{
    for (int j = 0; j < lenght_array; j++)
    {
        Console.Write(array_double[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine("\nSecond Matrix");
for (int i = 0; i < lenght_array; i++)                                     //  Fill and show second matrix
{
    for (int j = 0; j < deepness_array; j++)
    {
        array_multiple[i, j] = new Random().Next(0, 10);
        Console.Write(array_multiple[i, j]);
    }
    Console.WriteLine();
}

Console.WriteLine("\nResult Matrix");
for (int i = 0; i < deepness_array; i++)                                    //  multiple 2 matrix
{
    for (int j = 0; j < deepness_array; j++)
    {
        array_result[i, j] = 0;
        for(int k = 0; k < lenght_array; k++)
        {
            array_result[i,j] += array_double[i, k] * array_multiple[k, j];
        }
        Console.Write($"{array_result[i,j]}\t");
    }
    Console.WriteLine();
}

/*  Задача 63: Сформировать трехмерный массив не повторяющимися двузначными числами,
    показать его построчно, на экран выводя индексы соответствующего элемента*/

//  numbers mustn't repeated, but must be between 10 and 99, so 4x4x4 matrix was created
Console.WriteLine("\nTask #4\nCreate and show 3D array");
const int cube_side = 4;
int[,,] three_dimensions_array = new int[cube_side, cube_side, cube_side];

for(int hight = 0; hight < cube_side; hight++)
{
    Console.WriteLine($"\nLayer #{hight}\n");
    for(int wide = 0; wide < cube_side; wide++)
    {
        for(int lenght = 0; lenght < cube_side; lenght++)
        {
            three_dimensions_array[hight, wide, lenght] = 
            hight * cube_side * cube_side                   /*  new level bigger than previous on 4^2   */
            + wide * cube_side                              /*  new line bigger than previous on 4^1    */
            + lenght + 10;
            Console.Write($"{three_dimensions_array[hight, wide, lenght]}  ({hight}{wide}{lenght}) \t");
        }
        Console.WriteLine();
    }
}