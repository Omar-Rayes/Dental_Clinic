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
using System.IO;


namespace Dental_Clinic.PL
{
    public partial class BackUp : Form
    {
        string ServerNamePath = "" + Environment.CurrentDirectory + "\\ServerName.txt";
        string ServerName;
        SqlConnection con;

        SqlCommand com;
        public BackUp()
        {
            InitializeComponent();
            ServerName = File.ReadAllText(ServerNamePath);
            con = new SqlConnection(@"Data Source=" + ServerName + ";Database = Dental_Clinic;Integrated Security=True;");
        }


        private void Btn_Browse_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                RTxt_FileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RTxt_FileName.Text))
            {
                MessageBox.Show("الرجاء قم بتحديد مسار حفظ النسخة الاحتياطية  ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                return;
            }
            try
            {
                string filename = RTxt_FileName.Text + "\\Dental_Clinic" + DateTime.Now.ToShortDateString().Replace('/', '-') + " - " +
                    DateTime.Now.ToLongTimeString().Replace(':', '-');
                string Query = "Backup Database Dental_Clinic to Disk = '" + filename + ".bak'";
              

                com = new SqlCommand(Query, con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم إنشاء النسخة اختياطية بنجاح ", "إنشاء النسخة احتياطية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("  حدث خطأ لم يتم إنشاء نسخة احتياطية \n  لأنه ليس لديك الإذن بالحفظ في ذاك المجلد ", "استعادة النسخة احتياطية ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            }

        private void Btn_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "bak(*.bak)|*.bak";

            if (File.ShowDialog() == DialogResult.OK)
            {
                RTxt_file.Text = File.FileName;
            }
        }

        private void Btn_Rstore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RTxt_file.Text))
            {
                MessageBox.Show("الرجاء قم بتحديد مسار تواجد  النسخة الاحتياطية  ", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                return;
            }
            try
            {

                string Query = "Alter Database Dental_Clinic Set Offline With Rollback Immediate; Restore Database Dental_Clinic From Disk='" + RTxt_file.Text + "'";

                com = new SqlCommand(Query, con);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم استعادة النسخة اختياطية بنجاح ", "استعادة النسخة احتياطية ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("  حدث خطأ \n  ", "  لم يتم استعادة النسخة احتياطية ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void BackUp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RTxt_FileName.ResetText();
                RTxt_file.ResetText();
            }
        }

      
        
    }
}
