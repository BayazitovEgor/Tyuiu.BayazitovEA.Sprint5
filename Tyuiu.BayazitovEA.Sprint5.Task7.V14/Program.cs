using Tyuiu.BayazitovEA.Sprint5.Task7.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        string x = $@"C:\\DataSprint5\InPutDataFileTask7V14.txt";

        DataService ds = new DataService();
        string res = ds.LoadDataAndSave(x);

        Console.WriteLine(res);

        Console.ReadKey();
    }
}