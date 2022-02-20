//                      При запуске файла задания выполняются последовательно

using ClassNEW;         // all functions starts from 180 line


// Задача 26: Возведите число А в натуральную степень B, используя цикл.
Console.WriteLine("\nTask #1. \nanalog for Math.Pow function");
Console.WriteLine(Class_C.Get_Exp());        //  print information


// Задача 28: Подсчитайте сумму цифр в числе.
Console.WriteLine("\nTask #2. \ncount all numbers in the number or text");
Console.WriteLine(Class_C.Count_numbers());


// Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.
Console.WriteLine("\nTask #3. \ncubes for even numbers");
int even_number = 0;
Console.WriteLine($"the {Class_C.Even_Cube(even_number)} is a cube for enterd number");


// Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран
Console.WriteLine("\nTask #4. \nrandom numbers in array");
int[,] matrix = new int [2, 4];                 // it's a massive, 8 elements
Class_C.Fill_Print_Matrix(matrix);
