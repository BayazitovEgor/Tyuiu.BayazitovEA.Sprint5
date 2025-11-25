using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task4.V11.Lib
{
    public class Class1 : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            double x = 0;
            string data = File.ReadAllText(path);
            x = double.Parse(data, CultureInfo.InvariantCulture);
            double rusult=Math.Sin(x)+(Math.Pow(x,2)/2);
            rusult=Math.Round(rusult,3);
            return rusult;
        }
    }
}
