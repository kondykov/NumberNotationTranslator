using NumberNotationTranslatorClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberNotationTranslator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие нажатия на кнопку
        /// </summary>
        /// <param name="sender">Элемент управления, который вызвал событие</param>
        /// <param name="e">Параметры события</param>
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            //Получаем доступ к элементу управления, который вызвал событие
            //Button button = sender as Button;

            //Получаем информацию из текстбоксов. Введённую пользователем
            NotationTranslationHandler translationHandler =
                new NotationTranslationHandler();

            translationHandler = GetValues(translationHandler);

            if(translationHandler != null)
            {
                int answer = translationHandler.Translate();
                textBoxResult.Text = Convert.ToString(answer);
            }
        }

        private NotationTranslationHandler GetValues(NotationTranslationHandler translationHandler)
        {
            try
            {
                double inputNumber = double.Parse(textBoxInputNumber.Text);
                int notationFrom = int.Parse(textBoxNotationFrom.Text);
                int notationTo = int.Parse(textBoxNotationTo.Text);

                translationHandler =
                        new NotationTranslationHandler(inputNumber,
                        notationFrom, notationTo);
                return translationHandler;
            }
            catch
            {
                MessageBox.Show("Неверно указаны значения!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
