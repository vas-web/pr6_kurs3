using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr6_kurs3_project
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void Button_Click_2(object sender, RoutedEventArgs e)
		{
			SetCalc.SetParams(1);
			tb_a2.Text = Convert.ToString(SetCalc._a);
			tb_b2.Text = Convert.ToString(SetCalc._b);
			tb_c2.Text = Convert.ToString(SetCalc._c);
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			SetCalc.SetParams(10);
			tb_a2.Text = Convert.ToString(SetCalc._a);
			tb_b2.Text = Convert.ToString(SetCalc._b);
			tb_c2.Text = Convert.ToString(SetCalc._c);
		}
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			int a = Convert.ToInt32(tb_a.Text);
			int b = Convert.ToInt32(tb_b.Text);
			int c = Convert.ToInt32(tb_c.Text);
			SetCalc.SetParams(a, b, c);
		}

		private void Button_Click_3(object sender, RoutedEventArgs e)
		{
			SetCalc.SetIncrem();
			tb_incr.Text = Convert.ToString(SetCalc._a + " ; " + SetCalc._b + " ; " + SetCalc._c);
		}

		private void Button_Click_4(object sender, RoutedEventArgs e)
		{
			int summa = SetCalc.TriadSumPlusValue(0);
			int valuehz = Convert.ToInt32(tb_sum.Text);
			int sumplus = SetCalc.TriadSumPlusValue(summa, valuehz, 0);
			tb_sumplus.Text = Convert.ToString(summa + " ; " + sumplus);

		}
	}
}
