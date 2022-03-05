//                      При запуске файла задания выполняются последовательно

using ClassNEW;         // all functions starts from 180 line
using System;
using System.Linq;
/*
//  Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
Console.WriteLine("\nTask #1. \ncount numbers in array");
Class_C.CountNumbersInArray();

//  Задача 44: Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
// (b2-b1) / k1-k2

Console.WriteLine("\nTask #2. \nfind common point for y = k1 * x + b1 and y = k2 * x + b2");
float[] new_array = new float[4];
        for(int i = 0; i < 4; i++)
        {
            new_array[i] = float.Parse(new Random().Next(-100,100).ToString() + new Random().NextDouble().ToString());      //  get some randoms numbers
        }
Console.WriteLine($"k1 = {new_array[0]}\t");
Console.WriteLine($"b1 = {new_array[1]}\t");
Console.WriteLine($"k2 = {new_array[2]}\t");
Console.WriteLine($"b2 = {new_array[3]}\t");
float answer = float.Parse(((new_array[3] - new_array[1]) / (new_array[0] - new_array[2])).ToString()); 
Console.WriteLine($"For first equation point coordinates: \nx = {answer} \ny = {answer * new_array[0] + new_array[1]}");
Console.WriteLine($"For second equation point coordinates: \nx = {answer} \ny = {answer * new_array[2] + new_array[3]}");

/*  Задача 46: Написать программу масштабирования фигуры. Сделать так, чтобы:
1. Вершины фигуры задавались списком (в одну строку). Например: "(0,0) (2,0) (2,2) (0,2)".
2. Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
3. В результате были выводились полученные координаты.
При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"*/
/*
Console.WriteLine("\nEnter the coefficient of changing coordinates (chenge lenght between (0,0) and all points)");
string kExpend = Console.ReadLine();
string text = "(1,2) (3,4) (5,6) (10,2) (15,6)";
text = text.Replace("(", "");
text = text.Replace(")", "");
var data = text.Split(' ')
                .Select(item => item.Split(','))
                .ToArray();
for(int i = 0; i < data.Length; i++)
{
    for(int j = 0; j < data[i].Length; j++)
    {
        int result = 0;
        if(j == 0) Console.Write("(");
        result = int.Parse(data[i][j]);
        if(kExpend == "2")    Console.Write(result * 2);
        if(kExpend == "4")    Console.Write(result * 4);
        if(kExpend == "0.5")    Console.Write(result / 2);
        if(j+1 == data[i].Length) Console.Write(") ");
        else
        {
            Console.Write(",");
        }
    }
}

*/
