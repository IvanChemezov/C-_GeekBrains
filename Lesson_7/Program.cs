//                      При запуске файла задания выполняются последовательно
using ClassNEW;
Console.WriteLine("Please enter lenght of array for ALL tasks");
int lenght_array = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter depth of array for ALL tasks");
int deepness_array = int.Parse(Console.ReadLine());


//  Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.
Console.WriteLine("\nTask #1. \nShow double array with real numbers");
Class_C.Show_Random_Double_Array(deepness_array, lenght_array);


//Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.
Console.WriteLine("\nTask #2. \nset a massive with the rule Amn = m+n");
int[,] double_aR = new int[deepness_array, lenght_array];
for(int i = 0; i < deepness_array; i++)
{
    for(int j = 0; j < lenght_array; j++)
    {
        double_aR[i, j] = i + j;
        Console.Write($"{double_aR[i, j]},\t");
    }
    Console.WriteLine();
}

//   Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.
Console.WriteLine("\nTask #3. \nShow user's number");
Class_C.Show_User_Number(lenght_array, deepness_array);

//  Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
Console.WriteLine("\nTask #4. \nFind average in collum");
Class_C.Find_Average(deepness_array, lenght_array);