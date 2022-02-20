namespace ClassNEW;
public class Class_C
{
    ///<summary>
    /// SW for task # 34
    ///<summery>
    public static void ReversArray(int arrayLenght)
    {   
        int[] arrayOriginal = new int[arrayLenght].Select(x => new Random().Next(-100, 100)).ToArray();     //  Fill array with randoms numbers

        foreach(int element in arrayOriginal)                           //  Show original numbers
        {
            Console.Write($"{element}\t");
        }
        Console.WriteLine();

        for(int i = 0; i < arrayOriginal.Length; i++)                   //  Show reversed numbers
        {
            arrayOriginal[i] = 0 - arrayOriginal[i];
            Console.Write($"{arrayOriginal[i]}\t");
        }    
        Console.WriteLine();
    }

    ///<summary>
    /// SW for task # 36
    ///<summery>
    public static void CountOddAndEvenInArray(int arrayLenght)
    {
    int[] new_array = new int[arrayLenght].Select(x => new Random().Next(100, 1000)).ToArray();     //  fill array with numbers from 100 to 999
    int evenCount = 0;
    int oddCount = 0;
    for(int i = 0; i < arrayLenght; i++)
    {
        if(new_array[i] % 2 == 0) evenCount++;
        else
        {
            oddCount++;
        }
        Console.Write($"{new_array[i]}\t");    
    }
    Console.WriteLine($"\nThere are {oddCount} odd numbers in array");
    Console.WriteLine($"There are {evenCount} even numbers in array");
    }


    ///<summary>
    /// SW for task # 38
    ///<summery>
    public static void SumOffOddNumbers(int arrayLenght)        // count number on ODD position. like 1, 3, 5
    {
        int[] new_array = new int[arrayLenght].Select(x => new Random().Next(0, 1000)).ToArray();
        int sum = 0;
        for(int i = 1; i < arrayLenght; i++)
        {
            sum += new_array[i];
            Console.Write($"{new_array[i]}\t");    
            i++;
        }
        Console.WriteLine($"\n{sum} is a sum of all odd numbers in array");
    }

    ///<summary>
    /// SW for task # 40
    ///<summery>
    public static void DifferenceInArrayMaxMin(int arrayLenght)
    {
        float[] new_array = new float[arrayLenght];
        for(int i = 0; i < arrayLenght; i++)
        {
            new_array[i] = float.Parse(new Random().Next(-100,100).ToString() + new Random().NextDouble().ToString());      //  get some randoms numbers
        }
        float min_value = new_array[0];
        float max_value = new_array[0];
        for(int i = 0; i < arrayLenght; i++)
        {
            if(min_value > new_array[i]) min_value = new_array[i];
            if(max_value < new_array[i]) max_value = new_array[i];
        }
        Console.WriteLine($"maximum value in array = {max_value}");
        Console.WriteLine($"minimum value in array = {min_value}");
        Console.WriteLine($"{max_value - min_value} is a difference between maximum and minimum value in an array");
    }












    /*
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
            Console.WriteLine("This value is not positive or not a number");
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

    ///<summary>
    /// for task 26, analog POW functions
    ///<summery>
    public static int Get_Exp()
    {
        int base_number = 0;
        int result = 1;
        int exponent_number = 0;                                            //  make variables for math

        Console.WriteLine("please enter the value for base number");
        base_number = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter the value for exponent number");    //  get values for them
        exponent_number = int.Parse(Console.ReadLine());

        if (exponent_number < 0)                                            //  check that second number is positive
        {   
            Console.WriteLine("Fatal error");
            return 1;
        }

        for ( int i = 0; i < exponent_number; i++)                          //  exponent function
        {
            result = base_number * result;
        }
        return result;
    }


    ///<summary>
    /// for task 28, cube for even numbers
    ///<summery>
    public static int Count_numbers()
    {
        string user_number;
        int result = 0;                                                         // make variables

        Console.WriteLine("please enter the number or text with numbers");      //  get values for them
        user_number = (Console.ReadLine());
        
        for (int i = 0; i < user_number.Length; i++)
            {
            int j = 0;
            int.TryParse(user_number[i].ToString(), out j);
            result = result + j;
            }
            return result;
        }


    ///<summary>
    /// for task 30, cube for even numbers
    ///<summery>
    public static int Even_Cube(int a)
    {
        Console.WriteLine("please enter EVEN value for base number\t");   
        a = int.Parse(Console.ReadLine());                              //  get value for number
        if ((a % 2) == 0) return a*a*a;                                 //  Check that value is even
        else
        {
            Console.WriteLine("Fatal Error. \n Error number 404");
            return 0;
        }
    }

    ///<summary>
    /// for task 32, print array of 8 elements
    ///<summery>
    public static void Fill_Print_Matrix(int[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(0, 2);
                Console.Write($"{matrix[i, j]}");
            }
            Console.WriteLine();
        }
    }
    */
}



