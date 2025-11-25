using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            double x = 0;
            string data = File.ReadAllText(path);
            data = data.ToUpper();

            string tempPath = Path.GetTempPath();
            string outputFile = Path.Combine(tempPath, "OutPutDataFileTask7V14.txt");
            File.WriteAllText(outputFile, data);

            return outputFile;
        }
    }
}
