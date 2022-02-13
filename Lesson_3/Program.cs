//                      При запуске файла задания выполняются последовательно

using ClassNEW;

//  18  Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
Console.WriteLine("Task #1. \nCheck theory");
bool X_Value;
bool Y_Value;                                                                                   //  variables were made

Console.WriteLine("Please write 'true' or 'false' for X");
X_Value = bool.Parse(Console.ReadLine());
Console.WriteLine("Please write 'true' or 'false' for Y");
Y_Value = bool.Parse(Console.ReadLine());                                                       //  Get values, NEED TO USE WORDS

if ((!(X_Value || Y_Value)) == (!X_Value & !Y_Value)) Console.WriteLine("Theory that -(X OR Y) = -X AND -Y is right");     //  Check theory, Actually, it's possible just to print "theory is right)"
else
{
    Console.WriteLine("Theory is wrong");
}

//  20  Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("\nTask #2. \nSector's description");
int sector;                                                                                     //  init variable
Console.WriteLine("Press number of sector from 1 to 4");
sector = Class_C.GetNumber();                                                                   //  get a value to variable
Class_C.ShowSector(sector);                                                                     //  get the description of the sector


//  22  Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("\nTask #3. \nDistance between dots");
int[] first_point = {1, 2, 3};
int[] second_point= {3, 2, 1};                                                                  //  In this example there are only 2 dots

//  fill coordinates of dots, честно пытался передать массив или его указатель в функцию, но не получилось
Console.WriteLine("Fill coordinates of first dot");
Console.WriteLine("Please enter the X coordinate");
first_point[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the Y coordinate");
first_point[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the Z coordinate");
first_point[2] = int.Parse(Console.ReadLine());
Console.WriteLine("\nFill coordinates of second dot");
Console.WriteLine("Please enter the X coordinate");
second_point[0] = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the Y coordinate");
second_point[1] = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the Z coordinate");
second_point[2] = int.Parse(Console.ReadLine());

double distance = 0;    
for(int i = 0; i < first_point.Length; i++)                                                 //      it's possible to use 2D, 3D
    {
    distance += (float)Math.Pow(first_point[i] - second_point[i], 2);
    }
distance = Math.Sqrt(distance);
Console.WriteLine(distance);



//  24  Найти кубы чисел от 1 до N
Console.WriteLine("\nTask #4. \nShow cubes");
int Number_Cube = 0;                    //  init variable
Class_C.FindCube(Number_Cube);          //  print the result