using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Transparent_Form
{
    /*
     * In this class Create the connection between application and mysql database
     * we need to install xampp and mysql connector to this project
     * we need to create the database
     */

    class DBconnect
    {
        //to create connection

        static string server = "denesgera.dyndns.hu";
        static string port = "13605";

        //static string server = "192.168.1.75";
        //static string port = "3307";


        static string database = "eszkozBeko";
        static string username = "denesgera";
        static string password = "deneske90";
        static string connectionString = $"Server={server};Port={port}; Database={database}; Uid={username}; Pwd={password};Connection Timeout=30;";


        MySqlConnection connect = new MySqlConnection(connectionString);

        //to get connection
        public MySqlConnection getconnection
        {
            get
            {
                return connect;
            }
        }
    

        //create a function to Open conncetion
        public void openConnect()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }

        //Create a fuction to close connection
        public void closeConnect()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }

    }


    }

