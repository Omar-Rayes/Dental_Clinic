using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Dental_Clinic.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
        public DataAccessLayer()
        {
            string path = "" + Environment.CurrentDirectory + "\\ServerName.txt";
                  String ServerName = System.IO.File.ReadAllText(path);

                  sqlconnection = new SqlConnection(@"Data Source=" + ServerName + ";Database = Dental_Clinic;Integrated Security=True;");
           
        }

        //Method to open the connection 

        public void Open()
        {

            if (sqlconnection.State != ConnectionState.Open)
            {

                sqlconnection.Open();
            }
        }

        //Method to close the connection 

        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }

        //Method to Read from Database

        public DataTable SelectDate(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcomd = new SqlCommand();
            sqlcomd.CommandType = CommandType.StoredProcedure;
            sqlcomd.CommandText = stored_procedure;
            sqlcomd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcomd.Parameters.Add(param[i]);

                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcomd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        //Method to insert , Update and delete data from database

        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    }
}
