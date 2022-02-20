//                      При запуске файла задания выполняются последовательно

using ClassNEW;         // all functions starts from 180 line


Console.WriteLine("Please enter length of array for all tasks");
int arrayLenght = int.Parse(Console.ReadLine());                    //  arrays will be different, nut length will be the same


//  Задача 34: Написать программу для замены элементов массива на противоположные.
Console.WriteLine("\nTask #1. \nchange numbers to opposide");
Class_C.ReversArray(arrayLenght);


//  Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечётных/чётных чисел.
Console.WriteLine("\nTask #2. \ncount even and odd numbers");
Class_C.CountOddAndEvenInArray(arrayLenght);


//  Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
Console.WriteLine("\nTask #3. \nshow sum of odd position numbers");
Class_C.SumOffOddNumbers(arrayLenght);


//  Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
Console.WriteLine("\nTask #4. \nshow differences between max and min value");
Class_C.DifferenceInArrayMaxMin(arrayLenght);