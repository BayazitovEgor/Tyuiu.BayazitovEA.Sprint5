using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string tempDir = Path.GetTempPath();
            string path = Path.Combine(tempDir, "OutputFileTask0.txt");

            double z = x / (Math.Sqrt(Math.Pow(x, 2) + x));
            z = Math.Round(z, 3);

            File.WriteAllText(path, z.ToString());
            return path;
        }
    }
}
