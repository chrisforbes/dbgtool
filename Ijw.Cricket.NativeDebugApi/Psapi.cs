using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Ijw.Cricket.NativeDebugApi
{
	public static class Psapi
	{
		[DllImport("psapi.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		public static extern int GetMappedFileName(IntPtr hProcess, IntPtr ptr, StringBuilder sb, int size);
	}
}
