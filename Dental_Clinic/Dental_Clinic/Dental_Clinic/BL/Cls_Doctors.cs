using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Dental_Clinic.BL
{
    class Cls_Doctors
    {
        DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();

        public DataTable Get_All_Doctors()
        {

            DataTable dt = new DataTable();
            dt = Dal.SelectDate("All_Doctor", null);

            Dal.Close();
            return dt;

        }

        public void Add_Doctors(string Name, string Gender , DateTime Birthday , string Phone , string Email)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[5];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;


            param[1] = new SqlParameter("@Gender", SqlDbType.NVarChar,5);
            param[1].Value = Gender;

            param[2] = new SqlParameter("@Birthday", SqlDbType.Date);
            param[2].Value = Birthday;

            param[3] = new SqlParameter("@Phone", SqlDbType.NVarChar,50);
            param[3].Value = Phone;


            param[4] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            param[4].Value = Email;



            Dal.ExecuteCommand("Add_Doctor", param);

            Dal.Close();


        }
        public void Delete_Doctor(int Id)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            Dal.ExecuteCommand("Delete_Doctor", param);

            Dal.Close();


        }

        public void Update_Doctor(int id, string Name, string Gender , DateTime Birthday , string Phone , string Email)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[1].Value = Name;


            param[2] = new SqlParameter("@Gender", SqlDbType.NVarChar, 5);
            param[2].Value = Gender;

            param[3] = new SqlParameter("@Birthday", SqlDbType.Date);
            param[3].Value = Birthday;

            param[4] = new SqlParameter("@Phone", SqlDbType.NVarChar,50);
            param[4].Value = Phone;

            param[5] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            param[5].Value = Email;


            Dal.ExecuteCommand("Update_Doctor", param);

            Dal.Close();
        }


    }
}
