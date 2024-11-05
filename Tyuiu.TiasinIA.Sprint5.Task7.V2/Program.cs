using System.IO;
using Tyuiu.TiasinIA.Sprint5.Task7.V2.Lib;
namespace Tyuiu.TiasinIA.Sprint5.Task7.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Тясин И. А. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Тясин Илья Александрович | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V12.txt                     *");
            Console.WriteLine("* в котором есть набор символьных данных.Заменить все цифры               *");
            Console.WriteLine("* на символ \"#\". Полученный результат сохранить в файл                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path;
            Console.WriteLine("Введите путь к файлу:");

            path = Console.ReadLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.LoadDataAndSave(path);

            Console.WriteLine("Результат сохранен = " + res);
            Console.WriteLine("Создан!");
        }
    }
}
