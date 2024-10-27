using Tyuiu.TsarevDI.Sprint3.Task7.V4.Lib;
namespace Tyuiu.TsarevDI.Sprint3.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue, stopValue;
            startValue = -5;
            stopValue = 5;
            
            double[] m = new double[11];
            m[0] = -2.15;
            m[1] = -2.57;
            m[2] = -3;
            m[3] = -3.83;
            m[4] = -11.7;
            m[5] = 3;
            m[6] = 2.19;
            m[7] = 3.31;
            m[8] = 2.97;
            m[9] = 1.18;
            m[10] = 0.03;
            double[] res;
            res = new double[11];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(m, res);
        }
    }
}