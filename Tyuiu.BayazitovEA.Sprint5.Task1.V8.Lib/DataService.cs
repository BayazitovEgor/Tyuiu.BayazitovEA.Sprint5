using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            try
            {
                string tempPath = Path.GetTempPath();
                string outputFile = Path.Combine(tempPath, "OutPutFileTask1.txt");

                File.WriteAllText(outputFile, string.Empty);

                for (int x = startValue; x <= stopValue; x++)
                {
                    double result = CalculateFunction(x);
                    File.AppendAllText(outputFile, $"{result}\n");
                }

                return $"Данные успешно сохранены в файл: {outputFile}";
            }
            catch (Exception ex)
            {
                return $"Ошибка при сохранении в файл: {ex.Message}";
            }
        }

        private double CalculateFunction(double x)
        {
            try
            {
                // F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)
                double denominator = 2 * x - 2;


                if (Math.Abs(denominator) < double.Epsilon)
                {
                    return 0;
                }

                double numerator = 2 + Math.Cos(x);
                double fraction = numerator / denominator;
                double result = 4 - 2 * x + fraction;


                return Math.Round(result, 2);
            }
            catch
            {
                return 0;
            }
        }
    }
}