using Tyuiu.TsarevDI.Sprint3.Task6.V20.Lib;
namespace Tyuiu.TsarevDI.Sprint3.Task6.V20.Test
{
    [TestClass]
    public class DataServicetest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue, stopValue;
            startValue = 20;
            stopValue = 32;
            Assert.AreEqual(41, ds.GetSumTheDivisors(startValue, stopValue));
        }
    }
}