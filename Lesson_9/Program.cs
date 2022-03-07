//                      При запуске файла задания выполняются последовательно
Console.Clear();

Console.WriteLine("Please enter value min number (M)");
int min_number = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter max number (N)");
int max_number = int.Parse(Console.ReadLine());                          //  Init variables for All tasks

//  Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("\nTask #1\nShow numbers between M and N");

static void Show_Number_Rec(int min_number, int max_number)
{
    if (max_number > min_number)    Show_Number_Rec(min_number, max_number - 1);
    Console.Write($"{max_number}\t");
}
Show_Number_Rec(min_number, max_number);


//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("\n\nTask #2\nCount numbers between M and N");
static int Count_Sum_Rec(int min_number, int max_number)
{
    max_number--;                                                       //  because need to count numbers BETWEEN M and N
    int sum = 0;
    if (max_number > min_number + 1)    
    {
        sum = max_number + Count_Sum_Rec(min_number, max_number);
    }
    else
    {
        sum = max_number;
    }
    return sum;
}
Console.WriteLine(Count_Sum_Rec(min_number, max_number));


//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.WriteLine("\nTask #3\nFind result of Ackermann function");

static int Ackerman_function(int M, int N)
{
    if(M == 0) return N + 1;
    else if((M > 0) && (N == 0)) return Ackerman_function(M-1, 1);
    else 
    {
        return Ackerman_function(M-1, Ackerman_function(M, N-1));
    }
}
Console.WriteLine(Ackerman_function(min_number, max_number));