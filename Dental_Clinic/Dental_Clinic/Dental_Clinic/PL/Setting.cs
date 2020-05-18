using System;
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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            
        }
        string namePicture;
        private void Btn_DeletePic_Click(object sender, EventArgs e)
        {
            var pathimage = Properties.Settings.Default.Image.ToString();
            namePicture = pathimage.Substring(pathimage.LastIndexOf('\\') + 1);
           string[] FilePaths= Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, "PIC\\"));

           try
           {
               Pic_Box.Image = null;
               foreach (string file in FilePaths)
               {
                   if (file == Path.Combine(Environment.CurrentDirectory, "PIC\\" + namePicture + ""))
                   {

                       
                       continue;
                   }
                   else
                   {
                       File.Delete(file);

                   }

               }
           }
           catch (Exception ex) { }
        }

        private void Btn_ChoicePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            File.Filter = "jpg(*.jpg)|*.jpg|png(*.png)|*.png";

             
            if (File.ShowDialog()==DialogResult.OK)
            {
                Pic_Box.Image = Image.FromFile(File.FileName);

                string path = File.FileName;
                string imagepath = path;   
                namePicture = imagepath.Substring(imagepath.LastIndexOf('\\') + 1);
               
            }
        }

        private void Btn_SaveSetting_Click(object sender, EventArgs e)
        {
            
            
            if (string.IsNullOrEmpty(RText_Name.Text) || string.IsNullOrEmpty(RText_Number.Text) || string.IsNullOrEmpty(RText_Email.Text))
            {
                MessageBox.Show("الرجاء إكمال المعلومات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {   
                Properties.Settings.Default.Name = RText_Name.Text;
                Properties.Settings.Default.Number = Convert.ToInt32(RText_Number.Text);
                Properties.Settings.Default.Email = RText_Email.Text.ToString();

           
                try
                {
    
                   Pic_Box.Image.Save(Path.Combine(Environment.CurrentDirectory, "PIC\\"+namePicture+""));
                   Properties.Settings.Default.Image = Path.Combine(Environment.CurrentDirectory, "PIC\\"+namePicture+"").ToString();
                    
                }
                catch (Exception ex) { }
                finally
                {
                    Properties.Settings.Default.Save();

                    RText_Email.ResetText();
                    RText_Name.ResetText();
                    RText_Number.ResetText();
                    Pic_Box.Image = null;

                    if (MessageBox.Show(" هل تريد إعادة تشغيل البرنامج الأن أو لاحقا \n  لحفظ الإعدادات ؟ ", " تحذير ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            
        }

        private void Btn_LoadSetting_Click(object sender, EventArgs e)
        {
                RText_Name.Text = Properties.Settings.Default.Name;
                RText_Number.Text =  Properties.Settings.Default.Number.ToString();
                RText_Email.Text = Properties.Settings.Default.Email.ToString();
               
               try
                {   
                   Pic_Box.Image = Image.FromFile(Properties.Settings.Default.Image.ToString());
                }
                catch (Exception ex) { MessageBox.Show("لا يوجد صورة محفوظة في إعدادات البرنامج ","معلومات",MessageBoxButtons.OK,MessageBoxIcon.Information); }
                
        }

   

        private void RText_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            Add_Doctor D = new Add_Doctor();
            D.OnlyNumber(e);
        }

        private void Setting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RText_Name.ResetText();
                RText_Number.ResetText();
                RText_Email.ResetText();
                Pic_Box.Image = null;
            }
        }

        private void Pic_Box_Click(object sender, EventArgs e)
        {
            if (Pic_Box.Image == null)
            {
                return;
            }
           Pic_Box.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Pic_Box.Refresh();
        }

        private void RText_Number_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
