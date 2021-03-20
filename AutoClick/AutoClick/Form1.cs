using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text;

namespace AutoClick
{
	public partial class Form1 : Form
	{
		private bool m_isStart = false;
		private int count = 0;
		private int maxCount = 0;
		private int m_Delay = 0;

		private HookKey.LowLevelKeyboardProcDelegate m_callback;
		
		private IntPtr LowLevelKeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
		{
			if (nCode >= 0)
			{
				var khs = (HookKey.KeyboardHookStruct)Marshal.PtrToStructure(lParam,typeof(HookKey.KeyboardHookStruct));
				if (Convert.ToInt32("" + wParam) == 256)
				{
					if (khs.VirtualKeyCode == 115)//F4
					{
						Stop.PerformClick();
						WindowState = FormWindowState.Normal;
					}
					if (khs.VirtualKeyCode == 116)//F5
					{
						Start.PerformClick();
						WindowState = FormWindowState.Normal;
					}
				}
			}
			return HookKey.CallNextHookEx(HookKey.m_hHook, nCode, wParam, lParam);
		 }


		async private void GetMessageText(char[] message)
		{
			for(int i = 0; i < message.Length; i++)
			{
				SendKeys.Send(message[i].ToString());
				await Task.Delay(10);
			}
			SendMessage();
		}

		private void StartProgram()
		{
			m_isStart = true;

			if(Stop.Enabled == false)
			{
				Stop.Enabled = true;
			}

			Reverse();
			Info.Text = "Программа запущенна...";
		}

		private void StopProgram()
		{
			m_isStart = false;
			Stop.Enabled = false;
			Reverse();
			Info.Text = "Программа остановлена...";
		}

		private bool CheckValidText()
		{
			if(CountMessage.Text.Length != 0 && Delay.Text.Length != 0)
			{
				char[] check = CountMessage.Text.ToCharArray();
				for (int i = 0; i < CountMessage.Text.Length; i++)
				{
					if(check[i] > '9' || check[i] < '0')
					{
						MessageBox.Show("Введите число в поле 'количество сообщений'.");
						return false;
					}
				}

				check = Delay.Text.ToCharArray();
				for (int i = 0; i < Delay.Text.Length; i++)
				{
					if (check[i] > '9' || check[i] < '0')
					{
						MessageBox.Show("Введите число в поле 'задержка'.");
						return false;
					}
				}

				maxCount = Convert.ToInt32(CountMessage.Text);
				m_Delay = Convert.ToInt32(Delay.Text) * 1000;

				if (m_Delay < 3000 || maxCount > 200 || m_Delay > 100000)
				{
					MessageBox.Show("Задержка должна быть не менее 3 секунд и не более 100, количество сообщений не более 200");
					return false;
				}
			}
			else
			{
				MessageBox.Show("Заполните поля задержка и количество сообщений!");
				return false;
			}
			return true;
		}

		private void Check()
		{
			if(!CheckValidText())
			{
				StopProgram();
			}
		}

		private void Reverse()
		{
			Delay.Enabled = !Delay.Enabled;
			CountMessage.Enabled = !CountMessage.Enabled;
			MessageText.Enabled = !MessageText.Enabled;
		}

		private void SendMessage()
		{
			SendKeys.Send("{ENTER}");
			CurrentCount.Text = $"{count++}";
		}

		public Form1()
		{
			InitializeComponent();
			m_callback = LowLevelKeyboardHookProc;
			Stop.Enabled = false;
			HookKey.SetHook(m_callback);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			StopProgram();
			count = 0;
		}

		async private void button1_Click(object sender, EventArgs e)
		{
			StartProgram();
			Check();

			await Task.Delay(5000);
			while (m_isStart == true)
			{
				if(!RandomAnecdot.Checked)
				{
					if (count == maxCount)
					{
						StopProgram();
						break;
					}
					if (MessageText.Text.Length != 0)
					{
						GetMessageText(MessageText.Text.ToCharArray());
					}
					else
					{
						StopProgram();
						MessageBox.Show("Введите текст сообщения!");
						break;
					}
					await Task.Delay(m_Delay);
				}
				else
				{
					Encoding utf8 = Encoding.GetEncoding("UTF-8");
					Encoding win1251 = Encoding.GetEncoding("Windows-1251");

					byte[] utf8Bytes = win1251.GetBytes(Anecdot.SearchAnecdot());
					byte[] win1251Bytes = Encoding.Convert(utf8, win1251, utf8Bytes);
					
					GetMessageText(win1251.GetString(win1251Bytes).ToCharArray());
					await Task.Delay(m_Delay);
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void Delay_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
