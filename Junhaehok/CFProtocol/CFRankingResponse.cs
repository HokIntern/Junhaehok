using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Junhaehok.CFProtocol
{
    public struct UserHandle
    {
        public int Rank;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public char[] ID;
        public int MSGCOUNT;
        public UserHandle(int r, char[] i, int mc)
        {
            Rank = r;
            ID = new char[12];
            Array.Copy(i, ID, i.Length);
            MSGCOUNT = mc;
        }
    }
}
