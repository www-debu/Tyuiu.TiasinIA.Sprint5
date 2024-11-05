using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TiasinIA.Sprint5.Task7.V2.Lib
{
    public class DataService : ISprint5Task7V2
    {
        public string LoadDataAndSave(string path)
        {
            string path2 = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V2.txt" });

            FileInfo f = new FileInfo(path2);
            if (f.Exists)
            {
                File.Delete(path2);
            }

            string result = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (c >= '1' && c <= '9')
                        {
                            
                            result += (char)(c - ('1' - '#'));
                        }
                        else if (c == '0') 
                        {
                            result += '#';
                        }

                        else
                        {
                            
                            result += c;
                        }
                    }
                }
            }
            return result;
        }
    }
}
