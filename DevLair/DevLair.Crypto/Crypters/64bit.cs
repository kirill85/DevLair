using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevLair.Crypto
{
    sealed class _64bit : Crypter
    {

        public _64bit() 
        { 
            name = "64 bit Encryption"; 
        }

        public override string Encrypt(string str, string args)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff); 
        }
        public override string Decrypt(string str, string args)
        {
            byte[] decbuff = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }
    }
}
