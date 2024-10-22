using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsarevDI.Sprint3.Task5.V18.Lib
{
    public class DataService : ISprint3Task5V18
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double y;
            y = 0;
            for (int i = startValue1; i <= stopValue1; startValue1++)
                for (int k = startValue2; k <= stopValue2; startValue2++)
                    y += Math.Cos(x) + ((k * k) / 2);
            return Math.Round(y, 3);

            
        }
    }
}
