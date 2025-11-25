using Tyuiu.BayazitovEA.Sprint5.Task4.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        string x = $@"C:\\DataSprint5\InPutDataFileTask4V11.txt";

        Class1 ds = new Class1();
        double res = ds.LoadFromDataFile(x);

        Console.WriteLine(res);

        Console.ReadKey();
    }
}