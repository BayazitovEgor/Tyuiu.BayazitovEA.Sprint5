using Tyuiu.BayazitovEA.Sprint5.Task6.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        string x = $@"C:\\DataSprint5\InPutDataFileTask5V30.txt";

        Class1 ds = new Class1();
        double res = ds.LoadFromDataFile(x);

        Console.WriteLine(res);

        Console.ReadKey();
    }
}