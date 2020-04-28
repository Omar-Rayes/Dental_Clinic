using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_Clinic.BL
{
    class Cls_Patient
    {
        DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


        public DataTable Get_All_Patient()
        {

            DataTable dt = new DataTable();
            dt = Dal.SelectDate("All_Patient", null);

            Dal.Close();
            return dt;

        }
        public DataTable Search_Paients(string Name)
        {

            DataTable dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;

            dt = Dal.SelectDate("Search_Paients", param);

            Dal.Close();
            return dt;

        }

        public void Add_Patient(string Name, string Address, string Phone, string Landline , string Gender , DateTime Birthday)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 25);
            param[0].Value = Name;


            param[1] = new SqlParameter("@Address", SqlDbType.NVarChar, 100);
            param[1].Value = Address;

            param[2] = new SqlParameter("@Phone", SqlDbType.NVarChar ,12);
            param[2].Value = Phone;

            param[3] = new SqlParameter("@LandLine", SqlDbType.NVarChar, 11);
            param[3].Value = Landline;


            param[4] = new SqlParameter("@Gender", SqlDbType.NVarChar, 5);
            param[4].Value = Gender;

            param[5] = new SqlParameter("@Birthday", SqlDbType.Date);
            param[5].Value = Birthday;



            Dal.ExecuteCommand("Add_Patient", param);

            Dal.Close();

        }

        public void Delete_Patient(int Id)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            Dal.ExecuteCommand("Delete_Patient", param);

            Dal.Close();


        }

        public void Update_Patient(int id, string Name, string Address, string Phone, string Land_line, string Gender , DateTime date)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@Name", SqlDbType.NVarChar, 25);
            param[1].Value = Name;

            param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, 100);
            param[2].Value = Address;

            param[3] = new SqlParameter("@Phone", SqlDbType.NVarChar, 12);
            param[3].Value = Phone;

            param[4] = new SqlParameter("@Land_line", SqlDbType.NVarChar,11);
            param[4].Value = Land_line;

            param[5] = new SqlParameter("@Gender", SqlDbType.NVarChar, 5);
            param[5].Value = Gender;

            param[6] = new SqlParameter("@Birthday", SqlDbType.Date);
            param[6].Value = date;


            Dal.ExecuteCommand("Update_Patient", param);

            Dal.Close();
        }

    }
}
