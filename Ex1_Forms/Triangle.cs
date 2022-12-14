using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_Forms
{
    class Triangle
    {
        private int a;
        private int b;
        private int c;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public int C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public string Exists
        {
            get
            {
                return (a < b + c && b < a + c && c < a + b) ? "Да" : "Нет";
            }
        }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Triangle()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 2) throw new IndexOutOfRangeException("Индекс находится за пределами индексатора!");

                if (index == 0) return a;
                else if (index == 1) return b;
                else return c;
            }
        }

        public static Triangle operator ++(Triangle a)
        {
            a.A++;
            a.B++;
            a.C++;

            return a;   
        }

        public static Triangle operator --(Triangle a)
        {
            a.A--;
            a.B--;
            a.C--;

            return a;
        }

        public static bool operator true(Triangle a)
        {
            if (a.A < a.B + a.C && a.B < a.A + a.C && a.C < a.A + a.B) return true;
            else return false;
        }

        public static bool operator false(Triangle a)
        {
            if (a.A < a.B + a.C && a.B < a.A + a.C && a.C < a.A + a.B) return true;
            else return false;
        }

        public static Triangle operator *(Triangle a, int num)
        {
            a.A *= num;
            a.B *= num;
            a.C *= num;

            return a;
        }

        public static implicit operator Triangle(string x)
        {
            Triangle triangle = new Triangle();

            string[] sides = x.Split(' ');
            if (sides.Length != 3) throw new Exception("Должно быть 3 стороны!");

            try
            {
                triangle.A = int.Parse(sides[0]);
                triangle.B = int.Parse(sides[1]);
                triangle.C = int.Parse(sides[2]);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return triangle;
        }

        public static explicit operator string(Triangle a)
        {
            return $"Стороны треугольника: {a.A}, {a.B}, {a.C}\nПериметер: {a.GetPerimeter()}, Площадь: {a.GetSquare()}\nСуществует: {a.Exists}";
        }

        public void ShowSides()
        {
            Console.WriteLine($"Длина стороны A: {a}");
            Console.WriteLine($"Длина стороны B: {b}");
            Console.WriteLine($"Длина стороны C: {c}");
        }

        public double GetPerimeter()
            => a + b + c;

        public double GetSquare()
        {
            double p = GetPerimeter() / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
