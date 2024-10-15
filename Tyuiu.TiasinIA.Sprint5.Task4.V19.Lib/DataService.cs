using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TiasinIA.Sprint5.Task4.V19.Lib
{
    public class DataService : ISprint5Task4V19
    {
        public double LoadFromDataFile(string path)
        {
            

            string strx = File.ReadAllText(path);
            double res = Math.Round( Math.Pow( Convert.ToDouble(strx) / Math.Cos(Convert.ToDouble(strx)) ,2) ,3);
            return res;
        }
    }
}
