using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TiasinIA.Sprint5.Task6.V14.Lib
{
    public class DataService : ISprint5Task6V14
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.ToUpper();
                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];
                        if ((c >= '.') && (c <= ','))
                            count++;
                    }
                }
            }
            return count;
        }
    }
}
