﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Microsoft.Identity.Client;
using System.Windows.Forms;
using System.Reflection;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Mysqlx;
using MySqlX.XDevAPI.Common;

namespace Transparent_Form
{
	class ToolClass
	{
		static string idtool;
		public static string toolid
		{
			get
			{
				return idtool;
			}
			set
			{
				idtool = value;
			}
		}
		DBconnect connect = new DBconnect();
		//create a function to add a new tool to the database

		public bool InsertTool(string name, string size, string type, string quantity, string details, int limit)
		{
			MySqlCommand command = new MySqlCommand("INSERT INTO `eszkozok`(`toolName`, `toolSize`, `inDate`, `type`, `quantity`, `description`,`limit`) VALUES(@nm, @sz, @dt, @tp, @qua, @det, @lm)", connect.getconnection);
			MySqlCommand command2 = new MySqlCommand("INSERT INTO `felvetel`(`toolName`, `toolSize`, `inDate`, `type`, `quantity`, `description`,`limit`) VALUES(@nm, @sz, @dt, @tp, @qua, @det, @lm)", connect.getconnection);


            //@nm, @sz, @dt, @tp, @qua, @det
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
			command.Parameters.Add("@sz", MySqlDbType.VarChar).Value = size;
			command.Parameters.Add("@dt", MySqlDbType.DateTime).Value = DateTime.Now;
			command.Parameters.Add("@tp", MySqlDbType.VarChar).Value = type;
			command.Parameters.Add("@qua", MySqlDbType.VarChar).Value = quantity;
			command.Parameters.Add("@det", MySqlDbType.VarChar).Value = details;
			command.Parameters.Add("@lm", MySqlDbType.Int32).Value = limit;

            command2.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command2.Parameters.Add("@sz", MySqlDbType.VarChar).Value = size;
            command2.Parameters.Add("@dt", MySqlDbType.DateTime).Value = DateTime.Now;
            command2.Parameters.Add("@tp", MySqlDbType.VarChar).Value = type;
            command2.Parameters.Add("@qua", MySqlDbType.VarChar).Value = quantity;
            command2.Parameters.Add("@det", MySqlDbType.VarChar).Value = details;
			command2.Parameters.Add("@lm", MySqlDbType.Int32).Value = limit;


			connect.openConnect();

				if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
				{
					connect.closeConnect();
					return true;
				}
                else
                {
                    connect.closeConnect();
                    return false;
                }
            
            
        }

		// to get tool table
		public DataTable getToollist(MySqlCommand command)
		{
			command.Connection = connect.getconnection;
			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}

		public DataTable getHistory(MySqlCommand command)
		{
			command.Parameters.Add("@toolid", MySqlDbType.Int32).Value = Convert.ToInt32(ToolClass.toolid);

			command.Connection = connect.getconnection;
			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}

        public DataTable originTool(MySqlCommand command)
        {
            command.Parameters.Add("@toolid", MySqlDbType.Int32).Value = Convert.ToInt32(ToolClass.toolid);

            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        // Create a function to execute the count query(total, tool , etc)
        public string exeCount(string query)
		{
			MySqlCommand command = new MySqlCommand(query, connect.getconnection);
			connect.openConnect();
			string count = command.ExecuteScalar().ToString();
			connect.closeConnect();
			return count;
		}
		//to get the total tool
		public string totalTools()
		{
			return exeCount("SELECT COUNT(*) FROM eszkozok");
		}
		// to get the tool type count
		public string toolCount()
		{
			return exeCount("SELECT COUNT(*) FROM eszkozok WHERE `type`='Szerszám'");
		}
		// to get the etc type count
		public string etcCount()
		{
			return exeCount("SELECT COUNT(*) FROM eszkozok WHERE `type`='Egyéb'");
		}
		//create a function search for tool
		public DataTable searchTool(string searchdata)
		{
			MySqlCommand command = new MySqlCommand("SELECT `id` AS Azonosító, `toolName` AS Név, `toolSize` AS Méret, `inDate` AS 'Felvétel ideje', `type` AS Típus, `quantity` AS Mennyiség, `description` AS Részletek, `limit` AS Figyelmeztetés FROM `eszkozok` WHERE CONCAT(`toolName`,`toolSize`,`description`) LIKE '%" + searchdata + "%'", connect.getconnection);
			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
		//create a function edit for tool

		public bool kiadasTool(int id, string name, double size, string mtars,int kiadott,int quantity)
		{
			int remain = quantity - kiadott;
            MySqlCommand command = new MySqlCommand("INSERT INTO `history`(`tool_id`,`tool_name`,`tool_size`,`modified_date`,`munkatars`,`kiadott`) VALUES (@id,@nm,@sz,@md,@mt,@kia)", connect.getconnection);
            MySqlCommand command2 = new MySqlCommand("UPDATE `eszkozok` SET `quantity`=@qua WHERE `id`=@id", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@sz", MySqlDbType.Double).Value = size;
            command.Parameters.Add("@mt", MySqlDbType.VarChar).Value = mtars; 
            command.Parameters.Add("@kia", MySqlDbType.Int32).Value = kiadott;
            command.Parameters.Add("@md", MySqlDbType.DateTime).Value = DateTime.Now;

            command2.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
			command2.Parameters.Add("@qua", MySqlDbType.Int32).Value = remain;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public bool hozzaadTool(int id, string name, double size, string mtars, int kiadott, int quantity)
        {
            int remain = quantity + kiadott;
            MySqlCommand command = new MySqlCommand("INSERT INTO `history`(`tool_id`,`tool_name`,`tool_size`,`modified_date`,`munkatars`,`hozzaadott`) VALUES (@id,@nm,@sz,@md,@mt,@kia)", connect.getconnection);
            MySqlCommand command2 = new MySqlCommand("UPDATE `eszkozok` SET `quantity`=@qua WHERE `id`=@id", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@sz", MySqlDbType.Double).Value = size;
            command.Parameters.Add("@mt", MySqlDbType.VarChar).Value = mtars;
            command.Parameters.Add("@kia", MySqlDbType.Int32).Value = kiadott;
            command.Parameters.Add("@md", MySqlDbType.DateTime).Value = DateTime.Now;

            command2.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command2.Parameters.Add("@qua", MySqlDbType.Int32).Value = remain;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public bool updateTool(int id, string name, string quantity, string details, string mtars, int limit)
		{
			MySqlCommand command = new MySqlCommand("UPDATE `eszkozok` SET `toolName`=@nm,`quantity`=@qua,`description`=@det, `limit`=@lm WHERE `id`= @id", connect.getconnection);


            //@id,@nm, @sz, @dt, @tp, @qua, @det
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
			command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
			command.Parameters.Add("@qua", MySqlDbType.VarChar).Value = quantity;
			command.Parameters.Add("@det", MySqlDbType.VarChar).Value = details;
			command.Parameters.Add("@lm", MySqlDbType.Int32).Value = limit;

            connect.openConnect();
			if (command.ExecuteNonQuery() == 1)
			{
				connect.closeConnect();
				return true;
			}
			else
			{
				connect.closeConnect();
				return false;
			}

		}
       
        //Create a function to delete data
        //we need only id 
        public bool deleteTool(int id)
		{
			MySqlCommand command = new MySqlCommand("DELETE FROM `eszkozok` WHERE `id`=@id", connect.getconnection);
            MySqlCommand command2 = new MySqlCommand("DELETE FROM `felvetel` WHERE `id`=@id", connect.getconnection);


            //@id
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command2.Parameters.Add("@id", MySqlDbType.Int32).Value = id;


            connect.openConnect();
			if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery()==1)
			{
				connect.closeConnect();
				return true;
			}
			else
			{
				connect.closeConnect();
				return false;
			}

		}
		// create a function for any command in toolDb
		public DataTable getList(MySqlCommand command)
		{
			command.Connection = connect.getconnection;
			MySqlDataAdapter adapter = new MySqlDataAdapter(command);
			DataTable table = new DataTable();
			adapter.Fill(table);
			return table;
		}
        public DataTable getMtarslist(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchSzerszam(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT `tool_name` AS Név, `tool_size` AS Méret, `modified_date` AS Dátum, `munkatars` AS Munkatárs, `kiadott` AS Kiadott, `hozzaadott` AS Hozzáadott FROM `history` WHERE CONCAT(`tool_name`,`tool_size`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable searchMtars(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT `tool_name` AS Név, `tool_size` AS Méret, `modified_date` AS Dátum, `munkatars` AS Munkatárs, `kiadott` AS Kiadott, `hozzaadott` AS Hozzáadott FROM `history` WHERE CONCAT(`munkatars`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
