using Tyuiu.TsarevDI.Sprint3.Task4.V1.Lib;
namespace Tyuiu.TsarevDI.Sprint3.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #3                                                             *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах              *");
            Console.WriteLine("* Задание #4                                                            *");
            Console.WriteLine("* Варинат #1                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            int startValue, stopValue;
            startValue = -5;
            stopValue = 5;
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.Calculate(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
