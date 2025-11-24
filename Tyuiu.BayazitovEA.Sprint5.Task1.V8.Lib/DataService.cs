using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            StringBuilder results = new StringBuilder();

            for (int x = startValue; x <= stopValue; x++)
            {
                double result = CalculateFunction(x);
                string formattedResult = FormatResult(result);
                results.AppendLine(formattedResult);
            }

            // Сохраняем в файл
            string tempPath = Path.GetTempPath();
            string outputFile = Path.Combine(tempPath, "OutPutFileTask1.txt");
            File.WriteAllText(outputFile, results.ToString());

            // Возвращаем сами данные
            return results.ToString().Trim();
        }

        private double CalculateFunction(double x)
        {
            try
            {
                // F(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)
                double denominator = 2 * x - 2;

                // Проверка деления на ноль (при x = 1)
                if (Math.Abs(denominator) < double.Epsilon)
                {
                    return 0;
                }

                double numerator = 2 + Math.Cos(x);
                double fraction = numerator / denominator;
                double result = 4 - 2 * x + fraction;

                // Проверка на бесконечность и NaN
                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    return 0;
                }

                return Math.Round(result, 2);
            }
            catch
            {
                return 0;
            }
        }

        private string FormatResult(double result)
        {
            // Округляем до 2 знаков
            result = Math.Round(result, 2);

            // Если число целое, убираем дробную часть
            if (result == (int)result)
            {
                return ((int)result).ToString();
            }

            // Иначе форматируем с 2 знаками и заменяем точку на запятую
            return result.ToString("0.00").Replace(".", ",");
        }
    }
    }
}