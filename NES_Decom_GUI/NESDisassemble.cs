using System.Text;
using System.IO;

namespace NES_Decom
{
    class NESDisassemble
    {
        public unsafe int Disassembler(byte* codeBuffer, int pc, string outputName)
        {

            string fileName = outputName;

            byte* code = &codeBuffer[pc];


            int opBytes = 1; //the default length of the OP Code

            using (var writer = new StreamWriter(fileName, true, Encoding.ASCII))
            {
                
                {
                    writer.AutoFlush = true;

                    switch (*code)

                    {
                        case 0x00: writer.WriteLine("$" + pc.ToString("X") + ":" + " BRK"); break;
                        case 0x01: writer.WriteLine("$" + pc.ToString("X") + ":" + " ORA    (${0:X2}, X)", code[1]); opBytes = 2; break;
                        case 0x05: writer.WriteLine("$" + pc.ToString("X") + ":" + " ORA    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x06: writer.WriteLine("$" + pc.ToString("X") + ":" + " ASL    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x08: writer.WriteLine("$" + pc.ToString("X") + ":" + " PHP"); break;
                        case 0x09: writer.WriteLine("$" + pc.ToString("X") + ":" + " ORA    #${0:X2}", code[1]); opBytes = 2; break;
                        case 0x0a: writer.WriteLine("$" + pc.ToString("X") + ":" + " ASL    A"); break;
                        case 0x0d: writer.WriteLine("$" + pc.ToString("X") + ":" + " ORA    ${0:X2}{1:X2}", code[2], code[1]); break;
                        case 0x0e: writer.WriteLine("$" + pc.ToString("X") + ":" + " ASL    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x10: writer.WriteLine("$" + pc.ToString("X") + ":" + " BPL    ${0:X2}", code[1]); break;
                        case 0x11: writer.WriteLine("$" + pc.ToString("X") + ":" + " ORA    (${0:X2}), Y", code[1]); opBytes = 2; break;
                        case 0x15: writer.WriteLine("$" + pc.ToString("X") + ":" + " ORA    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0x16: writer.WriteLine("$" + pc.ToString("X") + ":" + " ASL    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0x18: writer.WriteLine("$" + pc.ToString("X") + ":" + " CLC"); break;
                        case 0x19: writer.WriteLine("$" + pc.ToString("X") + ":" + " ORA    ${0:X2}{1:X2}, Y", code[2], code[1]); opBytes = 3; break;
                        case 0x1d: writer.WriteLine("$" + pc.ToString("X") + ":" + " ORA    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0x1e: writer.WriteLine("$" + pc.ToString("X") + ":" + " ASL    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0x20: writer.WriteLine("$" + pc.ToString("X") + ":" + " JSR    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x21: writer.WriteLine("$" + pc.ToString("X") + ":" + " AND    (${0:X2}, X)", code[1]); opBytes = 2; break;
                        case 0x24: writer.WriteLine("$" + pc.ToString("X") + ":" + " BIT    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x25: writer.WriteLine("$" + pc.ToString("X") + ":" + " AND    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x26: writer.WriteLine("$" + pc.ToString("X") + ":" + " ROL    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x28: writer.WriteLine("$" + pc.ToString("X") + ":" + " PLP"); break;
                        case 0x29: writer.WriteLine("$" + pc.ToString("X") + ":" + " AND    #${0:X2}", code[1]); opBytes = 2; break;
                        case 0x2a: writer.WriteLine("$" + pc.ToString("X") + ":" + " ROL    A"); break;
                        case 0x2c: writer.WriteLine("$" + pc.ToString("X") + ":" + " BIT    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x2d: writer.WriteLine("$" + pc.ToString("X") + ":" + " AND    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x2e: writer.WriteLine("$" + pc.ToString("X") + ":" + " ROL    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x30: writer.WriteLine("$" + pc.ToString("X") + ":" + " BMI    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x31: writer.WriteLine("$" + pc.ToString("X") + ":" + " AND    (${0:X2}), Y", code[1]); opBytes = 2; break;
                        case 0x35: writer.WriteLine("$" + pc.ToString("X") + ":" + " AND    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0x36: writer.WriteLine("$" + pc.ToString("X") + ":" + " ROL    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0x38: writer.WriteLine("$" + pc.ToString("X") + ":" + " SEC"); break;
                        case 0x39: writer.WriteLine("$" + pc.ToString("X") + ":" + " AND    ${0:X2}{1:X2}, Y", code[2], code[1]); opBytes = 3; break;
                        case 0x3d: writer.WriteLine("$" + pc.ToString("X") + ":" + " AND    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0x3e: writer.WriteLine("$" + pc.ToString("X") + ":" + " ROL    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0x40: writer.WriteLine("$" + pc.ToString("X") + ":" + " RTI"); break;
                        case 0x41: writer.WriteLine("$" + pc.ToString("X") + ":" + " EOR    (${0:X2}, X)", code[1]); opBytes = 2; break;
                        case 0x45: writer.WriteLine("$" + pc.ToString("X") + ":" + " EOR    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x46: writer.WriteLine("$" + pc.ToString("X") + ":" + " LSR    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x48: writer.WriteLine("$" + pc.ToString("X") + ":" + " PHA"); break;
                        case 0x49: writer.WriteLine("$" + pc.ToString("X") + ":" + " EOR    #${0:X2}", code[1]); opBytes = 2; break;
                        case 0x4a: writer.WriteLine("$" + pc.ToString("X") + ":" + " LSR    A"); break;
                        case 0x4c: writer.WriteLine("$" + pc.ToString("X") + ":" + " JMP    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x4d: writer.WriteLine("$" + pc.ToString("X") + ":" + " EOR    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x4e: writer.WriteLine("$" + pc.ToString("X") + ":" + " LSR    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x50: writer.WriteLine("$" + pc.ToString("X") + ":" + " BVC    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x51: writer.WriteLine("$" + pc.ToString("X") + ":" + " EOR    (${0:X2}), Y", code[1]); opBytes = 2; break;
                        case 0x55: writer.WriteLine("$" + pc.ToString("X") + ":" + " EOR    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0x56: writer.WriteLine("$" + pc.ToString("X") + ":" + " LSR    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0x58: writer.WriteLine("$" + pc.ToString("X") + ":" + " CLI"); break;
                        case 0x59: writer.WriteLine("$" + pc.ToString("X") + ":" + " EOR    ${0:X2}{1:X2}, Y", code[2], code[1]); opBytes = 3; break;
                        case 0x5d: writer.WriteLine("$" + pc.ToString("X") + ":" + " EOR    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0x5e: writer.WriteLine("$" + pc.ToString("X") + ":" + " LSR    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0x60: writer.WriteLine("$" + pc.ToString("X") + ":" + " RTS"); break;
                        case 0x61: writer.WriteLine("$" + pc.ToString("X") + ":" + " ADC    (${0:X2}, X)", code[1]); opBytes = 2; break;
                        case 0x65: writer.WriteLine("$" + pc.ToString("X") + ":" + " ADC    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x66: writer.WriteLine("$" + pc.ToString("X") + ":" + " ROR    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x68: writer.WriteLine("$" + pc.ToString("X") + ":" + " PLA"); break;
                        case 0x69: writer.WriteLine("$" + pc.ToString("X") + ":" + " ADC    #${0:X2}", code[1]); opBytes = 2; break;
                        case 0x6a: writer.WriteLine("$" + pc.ToString("X") + ":" + " ROR    A"); break;
                        case 0x6c: writer.WriteLine("$" + pc.ToString("X") + ":" + " JMP    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x6d: writer.WriteLine("$" + pc.ToString("X") + ":" + " ADC    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x6e: writer.WriteLine("$" + pc.ToString("X") + ":" + " ROR    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0x70: writer.WriteLine("$" + pc.ToString("X") + ":" + " BVS    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x71: writer.WriteLine("$" + pc.ToString("X") + ":" + " ADC    (${0:X2}), Y", code[1]); opBytes = 2; break;
                        case 0x75: writer.WriteLine("$" + pc.ToString("X") + ":" + " ADC    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0x76: writer.WriteLine("$" + pc.ToString("X") + ":" + " ROR    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0x78: writer.WriteLine("$" + pc.ToString("X") + ":" + " SEI"); break;
                        case 0x79: writer.WriteLine("$" + pc.ToString("X") + ":" + " ADC    ${0:X2}{1:X2}, Y", code[2], code[1]); opBytes = 3; break;
                        case 0x7d: writer.WriteLine("$" + pc.ToString("X") + ":" + " ADC    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0x7e: writer.WriteLine("$" + pc.ToString("X") + ":" + " ROR    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x81: writer.WriteLine("$" + pc.ToString("X") + ":" + " STA    (${0:X2}, X)", code[1]); opBytes = 2; break;
                        case 0x84: writer.WriteLine("$" + pc.ToString("X") + ":" + " STY    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x85: writer.WriteLine("$" + pc.ToString("X") + ":" + " STA    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x86: writer.WriteLine("$" + pc.ToString("X") + ":" + " STX    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x88: writer.WriteLine("$" + pc.ToString("X") + ":" + " DEY"); break;
                        case 0x8a: writer.WriteLine("$" + pc.ToString("X") + ":" + " TXA"); break;
                        case 0x8c: writer.WriteLine("$" + pc.ToString("X") + ":" + " STY    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x8d: writer.WriteLine("$" + pc.ToString("X") + ":" + " STA    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x8e: writer.WriteLine("$" + pc.ToString("X") + ":" + " STX    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0x90: writer.WriteLine("$" + pc.ToString("X") + ":" + " BCC    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0x91: writer.WriteLine("$" + pc.ToString("X") + ":" + " STA    (${0:X2}), Y", code[1]); opBytes = 2; break;
                        case 0x94: writer.WriteLine("$" + pc.ToString("X") + ":" + " STY    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0x95: writer.WriteLine("$" + pc.ToString("X") + ":" + " STA    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0x96: writer.WriteLine("$" + pc.ToString("X") + ":" + " STX    ${0:X2}, Y", code[1]); opBytes = 2; break;
                        case 0x98: writer.WriteLine("$" + pc.ToString("X") + ":" + " TYA"); break;
                        case 0x99: writer.WriteLine("$" + pc.ToString("X") + ":" + " STA    ${0:X2}{1:X2}, Y", code[2], code[1]); opBytes = 3; break;
                        case 0x9a: writer.WriteLine("$" + pc.ToString("X") + ":" + " TXS"); break;
                        case 0x9d: writer.WriteLine("$" + pc.ToString("X") + ":" + " STA    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0xa0: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDY    #${0:X2}", code[1]); opBytes = 2; break;
                        case 0xa1: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDA    (${0:X2}, X)", code[1]); opBytes = 2; break;
                        case 0xa2: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDX    #${0:X2}", code[1]); opBytes = 2; break;
                        case 0xa4: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDY    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xa5: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDA    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xa6: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDX    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xa8: writer.WriteLine("$" + pc.ToString("X") + ":" + " TAY"); break;
                        case 0xa9: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDA    #${0:X2}", code[1]); opBytes = 2; break;
                        case 0xaa: writer.WriteLine("$" + pc.ToString("X") + ":" + " TAX"); break;
                        case 0xac: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDY    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0xad: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDA    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0xae: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDX    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0xb0: writer.WriteLine("$" + pc.ToString("X") + ":" + " BCS    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xb1: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDA    (${0:X2}), Y", code[1]); opBytes = 2; break;
                        case 0xb4: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDY    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0xb5: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDA    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0xb6: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDX    ${0:X2}, Y", code[1]); opBytes = 2; break;
                        case 0xb8: writer.WriteLine("$" + pc.ToString("X") + ":" + " CLV"); break;
                        case 0xb9: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDA    ${0:X2}{1:X2}, Y", code[2], code[1]); opBytes = 3; break;
                        case 0xba: writer.WriteLine("$" + pc.ToString("X") + ":" + " TSX"); break;
                        case 0xbc: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDY    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0xbd: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDA    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0xbe: writer.WriteLine("$" + pc.ToString("X") + ":" + " LDX    ${0:X2}{1:X2}, Y", code[2], code[1]); opBytes = 3; break;
                        case 0xc0: writer.WriteLine("$" + pc.ToString("X") + ":" + " CPY    #${0:X2}", code[1]); opBytes = 2; break;
                        case 0xc1: writer.WriteLine("$" + pc.ToString("X") + ":" + " CMP    (${0:X2}, X)", code[1]);opBytes = 2; break;
                        case 0xc4: writer.WriteLine("$" + pc.ToString("X") + ":" + " CPY    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xc5: writer.WriteLine("$" + pc.ToString("X") + ":" + " CMP    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xc6: writer.WriteLine("$" + pc.ToString("X") + ":" + " DEC    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xc8: writer.WriteLine("$" + pc.ToString("X") + ":" + " INY"); break;
                        case 0xc9: writer.WriteLine("$" + pc.ToString("X") + ":" + " CMP    #${0:X2}", code[1]); opBytes = 2; break;
                        case 0xca: writer.WriteLine("$" + pc.ToString("X") + ":" + " DEX"); break;
                        case 0xcc: writer.WriteLine("$" + pc.ToString("X") + ":" + " CPY    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0xcd: writer.WriteLine("$" + pc.ToString("X") + ":" + " CMP    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0xce: writer.WriteLine("$" + pc.ToString("X") + ":" + " DEC    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0xd0: writer.WriteLine("$" + pc.ToString("X") + ":" + " BNE    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xd1: writer.WriteLine("$" + pc.ToString("X") + ":" + " CMP    (${0:X2}), Y", code[1]); opBytes = 2; break;
                        case 0xd5: writer.WriteLine("$" + pc.ToString("X") + ":" + " CMP    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0xd6: writer.WriteLine("$" + pc.ToString("X") + ":" + " DEC    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0xd8: writer.WriteLine("$" + pc.ToString("X") + ":" + " CLD"); break;
                        case 0xd9: writer.WriteLine("$" + pc.ToString("X") + ":" + " CMP    ${0:X2}{1:X2}, Y", code[2], code[1]); opBytes = 3; break;
                        case 0xdd: writer.WriteLine("$" + pc.ToString("X") + ":" + " CMP    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0xde: writer.WriteLine("$" + pc.ToString("X") + ":" + " DEC    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0xe0: writer.WriteLine("$" + pc.ToString("X") + ":" + " CPX    #${0:X2}", code[1]); opBytes = 2; break;
                        case 0xe1: writer.WriteLine("$" + pc.ToString("X") + ":" + " SBC    (${0:X2}, X)", code[1]); opBytes = 2; break;
                        case 0xe4: writer.WriteLine("$" + pc.ToString("X") + ":" + " CPX    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xe5: writer.WriteLine("$" + pc.ToString("X") + ":" + " SPC    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xe6: writer.WriteLine("$" + pc.ToString("X") + ":" + " INC    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xe8: writer.WriteLine("$" + pc.ToString("X") + ":" + " INX"); break;
                        case 0xe9: writer.WriteLine("$" + pc.ToString("X") + ":" + " SBC    #${0:X2}", code[1]); opBytes = 2; break;
                        case 0xea: writer.WriteLine("$" + pc.ToString("X") + ":" + " NOP"); break;
                        case 0xec: writer.WriteLine("$" + pc.ToString("X") + ":" + " CPX    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0xed: writer.WriteLine("$" + pc.ToString("X") + ":" + " SBC    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break;
                        case 0xee: writer.WriteLine("$" + pc.ToString("X") + ":" + " INC    ${0:X2}{1:X2}", code[2], code[1]); opBytes = 3; break; 
                        case 0xf0: writer.WriteLine("$" + pc.ToString("X") + ":" + " BEQ    ${0:X2}", code[1]); opBytes = 2; break;
                        case 0xf1: writer.WriteLine("$" + pc.ToString("X") + ":" + " SBC    (${0:X2}), Y", code[1]); opBytes = 2; break;
                        case 0xf5: writer.WriteLine("$" + pc.ToString("X") + ":" + " SBC    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0xf6: writer.WriteLine("$" + pc.ToString("X") + ":" + " INC    ${0:X2}, X", code[1]); opBytes = 2; break;
                        case 0xf8: writer.WriteLine("$" + pc.ToString("X") + ":" + " SED"); break;
                        case 0xf9: writer.WriteLine("$" + pc.ToString("X") + ":" + " SBC    ${0:X2}{1:X2}, Y", code[2], code[1]); opBytes = 3; break;
                        case 0xfd: writer.WriteLine("$" + pc.ToString("X") + ":" + " SBC    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;
                        case 0xfe: writer.WriteLine("$" + pc.ToString("X") + ":" + " INC    ${0:X2}{1:X2}, X", code[2], code[1]); opBytes = 3; break;



                            //https://www.youtube.com/watch?v=lJQKtUMNHmo


                    }

                }
                return opBytes;
            }

        }
    }
}