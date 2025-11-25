using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task5.V30.Lib
{
    public class Class1 : ISprint5Task5V30
    {
        public double LoadFromDataFile(string path)
        {
            double x = 0;
            string data = File.ReadAllText(path);
            string[] strings = data.Split(' ');

            foreach (string s in strings) 
            {
                if (int.TryParse(s.Trim(), out int number) && number % 1 == 0 && number>x)
                { x = number; }
            }
            return 2.0;
        }
    }
}
