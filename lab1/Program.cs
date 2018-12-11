using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
  
     class Factorial
    {


        public int Count(int number)
        {

            int result_factorial = 1;
            for (int i = 2; i <= number; i++)
            { result_factorial *= i; }
            return result_factorial;
        }
    }
     class triangle
    {

        public double perimetr(double a, double b, double c)
        {
            double result_perimetr = a + b + c;


            return result_perimetr;
        }

        public double area(double a, double b, double c)
        {
            double result_area, p;
            p = (a + b + c) / 2;
            result_area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return result_area;
        }

    }
     class abitura
    {
        public int summa(int ocenka1, int ocenka2, int ocenka3, int ocenka4)
        {
            int summa = ocenka1 + ocenka2 + ocenka3 + ocenka4;

            return summa;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string choose;
            start:
            Console.WriteLine("выберите что посчитать :\n1 - Выражение 2*5!+3*8!+6!+4!\n2 - треугольник\n3 - абитуриент");
            choose = Console.ReadLine();
            switch (choose)
            {
                case "1": goto factorial;
                case "2": goto triangle;
                case "3": goto abitura;
                default: goto start;
            }

            factorial:
            Factorial factorial = new Factorial();


            Console.WriteLine("2*5!+3*8!+6!+4! = " + (2 * factorial.Count(5) + 3 * factorial.Count(8) + factorial.Count(6) + factorial.Count(4)));
            goto end;


            triangle:
            double a, b, c, A, B, C;
            triangle triangle = new triangle();



            try
            {
                Console.WriteLine("Введите сторону a треугольника 1");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите сторону b треугольника 1");
                b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите сторону c треугольника 1");
                c = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите сторону a треугольника 2");
                A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите сторону b треугольника 2");
                B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите сторону c треугольника 2");
                C = Convert.ToDouble(Console.ReadLine());


            }
            catch (FormatException)
            {
                goto triangle;
            }
            double per1 = triangle.perimetr(a, b, c), per2 = triangle.perimetr(A, B, C), area1 = triangle.area(a, b, c), area2 = triangle.area(A, B, C);
            Console.WriteLine("периметр треугольника 1 = " + triangle.perimetr(a, b, c));
            Console.WriteLine("площадь треугольника 1 = " + triangle.area(a, b, c));
            Console.WriteLine("периметр треугольника 2 = " + triangle.perimetr(A, B, C));
            Console.WriteLine("площадь треугольника 2 = " + triangle.area(A, B, C));
            Console.WriteLine("Сумма периметров = " + (per1 + per2));
            Console.WriteLine("Сумма площадей = " + (area1 + area2));
            goto end;


            abitura:
            abitura abitura = new abitura();
            int ocenka1, ocenka2, ocenka3, ocenka4;
            try
            {
                Console.WriteLine("введите оценку 1:");
                ocenka1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите оценку 2:");
                ocenka2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите оценку 3:");
                ocenka3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите оценку 4:");
                ocenka4 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                goto abitura;
            }
            Console.WriteLine("сумма балов = " + (abitura.summa(ocenka1, ocenka2, ocenka3, ocenka4)));


            end:
            Console.WriteLine("Повторить? y/n");
            string q;
            q = Console.ReadLine();
            if (q == "y" || q == "Y") goto start;
            Console.ReadKey();
        }
    }
}




    

