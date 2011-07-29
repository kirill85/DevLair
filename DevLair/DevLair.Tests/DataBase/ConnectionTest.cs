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
            Encrypter encrypter = new Encrypter("64bit");
            String connection = encrypter.Decrypt("U2VydmVyPXBvc3RncmVzNDguMWdiLnJ1O1BvcnQ9NTQzMjtVc2VyIElkPXhnYl9kZXZsYWlyO1Bhc3N3b3JkPTZlNzhlNjU2O0RhdGFiYXNlPXhnYl9kZXZsYWlyO0NvbW1hbmRUaW1lb3V0PTEwMDs=");

            NpgsqlConnection conn = 
                new NpgsqlConnection(connection);

            conn.Open();
            conn.Close();
        }
    }
}
