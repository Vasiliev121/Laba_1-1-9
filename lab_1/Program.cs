using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //№1
            /*Console.WriteLine("Заполните дробное число");
            double x;
            x = double.Parse(Console.ReadLine());
            x = x * 10;
            int d = ((int)x % 10);
            Console.WriteLine("Первай цифра из дробной части положительного вещественного числа х - " + d);*/

            //№2
            /*Console.WriteLine("Введите количество секунд");
            int s;
            s = int.Parse(Console.ReadLine());
            int h = s / 3600;
            int m = (s - h * 3600) / 60;
            Console.WriteLine("Прошло: " + h + " час(ов) " + m + " минут");*/

            //№3
            /*Console.WriteLine("Введите часы минут и секунды");
            int sec, min, hour;
            hour = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());
            sec = int.Parse(Console.ReadLine());
            if (hour > 12 | min > 60 | sec > 60)
            {
                Console.WriteLine("Вы вышли за лимит допустимых значений");
            }
            else
            {
                double degrees, z;
                z = hour + min / 60 + sec / 3600;
                degrees = z / 12 * 360;
                Console.WriteLine("Угол=" + degrees, " градусов");
            }*/

            //№4
            /*Console.WriteLine("Введите два числа");
            int a;
            a = int.Parse(Console.ReadLine());
            int b;
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Первое число - " + a + ", второе число - " + b);*/

            //№5
            /*Console.WriteLine("Введите значение двух катетов");
            int k1, k2;
            double hypotenuse, perimeter, square;
            k1 = int.Parse(Console.ReadLine());
            k2 = int.Parse(Console.ReadLine());
            hypotenuse = Math.Sqrt(k1 ^ 2 + k2 ^ 2);
            perimeter = k1 + k2 + hypotenuse;
            square = (k1 + k2) / 2;
            Console.WriteLine("Периметр - " + perimeter + ", площадь - " + square);*/

            //№6
            /*Console.WriteLine("Введите четырёхзначное число: ");
            int c;
            c = int.Parse(Console.ReadLine());
            int prod = (c / 1000)*((c / 100) % 10) *((c / 10) % 10) *(c % 10);
            Console.WriteLine(prod);*/

            //№7
            /*Console.WriteLine("Введите трёхзначное число: ");
            int n = int.Parse(Console.ReadLine());
            int r = n % 10;
            while ((n /= 10) > 0)
            {
                r = r * 10 + n % 10;
            }
            Console.WriteLine(r);*/

            //№8
            /*Console.WriteLine("Введите значение x для уравнения:  ");
            int x, answer;
            x = int.Parse(Console.ReadLine());
            answer = (((3 * x - 5) * x + 2) * x - 1) * x + 7;
            Console.WriteLine(answer);*/

            //№9
            /* double a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3, x, y, z;
             Console.WriteLine("Заполните переменные:");
             Console.WriteLine("a1 = ");
             a1 = double.Parse(Console.ReadLine());

             Console.WriteLine("a2 = ");
             a2 = double.Parse(Console.ReadLine());

             Console.WriteLine("a3 = ");
             a3 = double.Parse(Console.ReadLine());

             Console.WriteLine("b1 = ");
             b1 = double.Parse(Console.ReadLine());

             Console.WriteLine("b2 = ");
             b2 = double.Parse(Console.ReadLine());

             Console.WriteLine("b3 = ");
             b3 = double.Parse(Console.ReadLine());

             Console.WriteLine("c1 = ");
             c1 = double.Parse(Console.ReadLine());

             Console.WriteLine("c2 = ");
             c2 = double.Parse(Console.ReadLine());

             Console.WriteLine("c3 = ");
             c3 = double.Parse(Console.ReadLine());

             Console.WriteLine("d1 = ");
             d1 = double.Parse(Console.ReadLine());

             Console.WriteLine("d2 = ");
             d2 = double.Parse(Console.ReadLine());

             Console.WriteLine("d3 = ");
             d3 = double.Parse(Console.ReadLine());

             double delta = a1 * b2 * c3 + b1 * c2 * a3 + c1 * a2 * b3 - c1 * b2 * a3 - b1 * a2 * c3 - a1 * c2 * b3;
             double delta1 = d1 * b2 * c3 + b1 * c2 * d3 + c1 * d2 * b3 - c1 * b2 * d3 - b1 * d2 * c3 - d1 * c2 * b3;
             double delta2 = a1 * d2 * c3 + d1 * c2 * a3 + c1 * a2 * d3 - c1 * d2 * a3 - d1 * a2 * c3 - a1 * c2 * d3;
             double delta3 = a1 * b2 * d3 + b1 * d2 * a3 + d1 * a2 * b3 - d1 * b2 * a3 - b1 * a2 * d3 - a1 * d2 * b3;

             if (delta != 0)
             {
                 x = delta1 / delta;
                 y = delta2 / delta;
                 z = delta3 / delta;
                 Console.WriteLine("x = {0}; y = {1}; z = {2}", x, y, z);
             }
             else Console.WriteLine("Ошибка. Определитель не должен быть равен нулю.");*/

        }

    }
    
}
