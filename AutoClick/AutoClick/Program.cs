using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;

namespace AutoClick
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
