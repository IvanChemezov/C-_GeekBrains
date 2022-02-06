//                      При запуске файла задания выполняются последовательно


//Задача 2:** Даны два числа. Показать большее и меньшее число

int number_1_1 = 0, number_1_2 = 0;                         // make variables

Console.WriteLine("Task #2");
Console.WriteLine("Please type first number");
number_1_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please type second number");
number_1_2 = int.Parse(Console.ReadLine());                 // get values

if (number_1_1 >= number_1_2)                               // compare values and print results
{
    Console.WriteLine("the biggest number is the first one");
    Console.WriteLine(number_1_1);
}
else
{
    Console.WriteLine("the biggest number is the second one");
    Console.WriteLine(number_1_2);
}


//Задача 4:** Найти максимальное из трёх чисел.

int number_2_1 = 0, number_2_2 = 0, number_2_3 = 0;          // make variables

Console.WriteLine("Task #4");
Console.WriteLine("Please type first number");
number_2_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please type second number");
number_2_2 = int.Parse(Console.ReadLine());        
Console.WriteLine("Please type third number");
number_2_3 = int.Parse(Console.ReadLine());                 // get values

if (number_2_1 >= number_2_2)                               // compare values and print results
{
    if (number_2_1 >= number_2_3)
    {
        Console.WriteLine("the biggest number is the first one");
        Console.WriteLine(number_2_1);
    }
    else
    {
        Console.WriteLine("the biggest number is the third one");
        Console.WriteLine(number_2_3);
    }
}
else
{
    if (number_2_2 >= number_2_3)
    {
        Console.WriteLine("the biggest number is the second one");
        Console.WriteLine(number_2_2);
    }
    else
    {
        Console.WriteLine("the biggest number is the third one");
        Console.WriteLine(number_2_3);
    }
}



//Задача 6:** Выяснить является ли число чётным 
int number_3_1 = 0;                                         //  make variables

Console.WriteLine("Task #6");
Console.WriteLine("Please type the number");
number_3_1 = int.Parse(Console.ReadLine());                 //  get values

if (number_3_1 % 2 == 0)
{
    Console.WriteLine("the number is even");
}
else 
{
    Console.WriteLine("the number is odd");
}



//Задача 8:** Показать чётные числа от 1 до N.
int number_4_1 = 0;                                         //  make variables

Console.WriteLine("Task #8");
Console.WriteLine("Please type the number");
number_4_1 = int.Parse(Console.ReadLine());                 //  get values
for (int i = 2; i < number_4_1; i++)                        //  print all numbers from 2 to number_1, step is 2
{
    Console.WriteLine(i);
    i++;                                                    //  костыль ускоряющий работу. чтоб не проверять четность, просто каждый шаг + 2 начиная с 2
}


//*/