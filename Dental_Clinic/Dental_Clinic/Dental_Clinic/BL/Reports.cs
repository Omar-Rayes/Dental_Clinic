using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Dental_Clinic.BL
{
    class Reports
    {
        DAL.DataAccessLayer Dal = new DAL.DataAccessLayer();


        public DataTable Details_Paient(int ID_P)
        {
            Dal.Open();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID_P", SqlDbType.Int);
            param[0].Value = ID_P;

            DataTable dt = Dal.SelectDate("Details_Paients", param);

            Dal.Close();
            return dt;
        }
    }
}
