using System;

namespace Ex1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            while (true)
            {
                try
                {
                    Console.Write("Введите сторону треугольника (a): ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Введите сторону треугольника (b): ");
                    b = int.Parse(Console.ReadLine());

                    Console.Write("Введите сторону треугольника (c): ");
                    c = int.Parse(Console.ReadLine());

                    if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Стороны треугольника не могут быть меньше или равны нулю!");
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("ожидается ввод целого числа!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }


            Console.WriteLine("\n");

            Triangle triangle = new Triangle(a, b, c);

            Console.WriteLine($"Первая сторона треугольника: {triangle[0]}");
            Console.WriteLine($"Вторая сторона треугольника: {triangle[1]}");
            Console.WriteLine($"Третья сторона треугольника: {triangle[2]}");

            Console.WriteLine($"\nСтороны увеличены на единицу!\n");
            triangle++;
            Console.WriteLine($"Первая сторона треугольника: {triangle[0]}");
            Console.WriteLine($"Вторая сторона треугольника: {triangle[1]}");
            Console.WriteLine($"Третья сторона треугольника: {triangle[2]}");

            Console.WriteLine($"\nСтороны уменьшены на единицу!\n");
            triangle--;
            Console.WriteLine($"Первая сторона треугольника: {triangle[0]}");
            Console.WriteLine($"Вторая сторона треугольника: {triangle[1]}");
            Console.WriteLine($"Третья сторона треугольника: {triangle[2]}\n");

            if (triangle) Console.WriteLine("Треугольник существует!");
            else Console.WriteLine("Треугольник не существует!");


            int s = 0;
            while (true)
            {
                try
                {
                    Console.Write("Введите скаляр, на который умножится треугольник (целое число): ");
                    s = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка");
                    Console.ResetColor();
                    Console.WriteLine("ожидается ввод целого числа!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            triangle *= s;
            Console.WriteLine($"Стороны умножены на скаляр {s}!");
            Console.WriteLine($"Первая сторона треугольника: {triangle[0]}");
            Console.WriteLine($"Вторая сторона треугольника: {triangle[1]}");
            Console.WriteLine($"Третья сторона треугольника: {triangle[2]}\n");

            while (true)
            {
                try
                {
                    Console.Write("Введите новую сторону треугольника (a): ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Введите новую сторону треугольника (b): ");
                    b = int.Parse(Console.ReadLine());

                    Console.Write("Введите новую сторону треугольника (c): ");
                    c = int.Parse(Console.ReadLine());

                    if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Стороны треугольника не могут быть меньше или равны нулю!");
                    break;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine("ожидается ввод целого числа!");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ошибка: ");
                    Console.ResetColor();
                    Console.WriteLine(ex.Message);
                }
            }

            string StringToTriangle = $"{a} {b} {c}";
            triangle = StringToTriangle;
            Console.WriteLine("Строка преобразована в класс треугольника!");
            Console.WriteLine($"Первая сторона треугольника: {triangle[0]}");
            Console.WriteLine($"Вторая сторона треугольника: {triangle[1]}");
            Console.WriteLine($"Третья сторона треугольника: {triangle[2]}\n");

            Console.WriteLine("Класс преобразован в строку!");
            string TriangleToString = (string)triangle;
            Console.WriteLine($"Первая сторона треугольника: {triangle[0]}");
            Console.WriteLine($"Вторая сторона треугольника: {triangle[1]}");
            Console.WriteLine($"Третья сторона треугольника: {triangle[2]}\n");
        }
    }
}
