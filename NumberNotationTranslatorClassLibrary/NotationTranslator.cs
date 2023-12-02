using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberNotationTranslatorClassLibrary
{
	public class NotationTranslator
	{
		const string DIGITS = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		public static int DigigToInt(char digit) => DIGITS.IndexOf(digit);
		public static string IntToDigit(int digit) 
		{
			string notation = DIGITS;
			return digit > DIGITS.Length ? "-1" : Convert.ToString(notation[digit]);
		}
		public static string[] ForPart(string num) => num.Split(',');        
		public string ConvertPTo10int(string str, int p)
		{
			if(p == 10) return str;
			int strX10 = DigigToInt(str[0]);
			for (int i = 1; i < str.Length; i++)
			{
				strX10 *= p; strX10 += DigigToInt(str[i]);
			}
			return Convert.ToString(strX10);
		}
		public string ConvertPTo10Fract(string str, int p)
		{
			if (p == 10) return str;
			string sub = "0" + str;
			char[] reverse = sub.ToCharArray().Reverse().ToArray();
			double strX10 = DigigToInt(reverse[0]);
			for (int i = 1; i < reverse.Length; i++)
			{
				strX10 /= p; strX10 += DigigToInt(reverse[i]);
			}
			var tmp = Convert.ToString(strX10);
			return tmp.Substring(2, tmp.Length - 2);
		}
		private string ConvertTentoQInt(string intPart, int q)
		{
			if(q==10) return intPart;
			string xQ = ""; int xInt = int.Parse(intPart);
			while (xInt >= q)
			{
				xQ = Convert.ToString(DIGITS[xInt % q]) + xQ;
				xInt /= q;
			}
			return Convert.ToString(DIGITS[xInt % q] + xQ);
		}
		public string ConvertTentoQFract(string x, int q, int decPlaces)
		{
			if (q == 10)
				if (decPlaces < x.Length) return "0," + x.Substring(0, decPlaces);
				else return "0," + x;
			int counter = 0; double xQ = double.Parse("0," + x); string answer = "0,";
			while(true)
			{
				xQ *= q;
				string tmp = Convert.ToString(xQ);
				answer += IntToDigit(int.Parse(ForPart(tmp)[0]));
				if (xQ >= 1)
				{
					x=Convert.ToString(xQ);
					try
					{
						xQ = double.Parse("0," + ForPart(x)[1]);
					}
					catch (Exception)
					{
						break;
					}
				}
				counter++;
				if (counter >= decPlaces) break;
			}
			return answer;
		}
		public string TranslatingPtoQ(string str, int P, int Q, int DecPlaces)
		{
			if (IsNegative(str)) _ = str.Remove(0, 1);
			string[] SeparatedNumber = SepNumber(str);
			if (DecPlaces == 0) DecPlaces = SeparatedNumber[1].Length;
			SeparatedNumber[0] = TranslateIntPartFromPtoQ(SeparatedNumber[0], P, Q);
			SeparatedNumber[1] = TranslateFractPartFromPtoQ(SeparatedNumber[0], P, Q, DecPlaces);
			if (SeparatedNumber[1] != "0") return IsNegative(str) ? ($"-{SeparatedNumber[0]}{SeparatedNumber[1].Remove(0, 1)}") : ($"{SeparatedNumber[0]}{SeparatedNumber[1].Remove(0, 1)}");
			else return IsNegative(str) ? $"-{SeparatedNumber[0]}" : $"{SeparatedNumber[0]}";
		}
		private string TranslateFractPartFromPtoQ(string v, int p, int q, int decPlaces)
		{
			throw new NotImplementedException();
		}
		private string TranslateIntPartFromPtoQ(string intPart, int p, int q)
		{
			intPart = ConvertPTo10int(intPart, p);
			intPart = ConvertTentoQInt(intPart, q);
			return intPart;
		}
		private string[] SepNumber(string str)
		{
			throw new NotImplementedException();
		}
		public bool IsNegative(string str) => str[0] == '-';
	}
}
