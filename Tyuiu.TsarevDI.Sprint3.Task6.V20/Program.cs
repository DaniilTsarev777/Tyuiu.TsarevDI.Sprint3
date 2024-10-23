using Tyuiu.TsarevDI.Sprint3.Task6.V20.Lib;
namespace Tyuiu.TsarevDI.Sprint3.Task6.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #3                                                             *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                              *");
            Console.WriteLine("* Задание #6                                                            *");
            Console.WriteLine("* Варинат #20                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            int startValue, stopValue;
            Console.WriteLine("startValue = 20" );
            Console.WriteLine("stopValue = 32" );
            startValue = 20;
            stopValue = 32;
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
