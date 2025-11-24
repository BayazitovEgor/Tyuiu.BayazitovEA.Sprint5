using Tyuiu.BayazitovEA.Sprint5.Task3.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int x = 5;

        DataService ds = new DataService();
        string res = ds.SaveToFileTextData(x);

        Console.WriteLine(res);

        Console.ReadKey();
    }
}