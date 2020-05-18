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
    public partial class VisitsForm : Form
    {
        BL.Cls_Visits Visit = new BL.Cls_Visits();
        public static int Com_patients;
        public static int CheckofOldvisit =0;
        PL.MainScreen MS = new MainScreen();
        BL.Cls_Old_Visits OV = new BL.Cls_Old_Visits();
        BL.Cls_Appointment appintment = new BL.Cls_Appointment();

        bool Enable_BtnAdd = true;
        bool Enable_Btn_Add_Chronic = true;
        public VisitsForm()
        {
            InitializeComponent();
         
            FillDGV();
            Fill_ComPaient();
            Fill_Names_Doctors();
            Com_Paient.SelectedValue = 0;
     
        }

      
        public  void Fill_ComPaient()
        {
            Com_Paient.DataSource = Visit.Get_Patient_Appointment();
            Com_Paient.DisplayMember = "Name";
            Com_Paient.ValueMember = "ID_P";
        }
        private void Fill_Names_Doctors()
        {
            Com_Doctors.DataSource = Visit.Get_All_Doctors();
            Com_Doctors.DisplayMember = "Name_D";
            Com_Doctors.ValueMember = "Id_D";
        }

        private void FillDGV()
        {

            DGV_Visits.DataSource = Visit.Get_All_Visits();
        
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar-SY");
            DGV_Visits.Columns[7].DefaultCellStyle.Format = "C0";
            DGV_Visits.Columns[8].DefaultCellStyle.Format = "C0";
            DGV_Visits.Columns[9].DefaultCellStyle.Format = "C0";
            DGV_Visits.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Visits.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn column in DGV_Visits.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Com_Paient.Text == "اختيار" || string.IsNullOrEmpty(Com_Paient.Text)||Enable_Btn_Add_Chronic==false)
            {
                Btn_Symptoms.Enabled = false;
            }
            else
            {
                Btn_Symptoms.Enabled = true;
                try
                {
                    CheckofOldvisit = Convert.ToInt32(Com_Paient.SelectedValue);
                    Com_patients = Convert.ToInt32(Com_Paient.SelectedValue);


                    Com_Paient.ForeColor = Color.Black;

                    DataTable dt = new DataTable();
                    dt = Visit.Count_Visits(Convert.ToInt32(Com_Paient.SelectedValue));
                    LabCount.Text = dt.Rows[0].Field<int>("COUNT").ToString();

                    dt = OV.Old_Visits1(VisitsForm.Com_patients);
                    if (dt.Rows.Count > 0)
                        RText_Approximate.Text = dt.Rows[0][2].ToString();
                    else
                        RText_Approximate.ResetText();

                    dt = appintment.Check_Appintment(Convert.ToInt32(Com_Paient.SelectedValue));

                    Fill_Names_Doctors();
                    Com_Doctors.SelectedValue = dt.Rows[0][6];


                }

                catch (Exception ex)
                {
                }
                label1.Focus();
            }  
        }

        private void VisitsForm_Load(object sender, EventArgs e)
        {

            Com_Paient.ResetText();
            Com_Paient.ForeColor = Color.Gray;
            Com_Paient.Text = "اختيار";

            Com_Doctors.ResetText();
            Com_Doctors.ForeColor = Color.Gray;
            Com_Doctors.Text = "اختيار";
            DGV_Visits.ClearSelection();
        }

        private void Btn_AddVisits_Click(object sender, EventArgs e)
        {
            try
            {
                if (Com_Paient.Text == "اختيار" || Com_Doctors.Text == "اختيار" ||string.IsNullOrEmpty(Com_Paient.Text)|| string.IsNullOrEmpty(RText_Treatment.Text) || string.IsNullOrEmpty(RText_Implement.Text) || string.IsNullOrEmpty(RText_Approximate.Text) || string.IsNullOrEmpty(RText_TotalPaid.Text) || string.IsNullOrEmpty(RText_Balance.Text))
                {
                    MessageBox.Show("لا يمكن ترك بيانات الاسم فارغة ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    return;
                }

                Visit.Update_Booking(Convert.ToInt32(Com_Paient.SelectedValue), false);
                Visit.Add_Visits(DateTime.Now, DateTime.Now.TimeOfDay, Convert.ToInt32(RText_Balance.Text), Convert.ToInt32(RText_Approximate.Text), Convert.ToInt32(RText_TotalPaid.Text), RText_Implement.Text, RText_Treatment.Text, Convert.ToInt32(Com_Paient.SelectedValue), Convert.ToInt32(Com_Doctors.SelectedValue));

                MessageBox.Show("تمت عملية إضافة المريض \n وتغيير حالة الحجز بنجاح  ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDGV();
                Fill_ComPaient();


                Btn_Reset_Click(sender, e);
            }
            catch (Exception ex) { }
        }
       

        private void RText_Balance_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(RText_Approximate.Text) || string.IsNullOrEmpty(RText_TotalPaid.Text))
                {
                    return;
                }

                int Approximate = Convert.ToInt32(RText_Approximate.Text);
                int NewTotalpaid = Convert.ToInt32(RText_TotalPaid.Text);

                DataTable dt = new DataTable();

                dt = Visit.Sum_totalpaid(Convert.ToInt32(Com_Paient.SelectedValue));
                int OldTotalpaid = dt.Rows[0].Field<int>("SUM");
                RText_Balance.Text = (Approximate - (NewTotalpaid + OldTotalpaid)).ToString();

                if (Convert.ToInt32(RText_Balance.Text) < 0)
                {
                    MessageBox.Show("  (المبالغ التي تم دفعها (السابقة و الحالية \n   .قد تجاوزت التكلفة التقريبية  ", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { }
           
        }

        private void RText_Approximate_KeyPress(object sender, KeyPressEventArgs e)
        {          
            Add_Doctor D = new Add_Doctor();
            D.OnlyNumber(e);
        }

        private void Com_Doctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            Com_Doctors.ForeColor = Color.Black;
            label6.Focus();

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Com_Paient.DropDownStyle = ComboBoxStyle.DropDown;

            Btn_AddVisits.Enabled = true;
            Btn_Update.Enabled = false;

            CheckofOldvisit = 0;
            Btn_Symptoms.Enabled = false;
            Enable_Btn_Add_Chronic = true;
            Com_Paient.ForeColor = Color.Gray;
            Com_Doctors.ForeColor = Color.Gray;
            Com_Paient.Text = "اختيار";
            Com_Paient.Focus();

            Com_Doctors.Text = "اختيار";

            LabCount.Text = "0";
            RText_Treatment.ResetText();
            RText_Implement.ResetText();
            RText_TotalPaid.ResetText();
            RText_Symptoms.ResetText();
            RText_Approximate.ResetText();
            RText_Balance.ResetText();
            DGV_Visits.ClearSelection();

        }

        private void Btn_Symptoms_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RText_Symptoms.Text))
            {
                MessageBox.Show("لا يمكن ترك بيانات الاسم فارغة ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Visit.Add_Chronics(RText_Symptoms.Text, Convert.ToInt32(Com_Paient.SelectedValue));
                MessageBox.Show("تمت عملية الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RText_Symptoms.ResetText();
            }
            catch (Exception ex) { }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (DGV_Visits.SelectedRows.Count > 0)      
                if (MessageBox.Show(" تأكيد عملية الحذف ؟ ", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Visit.Delete_Visits(Convert.ToInt32(DGV_Visits.CurrentRow.Cells[0].Value.ToString()));
                    FillDGV();
                    Btn_Reset_Click(sender, e);
                }
            
        }

        private void DGV_Visits_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DGV_Visits.SelectedRows.Count == 0)
                    return;

                Btn_Symptoms.Enabled = false;
                Enable_Btn_Add_Chronic = false;
                CheckofOldvisit = 0;
                Com_Paient.Text = this.DGV_Visits.CurrentRow.Cells[2].Value.ToString();
                Com_Doctors.Text = this.DGV_Visits.CurrentRow.Cells[3].Value.ToString();
                RText_Treatment.Text = this.DGV_Visits.CurrentRow.Cells[6].Value.ToString();
                RText_Implement.Text = this.DGV_Visits.CurrentRow.Cells[7].Value.ToString();
                RText_Approximate.Text = this.DGV_Visits.CurrentRow.Cells[8].Value.ToString();
                RText_TotalPaid.Text = this.DGV_Visits.CurrentRow.Cells[9].Value.ToString();
                RText_Balance.Text = this.DGV_Visits.CurrentRow.Cells[10].Value.ToString();

                Btn_Update.Enabled = true;
                Enable_BtnAdd = false;
                Btn_AddVisits.Enabled = false;
                DGV_Visits.ClearSelection();

                Com_Doctors.ForeColor = Color.Black;
                Com_Paient.ForeColor = Color.Black;
            }
            catch (Exception ex) { }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Com_Paient.Text == "اختيار" || Com_Doctors.Text == "اختيار" ||string.IsNullOrEmpty(Com_Paient.Text)|| string.IsNullOrEmpty(RText_Treatment.Text) || string.IsNullOrEmpty(RText_Implement.Text) || string.IsNullOrEmpty(RText_Approximate.Text) || string.IsNullOrEmpty(RText_TotalPaid.Text) || string.IsNullOrEmpty(RText_Balance.Text))
            {
                MessageBox.Show("لا يمكن ترك بيانات الاسم فارغة ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                return;
            }

            try
            {
                Visit.Update_Visits(Convert.ToInt32(DGV_Visits.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(RText_Balance.Text), Convert.ToInt32(RText_Approximate.Text), Convert.ToInt32(RText_TotalPaid.Text), RText_Implement.Text, RText_Treatment.Text, Convert.ToInt32(DGV_Visits.CurrentRow.Cells[1].Value.ToString()), Convert.ToInt32(Com_Doctors.SelectedValue));
                MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FillDGV();

            if (Enable_BtnAdd == false)
            {
                Btn_AddVisits.Enabled = true;
            }
            Btn_Update.Enabled = false;

            Btn_Reset_Click(sender, e);
            }
               catch (Exception ex)
            {
            }

        }


        private void VisitsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Btn_Reset_Click(sender, e);
            }
        }
     

        private void Com_Paient_KeyPress(object sender, KeyPressEventArgs e)
        {
            Com_Paient.DroppedDown = false;
        }

        private void Com_Doctors_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Com_Doctors_Enter(object sender, EventArgs e)
        {
            Com_Paient.SelectionLength = 0;
        }

        private void VisitsForm_Leave(object sender, EventArgs e)
        {
            CheckofOldvisit = 0;
        }

        private void Com_Paient_DropDownClosed(object sender, EventArgs e)
        {
            Com_Paient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1_SelectedIndexChanged(sender, e);
            Com_Paient.ForeColor = Color.Black;
            label1.Focus();
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            Com_Paient.Focus();

        }
    }
}
