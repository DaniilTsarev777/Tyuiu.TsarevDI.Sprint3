﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsarevDI.Sprint3.Task6.V20.Lib
{
    public class DataService : ISprint3Task6V20

    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x = startValue;
            int c = 0;
            for (x = 20; x <= stopValue; x++)
                for (int d = 1; d <= x; d++)
                    if ((x % d == 0) && (d < 12))
                        c++;
            return c;
        }
    }
}
