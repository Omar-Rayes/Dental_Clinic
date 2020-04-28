using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace Dental_Clinic.PL
{
    public partial class Old_Visits : Form
    {
        BL.Cls_Old_Visits OV = new BL.Cls_Old_Visits();
        public Old_Visits()
        {
            InitializeComponent();
        }
        private void Fill_DGV_Chronic()
        {

            DGV_Chronic.DataSource = OV.Chronic_OldVisits3(VisitsForm.Com_patients);

            DGV_Chronic.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

           
        }
        private void Fill_DGV_Information()
        {
            DGV_OldVisits.DataSource = OV.Information_Old_Visits2(VisitsForm.Com_patients);

            DGV_OldVisits.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-SY");
            DGV_OldVisits.Columns[4].DefaultCellStyle.Format = "C";
            DGV_OldVisits.Columns[5].DefaultCellStyle.Format = "C";

            foreach (DataGridViewColumn column in DGV_OldVisits.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void Old_Visits_Load(object sender, EventArgs e)
        {
            try
            {
                Fill_DGV_Information();

                DataTable dt = new DataTable();
                dt = OV.Old_Visits1(VisitsForm.Com_patients);
                RText_Name.Text = dt.Rows[0][0].ToString();
                RText_Doctor.Text = dt.Rows[0][1].ToString();
                RText_Approximate.Text = dt.Rows[0][2].ToString();
                RText_Balance.Text = dt.Rows[0][3].ToString();

                Fill_DGV_Chronic();
                DGV_OldVisits.ClearSelection();
            }
            catch (Exception ex) { }

        }

        private void Btn_USymptoms_Click(object sender, EventArgs e)
        {
            try
            {
                OV.Update_Visits(Convert.ToInt32(DGV_Chronic.CurrentRow.Cells[0].Value.ToString()), Rtext_Uchronics.Text);
                Rtext_Uchronics.ResetText();
                Fill_DGV_Chronic();
                MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { }
        }

        private void DGV_Chronic_DoubleClick(object sender, EventArgs e)
        {
            Rtext_Uchronics.Text = DGV_Chronic.CurrentRow.Cells[1].Value.ToString();
        }

        private void Old_Visits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show(" تأكيد عملية الحذف ؟ ", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                   OV.Delete_Chronic(Int32.Parse(this.DGV_Chronic.CurrentRow.Cells[0].Value.ToString()));
                   Fill_DGV_Chronic(); 
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }


    }
}
