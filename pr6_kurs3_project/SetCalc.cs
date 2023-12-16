using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_kurs3_project
{
	internal class SetCalc

	{
		public static int _a { get; set; }
		public static int _b { get; set; }
		public static int _c { get; set; }
		public static void SetParams(int init_a, int init_b, int init_c)
		{
			_a = init_a;
			_b = init_b;
			_c = init_c;
		}
		public static void SetParams(int value)
		{
			_a += value;
			_b += value;
			_c += value;

		}
		public static void SetIncrem()
		{
			_a++;
			_b++;
			_c++;
		}
		public static int TriadSumPlusValue(int sum)
		{
			sum = _a + _a + _c;
			return sum;
		}
		public static int TriadSumPlusValue(int sum, int value, int newsum)
		{
			newsum = sum + value;
			return newsum;
		}
	}
}
