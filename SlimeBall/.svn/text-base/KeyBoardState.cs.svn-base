using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace SlimeBall
{
    class KeyBoardState
    {
        //allows access to unmanaged functions residing in the user32.dll
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling=true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        static extern short GetAsyncKeyState(VirtualKeyCodes vkey);

        [Flags]
        //a Hex value lookup table for easy reference
        public enum VirtualKeyCodes : int
        {
            Left = 0x25,
            Up = 0x26,
            Right = 0x27,
            Down = 0x28,
            A = 0x41,
            D = 0x44,
            S = 0x53,
            W = 0x57
        }

        public static bool GetKeyState(VirtualKeyCodes vkey)
        {
            short ret = GetAsyncKeyState(vkey);
            return ret != 0 ? true : false;
        }

        public static void GetKeyBoardState(ref byte[] lpKeyState)
        {
            GetKeyboardState(lpKeyState);            
            for (int i = 0; i < 256; i++)
                lpKeyState[i] = (byte)(lpKeyState[i] & (byte)0x80);
        }

    }
}
