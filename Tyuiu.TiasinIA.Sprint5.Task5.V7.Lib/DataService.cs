using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TiasinIA.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            int res = 1;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int value = Convert.ToInt32(line);
                    if (value > 1)
                    {
                        for (int i = 2; i < value; i++)
                        {
                            if (value % i == 0)
                            {
                                for (int j = 1; j < value; j++)
                                {
                                    res = res * i;
                                }

                            }
                        }
                    }
                    else
                    {
                        res = res;
                    }

                }
            }
            return res;
        }
    }
}
