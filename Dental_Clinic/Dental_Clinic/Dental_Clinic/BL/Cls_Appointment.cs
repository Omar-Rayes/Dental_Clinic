using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_Clinic.BL
{


    class Cls_Appointment
    {
        DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


        public DataTable Get_All_Appointment()
        {
            DataTable dt = new DataTable();
            dt = Dal.SelectDate("All_Appointment", null);

            Dal.Close();
            return dt;
        }


        public void Add_Appointment(string Type, Boolean Booking_status, DateTime date, TimeSpan  time, int ID_P, int Id_D)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Type", SqlDbType.NVarChar, 30);
            param[0].Value = Type;


            param[1] = new SqlParameter("@Booking", SqlDbType.Bit);
            param[1].Value = Booking_status;

            param[2] = new SqlParameter("@Date", SqlDbType.Date);
            param[2].Value = date;

            param[3] = new SqlParameter("@Time", SqlDbType.Time, 0);
            param[3].Value = time;


            param[4] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[4].Value = ID_P;

            param[5] = new SqlParameter("@Id_D", SqlDbType.TinyInt);
            param[5].Value = Id_D;



            Dal.ExecuteCommand("Add_Appointment", param);

            Dal.Close();

        }

        public void Delete_Appointment(int Id)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_Ap", SqlDbType.Int);
            param[0].Value = Id;

            Dal.ExecuteCommand("Delete_Appointment", param);

            Dal.Close();

        }

        public void Update_Appointmet(int id, string Type, bool Booking, DateTime date, TimeSpan time, int ID_P, int Id_D)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@ID_Ap", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@Type_Ap", SqlDbType.NVarChar, 30);
            param[1].Value = Type;

            param[2] = new SqlParameter("@Booking_Status", SqlDbType.Bit);
            param[2].Value = Booking;

            param[3] = new SqlParameter("@Select_Date", SqlDbType.Date);
            param[3].Value = date;

            param[4] = new SqlParameter("@Select_Time", SqlDbType.Time , 0);
            param[4].Value = time;

            param[5] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[5].Value = ID_P;

            param[6] = new SqlParameter("@Id_D", SqlDbType.TinyInt);
            param[6].Value = Id_D;

            Dal.ExecuteCommand("Update_Appintment", param);

            Dal.Close();
        }

        public DataTable Search_Appointment (string Name)
        {
            DataTable dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            param[0].Value = Name;

            dt = Dal.SelectDate("Search_Appointment", param);

            Dal.Close();
            return dt;

        }

        public DataTable Search_BYDAy(DateTime date)
        {
            DataTable dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@day", SqlDbType.Date);
            param[0].Value = date;

            dt = Dal.SelectDate("SearchByDay", param);

            Dal.Close();
            return dt;
        }
        public DataTable Search_ByHistory(DateTime date1 , DateTime date2)
        {
            DataTable dt = new DataTable();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@HistoryF", SqlDbType.Date);
            param[0].Value = date1;

            param[1] = new SqlParameter("@HistoryL", SqlDbType.Date);
            param[1].Value = date2;

            dt = Dal.SelectDate("Search_ByHistory", param);

            Dal.Close();
            return dt;
        }

        public DataTable Search_ByBooking(bool Check)
        {
            DataTable dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Check", SqlDbType.Bit);
            param[0].Value = Check;

            dt = Dal.SelectDate("Searech_Appointment_ByCheck", param);

            Dal.Close();
            return dt;
        }

        public DataTable Check_Appintment(int Id_P)
        {

            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[0].Value = Id_P;


            //    DAL.Open(); 

            DataTable dt = new DataTable();
            dt = DAL.SelectDate("Check_Appointment", param);

            DAL.Close();
            return dt;
        }

        public DataTable Check_Booking()
        {
            DataTable dt = new DataTable();

            dt = Dal.SelectDate("Check_Booking", null);

            Dal.Close();
            return dt;
        }

    }
}
