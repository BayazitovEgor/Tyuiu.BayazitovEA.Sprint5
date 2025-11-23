using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string path = "OutputFileTask0.txt"; // Просто имя файла

            double z = x / (Math.Sqrt(Math.Pow(x, 2) + x));
            z = Math.Round(z, 3);

            File.WriteAllText(path, z.ToString());
            return Path.GetFullPath(path);
        }
    }
}
