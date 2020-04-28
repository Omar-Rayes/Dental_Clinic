using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_Clinic.BL
{
    class Users
    {

        DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


        public void Add_Users(string Name , string password , string User_Type)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;


            param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            param[1].Value = password;

            param[2] = new SqlParameter("@User_Type", SqlDbType.NVarChar, 50);
            param[2].Value = User_Type;

            Dal.ExecuteCommand("Add_Users", param);

            Dal.Close();

        }

        public void Delete_Users(int Id)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            Dal.ExecuteCommand("Delete_Users", param);

            Dal.Close();

        }

        public void Update_Users(int id, string Name, string password, string User_Type)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Password", SqlDbType.NVarChar, 50);
            param[2].Value = password;

            param[3] = new SqlParameter("@User_Type", SqlDbType.NVarChar, 50);
            param[3].Value = User_Type;

            Dal.ExecuteCommand("Update_Users", param);

            Dal.Close();
        }
    }
}
