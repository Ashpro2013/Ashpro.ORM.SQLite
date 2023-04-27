using System;
using System.Collections.Generic;
using System.Text;

namespace Ashpro.ORM.SQLite
{
    public static class DBConnection
    {
        public static string Connection { get; set; }
        public static void SetConnection(string connection)
        {
            Connection = connection;
        }
        public static string GetConnection()
        {
            return Connection;
        }
    }

}
