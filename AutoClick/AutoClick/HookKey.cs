using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClick
{
	public static class HookKey
	{
		private const int WH_KEYBOARD_LL = 13;
		static public LowLevelKeyboardProcDelegate m_callback;
		static public IntPtr m_hHook;

		[DllImport("user32.dll", SetLastError = true)]
		private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProcDelegate lpfn, IntPtr hMod, int dwThreadId);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("Kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetModuleHandle(IntPtr lpModuleName);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		[StructLayout(LayoutKind.Sequential)]
		public struct KeyboardHookStruct
		{
			public readonly int VirtualKeyCode;
			public readonly int ScanCode;
			public readonly int Flags;
			public readonly int Time;
			public readonly IntPtr ExtraInfo;
		}
		public delegate IntPtr LowLevelKeyboardProcDelegate(
			int nCode, IntPtr wParam, IntPtr lParam);

		static public void SetHook(LowLevelKeyboardProcDelegate m_callback)
		{
			m_hHook = SetWindowsHookEx(WH_KEYBOARD_LL,
				m_callback,
				GetModuleHandle(IntPtr.Zero), 0);
		}

		static private void Unhook()
		{
			UnhookWindowsHookEx(m_hHook);
		}
	}
}
