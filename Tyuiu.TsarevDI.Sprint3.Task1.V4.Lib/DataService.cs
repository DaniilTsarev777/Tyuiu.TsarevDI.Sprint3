using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsarevDI.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double s = 0;

            while (startValue <= stopValue)
            {
                s += + 1 / Math.Pow(startValue, 2);
                startValue++;
            }

            return Math.Round(s, 3);
        }
    }
}   
