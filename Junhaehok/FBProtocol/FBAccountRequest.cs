using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Junhaehok
{
    public struct FBSignupRequest
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public char[] user;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
        public char[] password;
    }

    public struct FBDeleteUserRequest
    {
    }

    public struct FBUpdateUserRequest
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
        public char[] password;
    }

    public struct FBDummySigninRequest
    {
    }

    public struct FBSigninRequest
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public char[] user;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
        public char[] password;
    }

    public struct FBSignoutRequest
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
        public char[] cookie;
    }
}
