//                      При запуске файла задания выполняются последовательно



//  Задача 10:** Показать вторую цифру трёхзначного числа.
Console.WriteLine("Task #1");
int SECOND_DIGIT = 1;
int THIRD_DIGIT = 2;
string number_task_1;

Console.WriteLine("Please enter the number");
number_task_1 = Console.ReadLine();

while ((Math.Abs(int.Parse(number_task_1)) < 100) | (Math.Abs(int.Parse(number_task_1)) > 999))    //  Преобразование в int проверка что число трехзначное и не содержит букв
{
    Console.WriteLine("The number is wrong. There is no second digit");
    Console.WriteLine("Please enter the number");
    number_task_1 = Console.ReadLine();
}

if(int.Parse(number_task_1) > 0) Console.WriteLine(number_task_1[SECOND_DIGIT]);                   //   Вывод второй цифры числа
else 
    Console.WriteLine(number_task_1[THIRD_DIGIT]);


//  Задача 12:** Удалить вторую цифру трёхзначного числа.
Console.WriteLine("Task #2");
int number_task_2;
do
{
    Console.WriteLine("Please enter the number");
    number_task_2 = int.Parse(Console.ReadLine());
}
while (number_task_2 < 100 || number_task_2 > 999);

int numbers = number_task_2 % 10;
int hundred = number_task_2 / 100 % 10;
number_task_2 = numbers + hundred * 100;
Console.WriteLine(number_task_2);                       //  Данный способ показывает вторую цифру любого числа



//  Задача 14:** Найти третью цифру числа или сообщить, что её нет.
Console.WriteLine("Task #3");
string number_task_3;

Console.WriteLine("Please enter the number");
number_task_3 = Console.ReadLine();

while (int.Parse(number_task_3) < 100)                                       //  Проверка на отрицательные числа и текст
{
    Console.WriteLine("The number is wrong. There is no third digit");
    Console.WriteLine("Please enter the number");
    number_task_3 = Console.ReadLine();
}
Console.WriteLine(number_task_3[THIRD_DIGIT]);                              //  Вывод третьей цифры любого числа  



//  Задача 16:** Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Task #4");
int day_of_the_week = 0;
do
{
    Console.WriteLine("Please enter the number of day");
    day_of_the_week = int.Parse(Console.ReadLine());                            //  Получение числа с консоли
} 
while ((day_of_the_week > 7) || (day_of_the_week < 1));                         //  Проверка что число введено верно


if (day_of_the_week == 6 | day_of_the_week == 7)                                //  Если день нед. суббота или воскресенье - выходной
{
    Console.WriteLine("It's a weekend day! You can still go to work!");         
}
else
{
    Console.WriteLine("It's a working day( You must go to work!");
}
