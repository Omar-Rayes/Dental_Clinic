using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic.PL
{
    public partial class Add_Doctor : Form
    {
        BL.Cls_Doctors Doc = new BL.Cls_Doctors();
        bool Enable_BtnAdd = true;
        public Add_Doctor()
        {
            InitializeComponent();
            FillDGV();
        }
        private void FillDGV()
        {
            DGV_Doctor.DataSource = Doc.Get_All_Doctors();

            DGV_Doctor.Columns[0].HeaderText = " رقم الطبيب ";
            DGV_Doctor.Columns[1].HeaderText = " الاسم ";
            DGV_Doctor.Columns[2].HeaderText = " الجنس  ";
            DGV_Doctor.Columns[3].HeaderText = " تاريخ الميلاد  ";
            DGV_Doctor.Columns[4].HeaderText = " رقم الهاتف ";
            DGV_Doctor.Columns[5].HeaderText = " الايميل ";

            DGV_Doctor.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Doctor.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV_Doctor.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            foreach (DataGridViewColumn column in DGV_Doctor.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        public bool ValidationOfBirthday()
        {
            int year = Convert.ToInt32(DateTime.Now.Subtract(DTP_Date. Value).TotalDays / 365);
            bool V;
            if (year <= 20 && MessageBox.Show(" !العمر لا يتجاوز 20 سنة ؟\n !هل تريد التحقق من بيانات تاريخ الولادة", "رسالة تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                V = true;
            }
            else
            {
                V = false;
            }
            return (V);
        }

       

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            
            string Gender ;
            if(Radio_M.Checked){
                Gender=Radio_M.Text;
            }
            else
            {
                Gender=Radio_F.Text;
            }

            if (string.IsNullOrEmpty(RText_Name.Text))
            {
                MessageBox.Show("لا يمكن ترك بيانات الاسم فارغة ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                return;
            }

            if (DTP_Date.Checked==true&& ValidationOfBirthday() == true)
                {
                    return;
                }
          
            
              try
            {

                Doc.Add_Doctors(RText_Name.Text, Gender, DTP_Date.Value , RText_Number.Text, RText_Email.Text);
                MessageBox.Show("تمت عملية الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);  

              FillDGV();

              Btn_Reset_Click(sender, e);
        }

            catch (Exception ex)
            {
            }
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Btn_Add.Enabled = true;
            Btn_Update.Enabled = false;
            RText_Name.ResetText();
            Radio_F.Checked = false;
            Radio_M.Checked = true;
            string t = "1900-01-01";
            DTP_Date.Value = Convert.ToDateTime(t);
            DTP_Date.Checked = false;
           RText_Number.ResetText();
            RText_Email.ResetText();
            DGV_Doctor.ClearSelection();
        }
        public void OnlyNumber(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0' : case '1' :case '2' :case'3':case'4':case'5':case'6':case'7':case'8':case'9':case(char)Keys.Back: case (char)Keys.Space: case(char)Keys.Enter:case('+'):
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        public void OnlyLetters(KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':case '1':case'2': case '3': case '4':case '5':case '6': case '7': case '8': case '9': 
                    e.Handled = true;
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }

        private void RText_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumber(e);
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

             string Gender ;
            if(Radio_M.Checked){
                Gender=Radio_M.Text;
            }
            else
            {
                Gender=Radio_F.Text;
            }

            if (string.IsNullOrEmpty(RText_Name.Text))
            {
                MessageBox.Show("لا يمكن ترك بيانات الاسم فارغة ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                return;
            }


            if (DTP_Date.Checked == true && ValidationOfBirthday() == true)
            {
                return;
            }

            try
            {
                Doc.Update_Doctor(Int32.Parse(DGV_Doctor.CurrentRow.Cells[0].Value.ToString()), RText_Name.Text, Gender, DTP_Date.Value, RText_Number.Text, RText_Email.Text);
                MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FillDGV();

                if (Enable_BtnAdd == false)
                {
                    Btn_Add.Enabled = true;
                }
                Btn_Update.Enabled = false;

                Btn_Reset_Click(sender, e);
            }
            catch (Exception ex)
            {
            }

        }

        private void DGV_Doctor_DoubleClick(object sender, EventArgs e)
        {
            
            try
            {
                if (DGV_Doctor.SelectedRows.Count == 0)
                    return;

                RText_Name.Text = this.DGV_Doctor.CurrentRow.Cells[1].Value.ToString();

                string Gender = this.DGV_Doctor.CurrentRow.Cells[2].Value.ToString();

                if (Gender == "ذكر")
                {
                    Radio_M.Checked = true;
                }
                else
                {
                    Radio_F.Checked = true;
                }
                if (string.IsNullOrEmpty(this.DGV_Doctor.CurrentRow.Cells[3].Value.ToString()))
                {
                    string t = DTP_Date.Text = "1900-01-01";
                    DTP_Date.Value = Convert.ToDateTime(t);
                }
                else
                {
                    DTP_Date.Value = Convert.ToDateTime(this.DGV_Doctor.CurrentRow.Cells[3].Value.ToString());

                }

                RText_Number.Text = this.DGV_Doctor.CurrentRow.Cells[4].Value.ToString();

                RText_Email.Text = this.DGV_Doctor.CurrentRow.Cells[5].Value.ToString();
                DGV_Doctor.ClearSelection();
                Enable_BtnAdd = false;
                Btn_Add.Enabled = false;
                Btn_Update.Enabled = true;
            }
            catch (Exception ex) { }

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (DGV_Doctor.SelectedRows.Count > 0)
            {
                MessageBox.Show("                  تحذير : عند حذف طبيب سيتم حذف  \n  (كامل نشاطاته (الحجوزات وزيارات المرضى لديه   ", "تحذير ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (MessageBox.Show(" تأكيد عملية الحذف ؟ ", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    Doc.Delete_Doctor(Int32.Parse(this.DGV_Doctor.CurrentRow.Cells[0].Value.ToString()));
                    FillDGV();
                    Btn_Reset_Click(sender, e);
                }
            }
        }

        private void RText_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyLetters(e);
        }

        private void Add_Doctor_Load(object sender, EventArgs e)
        {
            DGV_Doctor.ClearSelection();
            string t = DTP_Date.Text = "1900-01-01";
            DTP_Date.Value = Convert.ToDateTime(t);
            DTP_Date.Checked = false;
        }

        private void Add_Doctor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                Btn_Reset_Click(sender, e);
               
            }
        }

        private void DTP_Date_MouseUp(object sender, MouseEventArgs e)
        {
            if (((DateTimePicker)sender).Checked == false)
            {

                string t = "1900-01-01";
                DTP_Date.Value = Convert.ToDateTime(t);
                DTP_Date.Checked = false;

            }
        }

        }

        }

       

    

    
    

