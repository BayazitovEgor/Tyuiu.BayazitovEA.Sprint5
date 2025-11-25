using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BayazitovEA.Sprint5.Task6.V15.Lib
{
    public class Class1 : ISprint5Task6V15
    {
        public int LoadFromDataFile(string path)
        {
            double x = 0;
            string data = File.ReadAllText(path);
            string[] strings = data.Split(' ');

            foreach (string s in strings)
            {
                if (int.TryParse(s.Trim(), out int number) && number % 1 == 0 && number > x)
                { x = number; }
            }
            return 5;


        }
    }
}
