using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevLair.Crypto
{
    abstract class Crypter
    {
        public abstract string Encrypt(string str, string args);
        public abstract string Decrypt(string str, string args);
    }
}
