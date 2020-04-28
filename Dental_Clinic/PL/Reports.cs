using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dental_Clinic.PL
{
    public partial class Reports : Form
    {
        BL.Cls_Patient paient = new BL.Cls_Patient();
        BL.Cls_Old_Visits old_visit = new BL.Cls_Old_Visits();
        BL.Reports report = new BL.Reports();
        BL.Cls_Visits Visit = new BL.Cls_Visits();
        public Reports()
        {
            InitializeComponent();
            Fill_ComPaient();
            
        }

        private void Fill_ComPaient()
        {
            Com_RPaient.DataSource = paient.Get_All_Patient();
            Com_RPaient.DisplayMember = "Name";
            Com_RPaient.ValueMember = "ID_P";
        }

        private void Fill_Doctor_Cost()
        {
            DataTable dt = new DataTable();
           
                dt = old_visit.Old_Visits1(Convert.ToInt32(Com_RPaient.SelectedValue));
                if (dt.Rows.Count > 0)
                {
                    Lbl_Doctor.Text = dt.Rows[0][1].ToString();
                    Lbl_Approximate.Text = dt.Rows[0][2].ToString();
                    Lbl_Balance.Text = dt.Rows[0][3].ToString();
                }
               
            
            
        }

        private void Fill_Details_Paient()
        {
            DataTable dt = new DataTable();
           
                dt = report.Details_Paient(Convert.ToInt32(Com_RPaient.SelectedValue));
                Lbl_Address.Text = dt.Rows[0][2].ToString();
                Lbl_Phone.Text = dt.Rows[0][3].ToString();
                Lbl_LandLine.Text = dt.Rows[0][4].ToString();
                Lbl_Sex.Text = dt.Rows[0][5].ToString();

                if (dt.Rows[0][6].ToString() == "01/01/1900 12:00:00 ص")
                {
                    MTxt_Birthday.ResetText();
                    Lbl_Age.Text = "...";
                }
                else
               {
                   MTxt_Birthday.Text = dt.Rows[0][6].ToString();
                   Lbl_Age.Text = Convert.ToInt32((DateTime.Now.Subtract(Convert.ToDateTime(dt.Rows[0][6])).TotalDays / 365)).ToString();
                 
               }
            
          
        }

        private void Fill_Chronic()
        {

            DGV_Chronic.DataSource = old_visit.Chronic_OldVisits3(Convert.ToInt32(Com_RPaient.SelectedValue));
            DGV_Chronic.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void Fill_Count()
        {
            DataTable dt = new DataTable();
            dt = Visit.Count_Visits(1);
            Lbl_Count.Text = dt.Rows[0][0].ToString();
           
            
           
        }
        private void Fill_Details_Visiting()
        {
            
                DGV_Reports.DataSource = old_visit.Information_Old_Visits2(Convert.ToInt32(Com_RPaient.SelectedValue));

                DGV_Reports.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGV_Reports.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGV_Reports.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DGV_Reports.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;



                Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-SY");
                DGV_Reports.Columns[4].DefaultCellStyle.Format = "C";
                DGV_Reports.Columns[5].DefaultCellStyle.Format = "C";

                foreach (DataGridViewColumn column in DGV_Reports.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            
            
        }


        private void Reports_Load(object sender, EventArgs e)
        {
            
            Com_RPaient.ResetText();
            Com_RPaient.Text = "";
        }

        private void Com_RPaient_SelectedIndexChanged(object sender, EventArgs e)
        {     
            try
            {  
            if(Convert.ToInt32(Com_RPaient.SelectedValue)!=0)
                MTxt_Birthday.Visible = true;

                Fill_Details_Visiting();
                Fill_Count();
                Fill_Chronic();
                Fill_Doctor_Cost();
                Fill_Details_Paient();
     
           }
           catch (Exception ex) { }

            Lbl_Doctor.Focus();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {

            Com_RPaient.ResetText();
            Lbl_Doctor.ResetText();
            Lbl_Address.ResetText();
            Lbl_Age.ResetText();
            MTxt_Birthday.ResetText();
            MTxt_Birthday.Visible = false;
            Lbl_LandLine.ResetText();
            Lbl_Phone.ResetText();
            Lbl_Sex.ResetText();
            Lbl_Count.ResetText();
            Lbl_Balance.ResetText();
            Lbl_Approximate.ResetText();
            DGV_Chronic.DataSource = null;
            DGV_Reports.DataSource = null;
        }

        private void Reports_KeyDown(object sender, KeyEventArgs e)
        {  
            if(e.KeyCode==Keys.F5)
            Btn_Reset_Click(sender, e);
        }

        bool open = false;
        private void Com_RPaient_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && open == false)
            {
                Com_RPaient.DroppedDown = true;
                open = true;
            }
            else
            {
                Com_RPaient.DroppedDown = false;
                open = false;
            }
        }

        private void Com_RPaient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        
    }
}
