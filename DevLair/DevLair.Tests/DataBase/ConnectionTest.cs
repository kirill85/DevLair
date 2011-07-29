using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Data;
using Npgsql;
using DevLair.Crypto;

namespace DevLair.Tests.DataBase
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void Connect()
        {
            Encrypter _64encrypter = new Encrypter("64bit");
            String keyword = _64encrypter.Decrypt("QnV0IHlvdSBkb24ndCByZWFsbHkgbWVhbiBpdA==");

            Encrypter AESencrypter = new Encrypter("AES");
            String connection = AESencrypter.Decrypt
                ("Sf+ulELX4tNuvsQtUG2EZWPJDPhm8obnrSyEm7F5mtg/eziYSjoIZndeCHk8iZOhvAuMNJBxiiatrRHTt2LVFv/vJNoo8yCHkOO7TwUWv3+l8+Wpis4TSsEvc8zHgEPIucH/OQ2tyYlMboyoFH26dZLZ2Y+Kevfu79VfqLBcKGE=", keyword);

            NpgsqlConnection conn = 
                new NpgsqlConnection(connection);

            conn.Open();
            conn.Close();
        }
    }
}
