Console.Clear();
Console.WriteLine("Please enter the value of lenght for INFO array");
int array_lenght = int.Parse(Console.ReadLine());

Console.WriteLine($"\nInfo Aray");                          //  Create and fill Info array
int[] info_array = new int[array_lenght];
int sum = 0;

for(int i = 0; i < array_lenght; i++)
{
    info_array[i] = new Random().Next(1, 10);
    sum += info_array[i];
    Console.Write($"{info_array[i]}\t");
}

Console.WriteLine($"\n\nData Aray");                        //  Create and fill Data array
int[] data_array = new int[sum];
for(int i = 0; i < sum; i++)
{
    data_array[i] = new Random().Next(0,2);
}

for(int i = 0; i < array_lenght; i++)                       //  Show Data array
{
    for(int j = 0; j < info_array[i]; j++)
    {
        Console.Write(data_array[j]);
    }
    Console.Write("\t");
}

Console.WriteLine($"\n\nResult Aray");                      //  Create and show Result array
double[] result_array = new double[array_lenght];
for(int i = 0; i < array_lenght; i++)
{
    double local_result = 0;
    for(int j = info_array[i] - 1; j >= 0; j--)
    {
        local_result += data_array[j] * (Math.Pow(2, info_array[i] - j - 1));
    }
    result_array[i] = local_result;
    Console.Write($"{result_array[i]}\t");
}