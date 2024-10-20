using Tyuiu.TsarevDI.Sprint3.Task2.V9.Lib;
namespace Tyuiu.TsarevDI.Sprint3.Task2.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #3                                                             *");
            Console.WriteLine("* Тема: Оператор цикла do-while                                         *");
            Console.WriteLine("* Задание #2                                                            *");
            Console.WriteLine("* Варинат #11                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");
            int value, startValue, stopValue;
            startValue = 1;
            value = 5;
            stopValue = 10;


            Console.WriteLine("value = 5");
            Console.WriteLine("startValue = 1");
            Console.WriteLine("stopValue = 10");



            
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
