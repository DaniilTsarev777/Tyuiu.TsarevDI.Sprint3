﻿using System.Xml.Schema;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.TsarevDI.Sprint3.Task7.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] m = new double[11];

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
                if ((Math.Cos(x) + x) != 0)
                {
                    m[count] = Math.Round(((((2 * x) + 6) / (Math.Cos(x) + x)) - 3), 2);
                    count++;
                }
                else
                {
                    m[count] = -3;
                    count++;
                }
            return m;
        }
    }
}
