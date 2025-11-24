using Tyuiu.BayazitovEA.Sprint5.Task1.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int start = -5;
        int end = 5;
        DataService ds = new DataService();

        string res = ds.SaveToFileTextData(start, end);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}