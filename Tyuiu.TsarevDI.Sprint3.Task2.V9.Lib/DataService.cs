using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsarevDI.Sprint3.Task2.V9.Lib
{
    public class DataService : ISprint3Task2V9
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            int n = 5;
            double s = 0;
            do
            {
                s += Math.Pow(1 / Math.Pow(n, startValue), 2);
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(s, 3);
        }
    }
}
