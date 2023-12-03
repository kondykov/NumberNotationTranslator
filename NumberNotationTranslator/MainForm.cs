using TranslatorClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace NumberNotationTranslator
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string xStr;
            if (textBoxInputNumber.Text != "") xStr = textBoxInputNumber.Text;
            else
            {
                MessageBox.Show("Некорректный ввод.\n" +
                    "Поле \"Введите число\" не может быть пустым.\n" +
                    "Для справки нажмите соответствующую кнопку.", "Ошибка!");
                return;
            }
            bool Negative = false;
            if (xStr[0] == Convert.ToChar("-"))
            {
                Negative = true;
                xStr = xStr.Remove(0, 1);
            }
            for (int i = 0; i < xStr.Length; i++)
            {
                if (xStr[i] != Convert.ToChar(","))
                {
                    if (NotationTranslator.DigigToInt(xStr[i]) == -1)
                    {
                        MessageBox.Show("Некорректный ввод.\n" +
                            "Введено не число в поле \"Введите число\".\n" +
                            "Для справки нажмите соответствующую кнопку.", "Ошибка!");
                        return;
                    }
                }
            }
            if (!int.TryParse(textBoxNotationFrom.Text, out int P) || P >= 37 || P <= 1)
            {
                MessageBox.Show("Некорректный ввод.\n" +
                    "P - целое число от 2 до 36.\n" +
                    "Для справки нажмите соответствующую кнопку.", "Ошибка!");
                return;
            }
            if (!int.TryParse(textBoxNotationTo.Text, out int Q) || Q >= 37 || Q <= 1)
            {
                MessageBox.Show("Некорректный ввод.\n" +
                    "Q - целое число от 2 до 36.\n" +
                    "Для справки нажмите соответствующую кнопку.", "Ошибка!");
                return;
            }
            int counter = 0;
            for (int i = 0; i < xStr.Length; i++)
            {
                if (xStr[i] != Convert.ToChar(","))
                {
                    if (NotationTranslator.DigigToInt(xStr[i]) >= P)
                    {
                        MessageBox.Show("Цифры числа не могут превосходить его систему счисления.\n" +
                        "Для справки нажмите соответствующую кнопку.", "Ошибка!");
                        return;
                    }
                }
                else
                    counter += 1;
                if (counter > 1)
                {
                    MessageBox.Show("Некорректный ввод. В числе не может быть больше одной запятой\n" +
                        "Для справки нажмите соответствующую кнопку.", "Ошибка!");
                    return;
                }
            }

            string intPart = NotationTranslator.ForPart(xStr)[0], fractPart;
            try
            {
                fractPart = NotationTranslator.ForPart(xStr)[1];
            }
            catch (Exception)
            {
                fractPart = "0";
            }
            int decPlaces;
            if (DecPlacesTextBox.Text == "" || DecPlacesTextBox.Text == "0") decPlaces = fractPart.Length;
            else
                try
                {
                    decPlaces = int.Parse(DecPlacesTextBox.Text);
                    if (decPlaces < 0)
                    {
                        MessageBox.Show("Некорректный ввод.\n" +
                            "Точность - целое неотрицательное число.\n" +
                            "Для справки нажмите соответствующую кнопку.", "Ошибка!");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Некорректный ввод.\n" +
                            "Точность - целое неотрицательное число.\n" +
                            "Для справки нажмите соответствующую кнопку.", "Ошибка!");
                    return;
                }
            string intPart10 = NotationTranslator.ConvertPTo10int(intPart, P);
            string intPartQ = NotationTranslator.ConvertTentoQInt(intPart10, Q);
            string fractPart10, fractPartQ, result;

            if (fractPart != "0")
            {
                fractPart10 = NotationTranslator.ConvertPTo10Fract(fractPart, P);
                fractPartQ = NotationTranslator.ConvertTenToQFract(fractPart10, Q, decPlaces);
                result = Negative ? ($"-{intPartQ}" + $"{fractPartQ.Remove(0, 1)}") : ($"{intPartQ}" + $"{fractPartQ.Remove(0, 1)}");
            }
            else result = Negative ? $"-{intPartQ}" : $"{intPartQ}";
            textBoxResult.Text = String.Format("{0}", result);
        }
    }
}
