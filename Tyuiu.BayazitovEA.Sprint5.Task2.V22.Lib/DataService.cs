using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task2.V22.Lib
{
    public class DataService : ISprint5Task2V22
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            // Обрабатываем массив
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Заменяем положительные на 1, отрицательные на 0
                    if (matrix[i, j] > 0)
                    {
                        result.Append("1");
                    }
                    else if (matrix[i, j] < 0)
                    {
                        result.Append("0");
                    }
                    else
                    {
                        result.Append("0"); // нули остаются нулями
                    }

                    if (j < cols - 1)
                    {
                        result.Append("; ");
                    }
                }
                if (i < rows - 1)
                {
                    result.AppendLine();
                }
            }

            // Сохраняем в файл
            string tempPath = Path.GetTempPath();
            string outputFile = Path.Combine(tempPath, "OutPutFileTask2.csv");
            File.WriteAllText(outputFile, result.ToString());

            // Возвращаем результат
            return result.ToString();
        }
    }
    }
