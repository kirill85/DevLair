using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Data;
using Npgsql;

namespace DevLair.Tests.DataBase
{
    [TestClass]
    public class ConnectionTest
    {
        [TestMethod]
        public void Connect()
        {

            byte[] decbuff = Convert.FromBase64String("U2VydmVyPXBvc3RncmVzNDguMWdiLnJ1O1BvcnQ9NTQzMjtVc2VyIElkPXhnYl9kZXZsYWlyO1Bhc3N3b3JkPTZlNzhlNjU2O0RhdGFiYXNlPXhnYl9kZXZsYWlyO0NvbW1hbmRUaW1lb3V0PTEwMDs=");

            NpgsqlConnection conn = 
                new NpgsqlConnection
                    ( System.Text.Encoding.UTF8.GetString(decbuff) );

            conn.Open();
            conn.Close();
        }
    }
}
