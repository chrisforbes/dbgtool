/* todo: include whatever system headers and nasm headers are reqd */

extern int disasm(unsigned char *data, char *output, int outbufsize, int segsize,
            int offset, int autosync, unsigned prefer);

int __declspec(dllexport) DisassembleOne(unsigned char * buf,		/* buffer containing code bytes */
										 unsigned length,			/* length of the source buffer */
										 unsigned org,				/* virtual address at which to disassemble */
										 unsigned off,				/* offset into the buffer */
										 char * output,				/* a buffer to accept the disassembled text */
										 int * inslen )				/* length of the instruction */	
{
	if (!output || !inslen)
		return 0;

	*output = 0;
	*inslen = disasm( buf + off, output, 1024, 32, org, 0, 0 );

	return !! *inslen;
}