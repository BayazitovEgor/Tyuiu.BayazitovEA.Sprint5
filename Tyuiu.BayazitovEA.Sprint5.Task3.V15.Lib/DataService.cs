using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task3.V15.Lib
{
    public class DataService : ISprint5Task3V15
    {
        public string SaveToFileTextData(int x)
        {
     
            double result = -1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x;
            result = Math.Round(result, 3);

            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask3.bin");


            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(result));
            }


            return path;
        }
    }
}
