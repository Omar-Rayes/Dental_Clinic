using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dental_Clinic.BL
{
    class Cls_Old_Visits
    {
        DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();

        public DataTable Old_Visits1(int ID_P)
        {
            Dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[0].Value = ID_P;

            DataTable dt = Dal.SelectDate("Old_Visit1", param);

            Dal.Close();
            return dt;
        }

        public DataTable Information_Old_Visits2(int ID_P)
        {
            Dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[0].Value = ID_P;

            DataTable dt = Dal.SelectDate("Information_Old_Visits2", param);

            Dal.Close();
            return dt;
        }

        public DataTable Chronic_OldVisits3(int ID_P)
        {
            Dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[0].Value = ID_P;

            DataTable dt = Dal.SelectDate("Chronic_OldVisist3", param);

            Dal.Close();
            return dt;
        }

        public void Update_Visits(int id_Chronic, string Name)
        {

            Dal.Open();

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@ID_chronic", SqlDbType.Int);
            param[0].Value = id_Chronic;

            param[1] = new SqlParameter("@Name_Chronic", SqlDbType.NVarChar,200);
            param[1].Value = Name;


            Dal.ExecuteCommand("Update_chronic", param);

            Dal.Close();
        }

        public void Delete_Chronic(int ID)
        {
            Dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_CD", SqlDbType.Int);
            param[0].Value = ID;

            Dal.ExecuteCommand("Delete_Chronic", param);

            Dal.Close();
        }

    }
}
