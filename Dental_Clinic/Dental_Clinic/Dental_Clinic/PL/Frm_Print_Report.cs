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
    public partial class Frm_Print_Report : Form
    {
        BL.Reports report = new BL.Reports();
        BL.Cls_Old_Visits old_visit = new BL.Cls_Old_Visits();
        BL.Cls_Visits Visit = new BL.Cls_Visits();

        public Frm_Print_Report()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap b = new Bitmap(pn_Report.Width, pn_Report.Height);
            
            pn_Report.DrawToBitmap(b, new Rectangle(Point.Empty,pn_Report.Size));
            e.Graphics.DrawImage(b, 0, 0);
           
        }

        private void Fill_Details_Paient()
        {
            DataTable dt = new DataTable();

            dt = report.Details_Paient(Reports.Com_Patient);
            Lbl_NPatient.Text = dt.Rows[0][1].ToString();
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

        private void Fill_Details_Visiting()
        {

            DGV_Reports.DataSource = old_visit.Information_Old_Visits2(Reports.Com_Patient);

            DGV_Reports.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Reports.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Reports.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Reports.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;



            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-SY");
            DGV_Reports.Columns[4].DefaultCellStyle.Format = "C0";
            DGV_Reports.Columns[5].DefaultCellStyle.Format = "C0";

            foreach (DataGridViewColumn column in DGV_Reports.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void Fill_Chronic()
        {

            DGV_Chronic.DataSource = old_visit.Chronic_OldVisits3(Reports.Com_Patient);
            DGV_Chronic.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void Fill_Count()
        {
            DataTable dt = new DataTable();
            dt = Visit.Count_Visits(Reports.Com_Patient);
            Lbl_Count.Text = dt.Rows[0][0].ToString();
        }

        private void Fill_Doctor_Cost()
        {
            DataTable dt = new DataTable();

            dt = old_visit.Old_Visits1(Reports.Com_Patient);
            if (dt.Rows.Count > 0)
            {
                Lbl_Doctor.Text = dt.Rows[0][1].ToString();
                Lbl_Approximate.Text = dt.Rows[0][2].ToString() + "  ل.س ";
                Lbl_Balance.Text = dt.Rows[0][3].ToString() + "  ل.س ";
            }
        }



        private void Frm_Print_Report_Load(object sender, EventArgs e)
        {

            try
            {
                lbl_Name.Text = Properties.Settings.Default.Name.ToString();
                Lbl_Number.Text = Properties.Settings.Default.Number.ToString();
                Lbl_Email.Text = Properties.Settings.Default.Email.ToString();
                Lbl_Time.Text = Convert.ToString(DateTime.Now.ToString("ss : mm : hh  tt"));
                Lbl_Histort.Text = Convert.ToString(DateTime.Now.ToString("dd / MM / yyyy"));

                Fill_Details_Visiting();
                Fill_Count();
                Fill_Chronic();
                Fill_Doctor_Cost();
                Fill_Details_Paient();
                DGV_Reports.ClearSelection();
                DGV_Chronic.ClearSelection();
            }
            catch (Exception ex) { }


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
