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
    public partial class Users : Form
    {
        BL.Cls_Login Log = new BL.Cls_Login();
        BL.Users user = new BL.Users();

        public Users()
        {
            InitializeComponent();
            Fill_DGV();
        }

        private void Fill_DGV()
        {   
            DGV_Users.DataSource = Log.AllUser();
            DGV_Users.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            DGV_Users.Columns[0].HeaderText = "رقم المستخدم ";
            DGV_Users.Columns[1].HeaderText = "اسم المستخدم ";
            DGV_Users.Columns[2].HeaderText = "كلمة المرور ";
            DGV_Users.Columns[3].HeaderText = "نوع الصلاحية ";


            foreach (DataGridViewColumn column in DGV_Users.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RText_User.ResetText();
            RText_Password.ResetText();
            Com_User.ResetText();
            DGV_Users.ClearSelection();

        }

        private void Btn_SaveSetting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RText_User.Text) || string.IsNullOrEmpty(RText_Password.Text) || string.IsNullOrEmpty(Com_User.SelectedItem.ToString()))
            {
                MessageBox.Show("الرجاء إكمال المعلومات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                user.Add_Users(RText_User.Text, RText_Password.Text, Com_User.SelectedItem.ToString());
                Fill_DGV();
                MessageBox.Show("تمت عملية الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" تأكيد عملية الحذف ؟ ", "عملية الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                user.Delete_Users(Convert.ToInt32(DGV_Users.CurrentRow.Cells[0].Value));
                Fill_DGV();
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

        private void DGV_Users_DoubleClick(object sender, EventArgs e)
        {
            RText_User.Text = DGV_Users.CurrentRow.Cells[1].Value.ToString();
            RText_Password.Text = DGV_Users.CurrentRow.Cells[2].Value.ToString();
            Com_User.Text = DGV_Users.CurrentRow.Cells[3].Value.ToString();


        }

        private void Btn_UpdateSetting_Click(object sender, EventArgs e)
        {
            
            try
            {
                user.Update_Users(Convert.ToInt32(DGV_Users.CurrentRow.Cells[0].Value), RText_User.Text, RText_Password.Text, Com_User.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Fill_DGV();
            MessageBox.Show("تمت عملية التعديل بنجاح", "عملية التعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Users_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                button2_Click(sender, e);
            }  

        }

        bool open = false;
        private void Com_User_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter && open==false)
            {
                Com_User.DroppedDown = true;
                open=true;
            }
            else if (e.KeyCode == Keys.Enter &&open==true)
            {
                Com_User.DroppedDown = false;
                open = false;
            }
        }

        private void Com_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Focus();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            DGV_Users.ClearSelection();
        }

        private void Com_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       
        
    }
}
