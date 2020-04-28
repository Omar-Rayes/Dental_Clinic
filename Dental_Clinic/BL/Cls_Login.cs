using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Dental_Clinic.BL
{
    class Cls_Login
    {
        public DataTable Login(string Name, string PWD)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;

            param[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 50);
            param[1].Value = PWD;

        //    DAL.Open(); 

            DataTable dt = new DataTable();
            dt = DAL.SelectDate("SP_LOGIN", param);

            DAL.Close();
            return dt;


        }

        public DataTable AllUser()
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
           

         //   DAL.Open();

            DataTable dt = new DataTable();
            dt = DAL.SelectDate("AllUser", null);

            DAL.Close();
            return dt;


        }


    }
}
