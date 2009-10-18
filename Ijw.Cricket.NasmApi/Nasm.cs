using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Ijw.Cricket.NasmApi
{
    public static class Nasm
    {
        [DllImport("nasmapi.dll", CharSet = CharSet.Ansi)]
        public static extern int DisassembleOne(byte[] buffer, 
            int len, uint org, int off, 
            [Out] StringBuilder insn, out int instructionLength);
    }
}
