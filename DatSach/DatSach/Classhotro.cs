﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DatSach
{
    class classhotro
    {
        public static OleDbConnection connection;
        public static OleDbDataAdapter adapter;
        public static DataSet dataset;
        public static OleDbCommand command;

        public static void ketnoi()
        {
            string connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = F:/DatSach/Database1.mdb";
            connection = new OleDbConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (OleDbException)
            {
                MessageBox.Show("Loi ket noi CSDL");
            }
        }
        //Lấy dữ liệu database trong access qua datagridview
        public static DataSet Load_ListView(string select)
        {
            adapter = new OleDbDataAdapter(select, connection);
            dataset = new DataSet();
            adapter.Fill(dataset);
            return dataset;
        }
        public static void ThucThiLenh(string strCommand)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection.Open();
            command = new OleDbCommand(strCommand, connection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (OleDbException OleExe)
            {
                MessageBox.Show("" + OleExe.Message);
            }
            connection.Close();
        }
    }
}
