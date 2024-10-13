using Tyuiu.TiasinIA.Sprint5.Task0.V1.Lib;

namespace Tyuiu.TiasinIA.Sprint5.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            var res = ds.SaveToFileTextData(0);
            Assert.AreEqual(path, res);
        }
    }
}