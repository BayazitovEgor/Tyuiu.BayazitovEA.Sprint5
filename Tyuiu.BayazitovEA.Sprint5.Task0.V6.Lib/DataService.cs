using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = ((double)x)/(Math.Sqrt(Math.Pow(x,2)+x));
            z=Math.Round(z,3);
            File.WriteAllText(path,Convert.ToString(z));
            return path;
        }
    }
}
