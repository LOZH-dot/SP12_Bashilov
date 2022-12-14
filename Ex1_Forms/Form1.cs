using System;
using System.Windows.Forms;

namespace Ex1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            int a, b, c, s;

            try
            {
                a = int.Parse(ATextBox.Text);
                b = int.Parse(BTextBox.Text);
                c = int.Parse(CTextBox.Text);
                s = int.Parse(STextBox.Text);

                if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Стороны треугольника не могут быть меньше или равны нулю!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорректные данные в поля сторон треугольника или скаляра!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = string.Empty;

            Triangle triangle = new Triangle(a, b, c);

            result += ($"Первая сторона треугольника: {triangle[0]}\n");
            result += ($"Вторая сторона треугольника: {triangle[1]}\n");
            result += ($"Третья сторона треугольника: {triangle[2]}\n");

            result += ($"\nСтороны увеличены на единицу!\n");
            triangle++;
            result += ($"Первая сторона треугольника: {triangle[0]}\n");
            result += ($"Вторая сторона треугольника: {triangle[1]}\n");
            result += ($"Третья сторона треугольника: {triangle[2]}\n");

            result += ($"\nСтороны уменьшены на единицу!\n");
            triangle--;
            result += ($"Первая сторона треугольника: {triangle[0]}\n");
            result += ($"Вторая сторона треугольника: {triangle[1]}\n");
            result += ($"Третья сторона треугольника: {triangle[2]}\n");

            if (triangle) result += ("\nТреугольник существует!\n");
            else result += ("\nТреугольник не существует!\n");

            triangle *= s;
            result += ($"\nСтороны умножены на скаляр {s}!\n");
            result += ($"Первая сторона треугольника: {triangle[0]}\n");
            result += ($"Вторая сторона треугольника: {triangle[1]}\n");
            result += ($"Третья сторона треугольника: {triangle[2]}\n");

            string StringToTriangle = $"{a} {b} {c}";
            triangle = StringToTriangle;
            result += ("\nСтрока преобразована в класс треугольника!\n");
            result += ($"Первая сторона треугольника: {triangle[0]}\n");
            result += ($"Вторая сторона треугольника: {triangle[1]}\n");
            result += ($"Третья сторона треугольника: {triangle[2]}\n");

            string TriangleToString = (string)triangle;
            result += ("\nКласс преобразован в строку!\n");
            result += ($"Первая сторона треугольника: {triangle[0]}\n");
            result += ($"Вторая сторона треугольника: {triangle[1]}\n");
            result += ($"Третья сторона треугольника: {triangle[2]}\n");

            MessageBox.Show(result, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
