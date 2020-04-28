﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Dental_Clinic.PL
{
    public partial class Add_Patient : Form
    {
        BL.Cls_Patient Pa = new BL.Cls_Patient();

        public Add_Patient()
        {
            InitializeComponent();
            
            FillDGV();
           
          
            
        }

        private void FillDGV()
        {
            DGV_Patient.DataSource = Pa.Get_All_Patient();

            DGV_Patient.Columns[0].HeaderText = "الرقم ";
            DGV_Patient.Columns[1].HeaderText = "الاسم ";
            DGV_Patient.Columns[2].HeaderText = "العنوان ";
            DGV_Patient.Columns[3].HeaderText = "رقم الموبايل ";
            DGV_Patient.Columns[4].HeaderText = "الهاتف الأرضي ";
            DGV_Patient.Columns[5].HeaderText = "الجنس ";
            DGV_Patient.Columns[6].HeaderText = "المواليد ";

            DGV_Patient.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Patient.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Patient.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Patient.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Patient.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            foreach (DataGridViewColumn column in DGV_Patient.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            RText_Name.ResetText();
            RText_Address.ResetText();
            string t = "1900-01-01";
            DTP_Date.Value = Convert.ToDateTime(t);
            DTP_Date.Checked = false;
            RText_Number.ResetText();
            RText_Landline.ResetText();
            Radio_F.Checked = false;
            Radio_M.Checked = true;
            DGV_Patient.ClearSelection();


        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string Gender;
            if (Radio_M.Checked)
            {
                Gender = Radio_M.Text;
            }
            else
            {
                Gender = Radio_F.Text;
            }

            if (string.IsNullOrEmpty(RText_Name.Text))
            {
                MessageBox.Show("لا يمكن ترك بيانات الاسم فارغة ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                return;
            }

           

            try
            {
                Pa.Add_Patient(RText_Name.Text, RText_Address.Text, RText_Number.Text, RText_Landline.Text, Gender, DTP_Date.Value);
         

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FillDGV();
            MessageBox.Show("تمت عملية الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void RText_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            Add_Doctor D = new Add_Doctor();
            D.OnlyLetters(e);
        }

        private void RText_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            Add_Doctor D = new Add_Doctor();
            D.OnlyNumber(e);
        }

        private void Add_Patient_Load(object sender, EventArgs e)
        {
            string t  = "1900-01-01";
            DTP_Date.Value = Convert.ToDateTime(t);
            DTP_Date.Checked = false;
            DGV_Patient.ClearSelection();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" تأكيد عملية الحذف ؟ ", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Pa.Delete_Patient(Int32.Parse(this.DGV_Patient.CurrentRow.Cells[0].Value.ToString()));
                FillDGV();
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            string Gender;
            if (Radio_M.Checked)
            {
                Gender = Radio_M.Text;
            }
            else
            {
                Gender = Radio_F.Text;
            }

            if (string.IsNullOrEmpty(RText_Name.Text))
            {
                MessageBox.Show("لا يمكن ترك بيانات الاسم فارغة ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                return;
            }

            try
            {
                Pa.Update_Patient(Int32.Parse( DGV_Patient.CurrentRow.Cells[0].Value.ToString()), RText_Name.Text,RText_Address.Text,RText_Number.Text,RText_Landline.Text, Gender, DTP_Date.Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FillDGV();
            MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void DGV_Patient_DoubleClick(object sender, EventArgs e)
        {
            RText_Name.Text = this.DGV_Patient.CurrentRow.Cells[1].Value.ToString();

            string Gender = this.DGV_Patient.CurrentRow.Cells[5].Value.ToString();

            if (Gender == "ذكر")
            {
                Radio_M.Checked = true;
            }
            else
            {
                Radio_F.Checked = true;
            }

            if (string.IsNullOrEmpty(this.DGV_Patient.CurrentRow.Cells[6].Value.ToString()))
            {
                string t = "1900-01-01";
                DTP_Date.Value = Convert.ToDateTime(t);
            }
            else
            {
                DTP_Date.Value = Convert.ToDateTime(this.DGV_Patient.CurrentRow.Cells[6].Value.ToString());
            }

            RText_Number.Text = this.DGV_Patient.CurrentRow.Cells[3].Value.ToString();
            RText_Landline.Text = this.DGV_Patient.CurrentRow.Cells[4].Value.ToString();
            RText_Address.Text = this.DGV_Patient.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
          dt= Pa.Search_Paients(RText_Search.Text);

          DGV_Patient.DataSource = dt;
        }

        private void Add_Patient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Btn_Reset_Click(sender, e);

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DTP_Date_MouseUp(object sender, MouseEventArgs e)
        {
            if (((DateTimePicker)sender).Checked==false)
            {
   
                string t = "1900-01-01";
                DTP_Date.Value = Convert.ToDateTime(t);
                DTP_Date.Checked = false;

            }
               

        }

       
    }
}
