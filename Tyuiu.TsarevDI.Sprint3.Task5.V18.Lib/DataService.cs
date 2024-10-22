using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsarevDI.Sprint3.Task5.V18.Lib
{
    public class DataService : ISprint3Task5V18
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double y;
            y = 0;
            for (startValue1 = 1; startValue1 <= stopValue1; startValue1++)
                for (startValue2 = 1; startValue2 <= stopValue2; startValue2++)
                    y += (Math.Cos(x) + (Math.Pow(startValue2, 2) / 2));
            return Math.Round(y, 3);

            
        }
    }
}
