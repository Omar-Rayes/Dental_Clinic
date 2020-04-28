using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_Clinic.BL
{
    class Cls_Visits
    {
        DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();

        public DataTable Get_Patient_Appointment()
        {

            DataTable dt = new DataTable();
            dt = Dal.SelectDate("Names_Paient", null);

            Dal.Close();
            return dt;
        }
        public DataTable Get_All_Doctors()
        {

            DataTable dt = new DataTable();
            dt = Dal.SelectDate("Names_Doctor", null);

            Dal.Close();
            return dt;
        }

        public void Add_Visits(DateTime Date , TimeSpan Time , int Paid , int Approximate_Cost , int Total_Paid ,string Improvement , string Treatment , int ID_P , int Id_D)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[9];

            param[0] = new SqlParameter("@Date", SqlDbType.Date);
            param[0].Value = Date;


            param[1] = new SqlParameter("@Time", SqlDbType.Time,0);
            param[1].Value = Time;

            param[2] = new SqlParameter("@Paid", SqlDbType.Int);
            param[2].Value = Paid;

            param[3] = new SqlParameter("@Approximate_Cost", SqlDbType.Int);
            param[3].Value = Approximate_Cost;


            param[4] = new SqlParameter("@Total_Paid", SqlDbType.Int);
            param[4].Value = Total_Paid;

            param[5] = new SqlParameter("@Improvement", SqlDbType.NVarChar , 1000);
            param[5].Value = Improvement;

            param[6] = new SqlParameter("@Add_Treatment", SqlDbType.NVarChar, 200);
            param[6].Value = Treatment;

            param[7] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[7].Value = ID_P;

            param[8] = new SqlParameter("@Id_D", SqlDbType.Int);
            param[8].Value = Id_D;


            Dal.ExecuteCommand("Add_Visits", param);

            Dal.Close();
        }
        public DataTable Get_All_Visits()
        {
            DataTable dt = new DataTable();
            dt = Dal.SelectDate("All_Vistiors", null);

            Dal.Close();
            return dt;
        }

        public void Delete_Visits(int id)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            Dal.ExecuteCommand("Delete_Visits", param);

            Dal.Close();
        }
        public void Update_Visits(int id_v  , int paid , int approximate_cost , int total_paid , string improvment , string Treatment , int id_p , int id_d )
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[8];

            param[0] = new SqlParameter("@ID_V", SqlDbType.Int);
            param[0].Value = id_v;

            param[1] = new SqlParameter("@Paid", SqlDbType.Int);
            param[1].Value = paid;

            param[2] = new SqlParameter("@Apporximate_Cost", SqlDbType.Int);
            param[2].Value = approximate_cost;

            param[3] = new SqlParameter("@Total_Paid", SqlDbType.Int);
            param[3].Value = total_paid;

            param[4] = new SqlParameter("@Improvement", SqlDbType.NVarChar,1000);
            param[4].Value = improvment;

            param[5] = new SqlParameter("@Add_Treatment", SqlDbType.NVarChar,200);
            param[5].Value = Treatment;
            
            param[6] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[6].Value = id_p;

            param[7] = new SqlParameter("@ID_D", SqlDbType.Int);
            param[7].Value = id_d;

            Dal.ExecuteCommand("Update_Visits", param);

            Dal.Close();
        }

        public DataTable Count_Visits(int ID_P)
        { 
            Dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[0].Value = ID_P;

            DataTable dt= Dal.SelectDate("Count_Visit", param);

            Dal.Close();
            return dt;
        }

        public DataTable Sum_totalpaid(int ID_P)
        {
            Dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[0].Value = ID_P;

            DataTable dt = Dal.SelectDate("Sum_TotalPaid", param);

            Dal.Close();
            return dt;
        }

        public void Add_Chronics(string Name , int ID_P)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar,200);
            param[0].Value = Name;

            param[1] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[1].Value = ID_P;


            Dal.ExecuteCommand("Add_Chronic", param);

            Dal.Close();
        }
    }
}
