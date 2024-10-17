using Tyuiu.TsarevDI.Sprint3.Task1.V4.Lib;
namespace Tyuiu.TsarevDI.Sprint3.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService(); 
            int startValue = 1;
            int stopValue = 10;
            Assert.AreEqual(1.55, ds.GetSumSeries(startValue, stopValue));
        }
    }
}