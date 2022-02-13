namespace ClassNEW;
public class Class_C
{
    ///<summary>
    ///example of class from lesson
    ///<summery>
    public static int MaximumValue(int a, int b)
    {
        if (a > b) return a;
        return b;
    }

    ///<summary>
    /// this function reterns 0 if fault and number if pass
    ///<summery>
    public static int GetNumber()
    {
        Console.WriteLine("Press positive number below please");
        int number = 0;
        string lines = Console.ReadLine();
        if(!int.TryParse(lines, out number))
        {
            Console.WriteLine("This value is not positive");
        }
        return number;
    }


    ///<summary>
    /// check area of dot for task 19
    ///<summery>
    public static int CheckArea(int x, int y)
    {
        if((x > 0) & (y > 0)) return 1;
        if((x > 0) & (y < 0)) return 2;
        if((x < 0) & (y > 0)) return 3;
        return 4;
    }

    ///<summary>
    /// show values for sectors for task 20
    ///<summery>
    public static void ShowSector(int sector)
    {
        switch(sector)
        {
            case 1:
                Console.WriteLine("X value from 0 to infinity, Y value from 0 to infinity");
                break;
            case 2:
                Console.WriteLine("X value from negative infinity to 0, Y value from 0 to infinity");
                break;
            case 3:
                Console.WriteLine("X value from negative infinity to 0, Y value from negative infinity to 0");
                break;
            case 4:
                Console.WriteLine("X value from 0 to infinity, Y value from negative infinity to 0");
                break;
        }
    }
        
    ///<summary>
    /// check number for task 21
    ///<summery>
    public static bool CheckPolyndrome()
    {
        Console.WriteLine("Please enter the number");
        string ComplexNumber = Console.ReadLine();
        for (int i = 0; i < ComplexNumber.Length; i++)
        {
            if (ComplexNumber[i] != ComplexNumber[ComplexNumber.Length - i - 1]) return false;
        }
        return true;
    }

/*
    ///<summary>
    /// fill the array of vector for task 22
    ///<summery>
    public static int Fill_Array(int point)
    {
        int[] first_point = {1, 2, 3};
        int[] second_point= {3, 2, 1};                        //  In this example there are only 2 dots
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
    }

    ///<summary>
    /// find the lengh of vector for task 22
    ///<summery>
    public static int Distance()
    {
        double distance = 0;
        for(int i = 0; i < 3; i++)
        {
            distance = Math.Pow(first_point[i] - second_point[i], 2);
        }
        distance = Math.Sqrt(distance);
    }
*/
    ///<summary>
    /// check number for task 23
    ///<summery>
    public static void PrintSquare(int number)
    {
        Console.WriteLine("Please enter the number");
        for(int i = 1; i <= number; i++)
        {
            Console.WriteLine(Math.Pow(i, 2));
        }
    }

    ///<summary>
    /// print Cube for task 24
    ///<summery>
    public static void FindCube(int number)
    {
        number = Class_C.GetNumber();
        for(int i = 1; i < number; i++)
        {
        Console.WriteLine($"{i} ^ 3 = {Math.Pow(i, 3)}");
        }
    }


    ///<summary>
    /// print sum for task 25
    ///<summery>
    public static int PrintSum(int number)
    {
        int sum = 0;
        for(int i = 1; i < number; i++)
        {
            sum += i;
        }
        return sum;
    }
}
