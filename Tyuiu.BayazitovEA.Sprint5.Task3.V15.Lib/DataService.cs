using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task3.V15.Lib
{
    public class DataService : ISprint5Task3V15
    {
        public string SaveToFileTextData(int x)
        {
            // F(x) = -1.4x³ + 2.3x² + 0.6x
            double result = -1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x;
            result = Math.Round(result, 3);

            // Сохраняем в бинарный файл
            string tempPath = Path.GetTempPath();
            string outputFile = Path.Combine(tempPath, "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.Create)))
            {
                writer.Write(result);
            }

            // Возвращаем строковое представление для консоли
            return result.ToString();
        }
    }
}
