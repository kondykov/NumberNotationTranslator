using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberNotationTranslatorClassLibrary
{
    /// <summary>
    /// Класс для перевода целых чисел из одной системы счисления в другую
    /// </summary>
    public class NotationTranslator
    {
        /// <summary>
        /// Алфавит систем счисления
        /// </summary>
        const string notations = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Исходная система счисления
        /// </summary>
        private int _notationFrom;
        /// <summary>
        /// Система счисления результата
        /// </summary>
        private int _notationTo;
        /// <summary>
        /// переводимое число
        /// </summary>
        private int number;

        public int NotationFrom { 
            get 
            { 
                return _notationFrom; 
            }
            set 
            {
                _notationFrom = value;
            } 
        }
        public int NotationTo {
            get
            {
                return _notationTo;
            }
            set
            {
                _notationTo = value;
            }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public NotationTranslator() { }
        public NotationTranslator(int number, int notationFrom, int notationTo)
        {
            Number = number;
            NotationFrom = notationFrom;
            NotationTo = notationTo;
        }

        public int FromNotationFromToDecimal() 
        {
            // каждую цифру умножить на основание системы счисления в степени порядка и сложить
            // 123 в пятиричной с.с. = 1*5^2 + 2*5^1 + 3*5^0 в десятичной с.с.
            // Number, NumberFrom
            return 0; 
        }
        public int FromDecimalToNotationTo() 
        { 
            //Делим на основание системы счисления пока делится и
            //записываем остатки от деления в обратном порядке
            return 0; 
        }


    }
}
