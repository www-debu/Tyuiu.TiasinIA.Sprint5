using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TiasinIA.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                List<double> positiveNumbers = new List<double>();

                string line;
                double res = 1;

                while ((line = reader.ReadLine()) != null)
                {

                    var values = line.Split(new[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);


                    foreach (var value in values)
                    {
                        if (double.TryParse(value, out double number) && number > 0)
                        {
                            positiveNumbers.Add(number);
                            
                        }
                        break;
                    }
          
                    for (int i = 1; i <= positiveNumbers.Count; i++)
                    {
                        res *= i;
                       
                    }
                }
                return Math.Round(res, 3);
            }
        }
    }
}
