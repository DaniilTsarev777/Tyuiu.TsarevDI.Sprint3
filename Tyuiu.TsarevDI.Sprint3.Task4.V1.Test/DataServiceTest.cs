using Tyuiu.TsarevDI.Sprint3.Task4.V1.Lib;
namespace Tyuiu.TsarevDI.Sprint3.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue, stopValue;
            startValue = -5;
            stopValue = 5;
            Assert.AreEqual(0.962, ds.Calculate(startValue, stopValue));
        }
    }
}