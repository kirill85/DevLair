﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Npgsql;

namespace DevLair.ORM.Npgsql
{
    static class DLExecute
    {
        bool Execute(string sql)
        {
            NpgsqlCommand command = new NpgsqlCommand(sql, DLConnection.conn);
            Int32 rowsaffected;

            bool noerrors = true;

            try
            {
                try
                {
                    DLConnection.conn.Open();
                    rowsaffected = command.ExecuteNonQuery();
                }
                catch(Exception)
                {
                    noerrors = false;
                }
            }
            finally
            {
                DLConnection.conn.Close();
            }

            return noerrors;
        }
    }
}