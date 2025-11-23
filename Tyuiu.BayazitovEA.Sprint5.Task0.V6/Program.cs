using Tyuiu.BayazitovEA.Sprint5.Task0.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int x = 3;
        DataService ds = new DataService();

        string res =  ds.SaveToFileTextData(x);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}