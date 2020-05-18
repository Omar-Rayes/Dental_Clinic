using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace Dental_Clinic.PL
{
    public partial class MainScreen : Form
    {


        bool checkofScreen = true;
        public MainScreen()
        {
            InitializeComponent();

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel2.Text = "هاتف العيادة : " + Properties.Settings.Default.Number.ToString();
                toolStripStatusLabel3.Text = "ايميل العيادة : " + Properties.Settings.Default.Email.ToString();
                toolStripStatusLabel1.Text = "اسم العيادة : " + Properties.Settings.Default.Name.ToString();
                Pic_Box.Image = Image.FromFile(Properties.Settings.Default.Image.ToString());
            }
            catch (Exception ex) { }
            
            timer1.Enabled = true;
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Time.Text = Convert.ToString(DateTime.Now.ToString("ss : mm : hh  tt"));
            Lbl_Date.Text = Convert.ToString(DateTime.Now.ToString("dd / MM / yyyy"));

        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {      
            Application.Exit();
        }

        private void cdscsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Panel_Frm.Controls.Clear();

            Add_Doctor D = new Add_Doctor();
            D.TopLevel = false;

            Panel_Frm.Controls.Add(D);

            D.Show();
        }

        private void قسمToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Panel_Frm.Controls.Clear();

            Add_Patient P = new Add_Patient();

            P.TopLevel = false;

            Panel_Frm.Controls.Add(P);

            P.Show();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void يToolStripMenuItem_Click(object sender, EventArgs e)
        {    

            if (PL.VisitsForm.CheckofOldvisit !=0)
            {
                الزياراتالسابقةToolStripMenuItem.Enabled = true;
                VisitsForm.CheckofOldvisit = 0;

            }
            else
            {
                الزياراتالسابقةToolStripMenuItem.Enabled = false;
            }

        }

        private void معلوماتالزياراتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VisitsForm.CheckofOldvisit = 0;

            
            Panel_Frm.Controls.Clear();
            VisitsForm V = new VisitsForm();
            V.TopLevel = false;

            Panel_Frm.Controls.Add(V);
            V.Show();

        }

        private void الزياراتالسابقةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();
            Old_Visits Old_V = new Old_Visits();
            Old_V.TopLevel = false;

            Panel_Frm.Controls.Add(Old_V);
            Old_V.Show();

        }

       
        private void سيشسToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Panel_Frm.Controls.Clear();

            Appointment Appointment = new Appointment();

            Appointment.TopLevel = false;

            Panel_Frm.Controls.Add(Appointment);

            Appointment.Show();
        }

        private void تاريخالمريضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Reports Report = new Reports();

            Report.TopLevel = false;

            Panel_Frm.Controls.Add(Report);

            Report.Show();
        }

        private void ريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Setting setting = new Setting();

            setting.TopLevel = false;

            Panel_Frm.Controls.Add(setting);

            setting.Show();
        }

        private void المستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            Users user = new Users();

            user.TopLevel = false;

            Panel_Frm.Controls.Add(user);

            user.Show();
        }

        private void النسخالاحتياطيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel_Frm.Controls.Clear();

            BackUp backup = new BackUp();

            backup.TopLevel = false;

            Panel_Frm.Controls.Add(backup);

            backup.Show();
        }
 
        private void MainScreen_SizeChanged(object sender, EventArgs e)
        {

            if (checkofScreen == true)
            {

                this.WindowState = FormWindowState.Maximized;
                checkofScreen = false;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
                checkofScreen = true;
            }
        }

        private void Pic_Box_Click(object sender, EventArgs e)
        {

        }
      
        }
    }

       

      

        

        


    

