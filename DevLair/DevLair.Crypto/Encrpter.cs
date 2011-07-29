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
            SetCrypter(crpyterparam);
        }

        public bool SetCrypter(string crpyterparam = "64bit")
        {
            Tuple<Crypter,bool> match = crpyterparam.Match()
                .With(s => "64bit" == s, (string s) => new Tuple<Crypter, bool>(new _64bit(), true))
                .With(s => "AES"   == s, (string s) => new Tuple<Crypter,bool>(new AES(), true))
                .Default(f => new Tuple<Crypter, bool>(new _64bit(), false)) 
                .Return<Tuple<Crypter,bool>>();

            crypter = match.Item1;
            return match.Item2;
        }

        public string GetCrypter()
        {
            return crypter.Name;
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
