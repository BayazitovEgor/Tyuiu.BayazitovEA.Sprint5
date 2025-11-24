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

            // Создаем бинарные данные
            byte[] binaryData;
            using (MemoryStream stream = new MemoryStream())
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                writer.Write(result);
                binaryData = stream.ToArray();
            }

            // Сохраняем в файл
            string tempPath = Path.GetTempPath();
            string outputFile = Path.Combine(tempPath, "OutPutFileTask3.bin");
            File.WriteAllBytes(outputFile, binaryData);

            // Возвращаем base64 строку
            string base64String = Convert.ToBase64String(binaryData);
            return base64String;
        }
    }
}
