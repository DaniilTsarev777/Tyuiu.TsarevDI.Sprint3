using Tyuiu.TsarevDI.Sprint3.Task2.V9.Lib;
namespace Tyuiu.TsarevDI.Sprint3.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue, stopValue, value;
            startValue = 1;
            stopValue = 10;
            value = 5;
            Assert.AreEqual(0.042, ds.GetSumSeries(value, startValue, stopValue));



        }
    }
}