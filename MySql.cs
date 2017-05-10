using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using GrandTheftMultiplayer.Server.API;

namespace mysql
{
    class MySqlConnector : Script
    {
        private static MySqlConnection _connection;

        public MySqlConnector()
        {
            API.onResourceStart += API_onResourceStart;
            API.onResourceStop += API_onResourceStop;
        }

        private void API_onResourceStop()
        {
            _connection.Close();
        }

        private void API_onResourceStart()
        {
            _connection = new MySqlConnection("Server=localhost;database=;UID=;password=");
            _connection.Open();
        }
        public MySqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
