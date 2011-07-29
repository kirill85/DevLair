using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FunctionalCSharp;

namespace DevLair.Crypto
{
    public class Encrypter
    {
        private Crypter crypter;

        public Encrypter(string crpyterparam = "64bit")
        {
            crypter = crpyterparam.Match()
                        .With(s => "64bit"  == s, (string s) => new _64bit())
                        .With(s => "AES"    == s, (string s) => new AES())
                        .Default(f => new _64bit()) 
                        .Return<Crypter>();
        }

        public string Encrypt(string str, string args = null)
        {
            return crypter.Encrypt(str, args);
        }
        public string Decrypt(string str, string args = null)
        {
            return crypter.Decrypt(str, args);
        }
    }
}
