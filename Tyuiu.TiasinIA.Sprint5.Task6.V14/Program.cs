using System.IO;
using Tyuiu.TiasinIA.Sprint5.Task6.V14.Lib;
namespace Tyuiu.TiasinIA.Sprint5.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Тясин И.А. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #5                                                               #");
            Console.WriteLine("# Тема: Обработка текстовых файлов                                        #");
            Console.WriteLine("# Задание #6                                                              #");
            Console.WriteLine("# Вариант #14                                                             #");
            Console.WriteLine("# Выполнил Тясин Илья Александрович | АСОиУб-24-1                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Дан файл С:\DataSprint5\InPutDataFileTask6V14.txt (файл взять из        #");
            Console.WriteLine("# архива согласно вашему варианту. Создать папку в ручную                 #");
            Console.WriteLine("# С:\DataSprint5\ и скопировать в неё файл) в котором есть набор          #");
            Console.WriteLine("# символьных данных. Найти количество знаков препинания в заданной строке.#");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            string path = @"C:\DataSprint5\InPutDataFileTask6V14.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Количество знаков препинания = " + res);
            Console.ReadKey();
        }
    }
}
