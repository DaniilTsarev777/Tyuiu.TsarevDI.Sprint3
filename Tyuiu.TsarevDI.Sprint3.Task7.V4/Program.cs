using Tyuiu.TsarevDI.Sprint3.Task7.V4.Lib;
namespace Tyuiu.TsarevDI.Sprint3.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #3                                                             *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту               *");
            Console.WriteLine("* Задание #7                                                            *");
            Console.WriteLine("* Варинат #4                                                            *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("старт шага = " + startValue);
            Console.WriteLine("конец шага = " + stopValue);

            double[] m = new double[11];
            m = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|     X    |    f(x)   |");
            Console.WriteLine("+----------+-----------+");


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, m[i]);
                startValue++;
            }
            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();



        }
    }
}
