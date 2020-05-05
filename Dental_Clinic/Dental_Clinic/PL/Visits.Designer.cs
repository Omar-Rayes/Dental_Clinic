namespace Dental_Clinic.PL
{
    partial class VisitsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VisitsFrm = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.RText_Treatment = new System.Windows.Forms.RichTextBox();
            this.Com_Paient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RText_Approximate = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DGV_Visits = new System.Windows.Forms.DataGridView();
            this.RText_Balance = new System.Windows.Forms.RichTextBox();
            this.Com_Doctors = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RText_TotalPaid = new System.Windows.Forms.RichTextBox();
            this.RText_Implement = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Symptoms = new System.Windows.Forms.Button();
            this.RText_Symptoms = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_AddVisits = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabCount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.VisitsFrm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Visits)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VisitsFrm
            // 
            this.VisitsFrm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisitsFrm.Controls.Add(this.groupBox1);
            this.VisitsFrm.Font = new System.Drawing.Font("Arial", 9F);
            this.VisitsFrm.Location = new System.Drawing.Point(12, 12);
            this.VisitsFrm.Name = "VisitsFrm";
            this.VisitsFrm.Size = new System.Drawing.Size(1678, 684);
            this.VisitsFrm.TabIndex = 0;
            this.VisitsFrm.TabStop = false;
            this.VisitsFrm.Text = "معلومات الزيارات  ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.6F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1666, 628);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختيار مريض ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.80424F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.85176F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.39662F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.30552F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.64186F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.RText_Treatment, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Com_Paient, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.RText_Approximate, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DGV_Visits, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.RText_Balance, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.Com_Doctors, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.RText_TotalPaid, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.RText_Implement, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 5, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.611503F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.777219F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.445787F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.06671F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.88039F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.21839F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1660, 602);
            this.tableLayoutPanel1.TabIndex = 34;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F);
            this.label1.Location = new System.Drawing.Point(1488, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "اختيار اسم المريض :";
            // 
            // RText_Treatment
            // 
            this.RText_Treatment.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText_Treatment.Location = new System.Drawing.Point(1060, 79);
            this.RText_Treatment.Name = "RText_Treatment";
            this.RText_Treatment.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RText_Treatment.Size = new System.Drawing.Size(253, 31);
            this.RText_Treatment.TabIndex = 3;
            this.RText_Treatment.Text = "";
            // 
            // Com_Paient
            // 
            this.Com_Paient.Font = new System.Drawing.Font("Arial", 9F);
            this.Com_Paient.ForeColor = System.Drawing.Color.DarkGray;
            this.Com_Paient.FormattingEnabled = true;
            this.Com_Paient.Location = new System.Drawing.Point(1384, 79);
            this.Com_Paient.Name = "Com_Paient";
            this.Com_Paient.Size = new System.Drawing.Size(253, 29);
            this.Com_Paient.TabIndex = 1;
            this.Com_Paient.Text = "اختيار";
            this.Com_Paient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.Com_Paient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Com_Paient_KeyPress);
            this.Com_Paient.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Com_Paient_KeyUp);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F);
            this.label2.Location = new System.Drawing.Point(1246, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = " العلاج :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(887, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "التكلفة التقريبية :";
            // 
            // RText_Approximate
            // 
            this.RText_Approximate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText_Approximate.Location = new System.Drawing.Point(817, 79);
            this.RText_Approximate.Name = "RText_Approximate";
            this.RText_Approximate.Size = new System.Drawing.Size(187, 31);
            this.RText_Approximate.TabIndex = 5;
            this.RText_Approximate.Text = "";
            this.RText_Approximate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RText_Approximate_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F);
            this.label6.Location = new System.Drawing.Point(1571, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "الطبيب :";
            // 
            // DGV_Visits
            // 
            this.DGV_Visits.AllowUserToAddRows = false;
            this.DGV_Visits.AllowUserToDeleteRows = false;
            this.DGV_Visits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Visits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Visits.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DGV_Visits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Visits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGV_Visits, 5);
            this.DGV_Visits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Visits.Location = new System.Drawing.Point(3, 248);
            this.DGV_Visits.MultiSelect = false;
            this.DGV_Visits.Name = "DGV_Visits";
            this.DGV_Visits.ReadOnly = true;
            this.DGV_Visits.RowTemplate.Height = 29;
            this.DGV_Visits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Visits.Size = new System.Drawing.Size(1634, 274);
            this.DGV_Visits.TabIndex = 26;
            this.DGV_Visits.TabStop = false;
            this.DGV_Visits.DoubleClick += new System.EventHandler(this.DGV_Visits_DoubleClick);
            // 
            // RText_Balance
            // 
            this.RText_Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RText_Balance.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText_Balance.Location = new System.Drawing.Point(565, 186);
            this.RText_Balance.Name = "RText_Balance";
            this.RText_Balance.ReadOnly = true;
            this.RText_Balance.Size = new System.Drawing.Size(187, 31);
            this.RText_Balance.TabIndex = 7;
            this.RText_Balance.TabStop = false;
            this.RText_Balance.Text = "";
            this.toolTip1.SetToolTip(this.RText_Balance, "الباقي من كل المبالغ المدفوعة للزيارات \r\nالسابقة والحالية");
            this.RText_Balance.Click += new System.EventHandler(this.RText_Balance_Click);
            this.RText_Balance.TextChanged += new System.EventHandler(this.RText_Balance_TextChanged);
            this.RText_Balance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RText_Approximate_KeyPress);
            // 
            // Com_Doctors
            // 
            this.Com_Doctors.Font = new System.Drawing.Font("Arial", 9F);
            this.Com_Doctors.ForeColor = System.Drawing.Color.DarkGray;
            this.Com_Doctors.FormattingEnabled = true;
            this.Com_Doctors.Location = new System.Drawing.Point(1384, 186);
            this.Com_Doctors.Name = "Com_Doctors";
            this.Com_Doctors.Size = new System.Drawing.Size(253, 29);
            this.Com_Doctors.TabIndex = 2;
            this.Com_Doctors.Text = "اختيار";
            this.Com_Doctors.SelectedIndexChanged += new System.EventHandler(this.Com_Doctors_SelectedIndexChanged);
            this.Com_Doctors.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Com_Paient_KeyPress);
            this.Com_Doctors.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Com_Doctors_KeyUp);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F);
            this.label3.Location = new System.Drawing.Point(689, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "الباقي : ";
            // 
            // RText_TotalPaid
            // 
            this.RText_TotalPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RText_TotalPaid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText_TotalPaid.Location = new System.Drawing.Point(817, 186);
            this.RText_TotalPaid.Name = "RText_TotalPaid";
            this.RText_TotalPaid.Size = new System.Drawing.Size(187, 31);
            this.RText_TotalPaid.TabIndex = 6;
            this.RText_TotalPaid.Text = "";
            this.RText_TotalPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RText_Approximate_KeyPress);
            // 
            // RText_Implement
            // 
            this.RText_Implement.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText_Implement.Location = new System.Drawing.Point(1060, 186);
            this.RText_Implement.Name = "RText_Implement";
            this.RText_Implement.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RText_Implement.Size = new System.Drawing.Size(253, 31);
            this.RText_Implement.TabIndex = 4;
            this.RText_Implement.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F);
            this.label5.Location = new System.Drawing.Point(894, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "المبلغ المدفوع :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.Location = new System.Drawing.Point(1239, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "التحسن : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.Btn_Symptoms);
            this.groupBox2.Controls.Add(this.RText_Symptoms);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(138, 25);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 4);
            this.groupBox2.Size = new System.Drawing.Size(380, 208);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "إضافة أمراض مزمنة";
            // 
            // Btn_Symptoms
            // 
            this.Btn_Symptoms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Symptoms.BackColor = System.Drawing.Color.Black;
            this.Btn_Symptoms.Enabled = false;
            this.Btn_Symptoms.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Symptoms.ForeColor = System.Drawing.Color.White;
            this.Btn_Symptoms.Location = new System.Drawing.Point(227, 144);
            this.Btn_Symptoms.Name = "Btn_Symptoms";
            this.Btn_Symptoms.Size = new System.Drawing.Size(110, 40);
            this.Btn_Symptoms.TabIndex = 7;
            this.Btn_Symptoms.Text = "إضافة";
            this.Btn_Symptoms.UseVisualStyleBackColor = false;
            this.Btn_Symptoms.Click += new System.EventHandler(this.Btn_Symptoms_Click);
            // 
            // RText_Symptoms
            // 
            this.RText_Symptoms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RText_Symptoms.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText_Symptoms.Location = new System.Drawing.Point(73, 61);
            this.RText_Symptoms.Name = "RText_Symptoms";
            this.RText_Symptoms.Size = new System.Drawing.Size(264, 49);
            this.RText_Symptoms.TabIndex = 6;
            this.RText_Symptoms.Text = "";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.Location = new System.Drawing.Point(201, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "الأمراض المزمنة : ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(758, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 51);
            this.panel1.TabIndex = 27;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_AddVisits, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Delete, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Update, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Btn_Reset, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(879, 51);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // Btn_AddVisits
            // 
            this.Btn_AddVisits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_AddVisits.BackColor = System.Drawing.Color.Black;
            this.Btn_AddVisits.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_AddVisits.ForeColor = System.Drawing.Color.White;
            this.Btn_AddVisits.Location = new System.Drawing.Point(742, 5);
            this.Btn_AddVisits.Name = "Btn_AddVisits";
            this.Btn_AddVisits.Size = new System.Drawing.Size(134, 40);
            this.Btn_AddVisits.TabIndex = 8;
            this.Btn_AddVisits.Text = "إضافة";
            this.Btn_AddVisits.UseVisualStyleBackColor = false;
            this.Btn_AddVisits.Click += new System.EventHandler(this.Btn_AddVisits_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Delete.BackColor = System.Drawing.Color.Black;
            this.Btn_Delete.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(304, 5);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(134, 40);
            this.Btn_Delete.TabIndex = 10;
            this.Btn_Delete.Text = "حذف";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Update.BackColor = System.Drawing.Color.Black;
            this.Btn_Update.Enabled = false;
            this.Btn_Update.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Update.ForeColor = System.Drawing.Color.White;
            this.Btn_Update.Location = new System.Drawing.Point(523, 5);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(134, 40);
            this.Btn_Update.TabIndex = 9;
            this.Btn_Update.Text = "تعديل";
            this.Btn_Update.UseVisualStyleBackColor = false;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Reset.BackColor = System.Drawing.Color.Black;
            this.Btn_Reset.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Btn_Reset.ForeColor = System.Drawing.Color.White;
            this.Btn_Reset.Location = new System.Drawing.Point(85, 5);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(134, 40);
            this.Btn_Reset.TabIndex = 11;
            this.Btn_Reset.Text = "جديد";
            this.Btn_Reset.UseVisualStyleBackColor = false;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(524, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 38);
            this.label7.TabIndex = 32;
            this.label7.Text = "عدد الزيارات : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.LabCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 51);
            this.panel2.TabIndex = 33;
            // 
            // LabCount
            // 
            this.LabCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabCount.BackColor = System.Drawing.Color.PowderBlue;
            this.LabCount.Font = new System.Drawing.Font("Kozuka Gothic Pro M", 9F, System.Drawing.FontStyle.Bold);
            this.LabCount.Location = new System.Drawing.Point(406, 7);
            this.LabCount.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.LabCount.Name = "LabCount";
            this.LabCount.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LabCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabCount.Size = new System.Drawing.Size(109, 40);
            this.LabCount.TabIndex = 33;
            this.LabCount.Text = "0";
            this.LabCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // VisitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1709, 714);
            this.Controls.Add(this.VisitsFrm);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisitsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "الزيارات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VisitsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VisitsForm_KeyDown);
            this.VisitsFrm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Visits)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox VisitsFrm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox RText_Implement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox RText_TotalPaid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RText_Approximate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RText_Symptoms;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox RText_Balance;
        private System.Windows.Forms.DataGridView DGV_Visits;
        private System.Windows.Forms.Label LabCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_AddVisits;
        private System.Windows.Forms.Button Btn_Symptoms;
        private System.Windows.Forms.RichTextBox RText_Treatment;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox Com_Doctors;
        public System.Windows.Forms.ComboBox Com_Paient;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}