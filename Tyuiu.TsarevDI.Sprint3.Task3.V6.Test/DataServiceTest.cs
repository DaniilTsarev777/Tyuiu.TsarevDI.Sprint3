using Tyuiu.TsarevDI.Sprint3.Task3.V6.Lib;
namespace Tyuiu.TsarevDI.Sprint3.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string value = "12able 1o s4gh";
            char item = 't';
            Assert.AreEqual("ttable to stgh", ds.ReplaceNumOnChar(value, item));
        }
    }
}