using Tyuiu.BayazitovEA.Sprint5.Task2.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] matr = {
                {-8, -1, -9},
                {8, 5, 5},
                {9, 6, -2}
            };

        Console.WriteLine("Исходный массив:");
        PrintArray(matr);

        DataService ds = new DataService();
        string res = ds.SaveToFileTextData(matr);
        Console.WriteLine(res);

        Console.ReadKey();
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}