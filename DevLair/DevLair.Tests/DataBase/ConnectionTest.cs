using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Data;
using Npgsql;
using nCrypto;

namespace DevLair.Tests.DataBase
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void Connect()
        {
            Encrypter encrypter = new Encrypter("64bit");

            String keyword = encrypter.Decrypt("QnV0IHlvdSBkb24ndCByZWFsbHkgbWVhbiBpdA==");

            // Check if crypter is changed
            Assert.AreEqual(true, encrypter.SetCrypter("AES"));

            String connection = encrypter.Decrypt
                ("Sf+ulELX4tNuvsQtUG2EZWPJDPhm8obnrSyEm7F5mtg/eziYSjoIZndeCHk8iZOhvAuMNJBxiiatrRHTt2LVFv/vJNoo8yCHkOO7TwUWv3+l8+Wpis4TSsEvc8zHgEPIucH/OQ2tyYlMboyoFH26dZLZ2Y+Kevfu79VfqLBcKGE=", keyword);

            NpgsqlConnection conn = 
                new NpgsqlConnection(connection);

            conn.Open();
            conn.Close();
        }
    }
}
