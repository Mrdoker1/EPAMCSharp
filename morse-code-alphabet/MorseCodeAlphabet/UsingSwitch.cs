namespace MorseCodeAlphabet
{
    public static class UsingSwitch
    {
        public static byte GetMorseCode(char c)
        {
            switch (c)
            {
                case 'A':
                case 'a':
                    return 0x31;
                case 'B':
                case 'b':
                    return 0xFE;
                case 'C':
                case 'c':
                    return 0xFA;
                case 'D':
                case 'd':
                    return 0x76;
                case 'E':
                case 'e':
                    return 0x11;
                case 'F':
                case 'f':
                    return 0xFB;
                case 'G':
                case 'g':
                    return 0x74;
                case 'H':
                case 'h':
                    return 0xFF;
                case 'I':
                case 'i':
                    return 0x33;
                case 'J':
                case 'j':
                    return 0xF1;
                case 'K':
                case 'k':
                    return 0x72;
                case 'L':
                case 'l':
                    return 0xFD;
                case 'M':
                case 'm':
                    return 0x30;
                case 'N':
                case 'n':
                    return 0x32;
                case 'O':
                case 'o':
                    return 0x70;
                case 'P':
                case 'p':
                    return 0xF9;
                case 'Q':
                case 'q':
                    return 0xF4;
                case 'R':
                case 'r':
                    return 0x75;
                case 'S':
                case 's':
                    return 0x77;
                case 'T':
                case 't':
                    return 0x10;
                case 'U':
                case 'u':
                    return 0x73;
                case 'V':
                case 'v':
                    return 0xF7;
                case 'W':
                case 'w':
                    return 0x71;
                case 'X':
                case 'x':
                    return 0xF6;
                case 'Y':
                case 'y':
                    return 0xF2;
                case 'Z':
                case 'z':
                    return 0xFC;

                default:
                    return 0x00;
            }
        }
    }
}
