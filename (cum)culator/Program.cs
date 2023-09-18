using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _cum_culator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("в данном калькуляторе есть выбор нескольких действий: ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. сложить 2 числа");
            Console.WriteLine("2. вычесть первое из второго");
            Console.WriteLine("3. перемножить два числа");
            Console.WriteLine("4. разделить первое на второе");
            Console.WriteLine("5. возвести в степень N первое число");
            Console.WriteLine("6. найти квадратный корень из числа");
            Console.WriteLine("7. найти 1 процент от числа");
            Console.WriteLine("8. найти факториал из числa");
            Console.WriteLine("9. выйти из программы");
            while (true)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("какое действие хотите совершить?");
                string act = Console.ReadLine();
                int action = Convert.ToInt32(act);
                int result = 0;
                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine("будьте добры, введите первое число");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("теперь второе число");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            result = slojenie(input1, input2);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("будьте добры, введите первое число");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("теперь второе число");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            result = vichitanie(input1, input2);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("будьте добры, введите первое число");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("теперь второе число");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            result = umnogenie(input1, input2);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("будьте добры, введите первое число");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("теперь второе число");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            result = delenie(input1, input2);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("будьте добры, введите число");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("в какую степень хотите возвести число?");
                            int input2 = Convert.ToInt32(Console.ReadLine());
                            result = stepen(input1, input2);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("будьте добры, введите число");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            result = kvadratnykoren(input1);
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("будьте добры, введите число");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            result = odinprozent(input1);
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("будьте добры, введите число");
                            int input1 = Convert.ToInt32(Console.ReadLine());
                            result = factorial(input1);
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("пака-пака");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        Console.WriteLine("вы чево, так делать нельзя");
                        break;

                }
                Console.WriteLine("Ответ: {0}", result);
                Console.ReadKey();
            }

        }
        //плюська(1)
        public static int slojenie(int input1, int input2)
        {
            int result = input1 + input2;
            return result;
        }
        //минуська(2)
        public static int vichitanie(int input1, int input2)
        {
            int result = input1 - input2;
            return result;
        }
        //умноженька(3)
        public static int umnogenie(int input1, int input2)
        {
            int result = input1 * input2;
            return result;
        }
        //деленька(4)
        public static int delenie(int input1, int input2)
        {
            if (input2 == 0)
            {
                Console.WriteLine("вы чево, на ноль нельзя делить");
            }
            else
            { }
            int result = input1 / input2;
            return result;
        }
        //возведенька в степень первого числа(5)
        public static int stepen(int input1, int input2)
        {
            int result = 1;
            while (input2 != 0)
            {
                result *= input1;
                --input2;
            }
            return result;
        }
        //квадратный коренька из числа(6)
        public static int kvadratnykoren(int input1)
        {
            double result = Math.Sqrt(input1);
            return (int)result;
        }
        //адин процентик от числа(7)
        public static int odinprozent(int input1)
        {
            double result = input1 / 100;
            return (int)result;
        }
        //факториалик из числа(8)
        public static int factorial(int input1)
        {
            int num = input1;
            int result = 1;

            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
