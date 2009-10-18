using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Ijw.Cricket.NasmApi.Tests
{
    [TestFixture]
    public class TestDisassembly
    {
        [Test]
        public void Nop()
        {
            var insn = new StringBuilder(256);
            int instructionLength;
            Assert.AreEqual(1, Nasm.DisassembleOne(new byte[] { 0x90 }, 1, 0x400000, 0, insn, out instructionLength));
            Assert.AreEqual(1, instructionLength);
            Assert.AreEqual("nop", insn.ToString());
        }

        [Test]
        public void Jnz()
        {
            var insn = new StringBuilder(256);
            int instructionLength;
            Assert.AreEqual(1, Nasm.DisassembleOne(new byte[] { 0x75, 0x20 }, 2, 0x400000, 0, insn, out instructionLength));
            Assert.AreEqual(2, instructionLength);
            Assert.AreEqual("jnz 0x400022", insn.ToString());
        }
    }
}
