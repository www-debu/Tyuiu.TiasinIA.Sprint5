using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TiasinIA.Sprint5.Task1.V5.Lib
{
    public class DataService : ISprint5Task1V5
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists) { File.Delete(path); }

            double res;
            string strRes;
            for (int x = startValue; x <= stopValue; x++)
            {
                res = Math.Round(5 - 3 * x + ((1 + Math.Sin(x)) / (2 * x - 0.5)), 2);
                strRes = Convert.ToString(res);

                if (Math.Sin(x) + 1 == 0)
                {
                    File.AppendAllText(path, "0");
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, strRes + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strRes);
                }
            }
            return path;
        }
    }
}
