using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

namespace Rhyme.Tools.Helper
{
	public static class NativeMethodsHelper
	{
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpClassName, String lpWindowName);
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);
		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern uint RegisterWindowMessage(string lpString);

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern bool SetWindowText(IntPtr hwnd, String lpString);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

		[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern int GetWindowTextLength(IntPtr hWnd);

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, StringBuilder lParam);

		public const uint WM_GETTEXT = 0x000D;
		public const int WM_GETTEXTLENGTH = 0x000E;

		public struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}

		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetForegroundWindow();
		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		public static extern bool GetWindowRect(IntPtr hWnd, ref RECT rect);
		[DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, ExactSpelling = true, SetLastError = true)]
		public static extern void MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool SetForegroundWindow(IntPtr hWnd);

		public static ArrayList GetAllWindows()
		{
			var windowHandles = new ArrayList();
			EnumedWindow callBackPtr = GetWindowHandle;
			EnumWindows(callBackPtr, windowHandles);

			foreach (IntPtr windowHandle in windowHandles.ToArray())
			{
				EnumChildWindows(windowHandle, callBackPtr, windowHandles);
			}

			return windowHandles;
		}

		private delegate bool EnumedWindow(IntPtr handleWindow, ArrayList handles);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool EnumWindows(EnumedWindow lpEnumFunc, ArrayList lParam);

		[DllImport("user32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool EnumChildWindows(IntPtr window, EnumedWindow callback, ArrayList lParam);

		private static bool GetWindowHandle(IntPtr windowHandle, ArrayList windowHandles)
		{
			windowHandles.Add(windowHandle);
			return true;
		}

	}
}
