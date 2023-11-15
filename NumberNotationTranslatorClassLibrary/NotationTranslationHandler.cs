using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberNotationTranslatorClassLibrary
{
    /// <summary>
    /// Класс для обработки перевода чисел из одной системы счисления в другую.
    /// Класс предназначени для подготовки числа к переводу
    /// </summary>
    public class NotationTranslationHandler
    {
        private NotationTranslator fractTranslator;
        private NotationTranslator integerTranslator;

        public NotationTranslationHandler(){}

        public NotationTranslationHandler(double number, int notationFrom, int notationTo)
        {
            int intPart = (int)Math.Truncate(number);
            //подумать как брать дробную часть.
            //Можно использовать строку. Отбросить "0," и остальное брать как дробную часть
            int fractPart = (int)(number - (int)Math.Truncate(number));

            integerTranslator = new NotationTranslator(intPart, notationFrom, notationTo);
            fractTranslator = new NotationTranslator(fractPart, notationFrom, notationTo);
        }

        public int Translate()
        {
            int intAnswer = integerTranslator.FromNotationFromToDecimal();
            integerTranslator.Number = intAnswer;

            intAnswer = integerTranslator.FromDecimalToNotationTo();
            integerTranslator.Number = intAnswer; 
            
            int fractAnswer = fractTranslator.FromNotationFromToDecimal();
            fractTranslator.Number = fractAnswer;

            fractAnswer = fractTranslator.FromDecimalToNotationTo();
            fractTranslator.Number = fractAnswer;

            return integerTranslator.Number+ fractTranslator.Number;
        }
    }
}
