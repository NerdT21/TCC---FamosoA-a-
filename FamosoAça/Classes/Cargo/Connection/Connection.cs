using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FamosoAça.Classes
{
    public class Connection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=70.37.57.127; database=FamosoAcaiDB; uid=nsf; password=nsf@2018; SslMode=none";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
