using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsarevDI.Sprint3.Task4.V1.Lib
{
    public class DataService : ISprint3Task4V1
    {
        public double Calculate(int startValue, int stopValue)
        {
            double y;
            y = 0;
            for (startValue = -5; startValue <= stopValue; startValue++)
                if (startValue == 0)
                    break;
                else
                    y += Math.Sin(startValue) / startValue;



            return Math.Round(y, 3);
        }
    }
}
