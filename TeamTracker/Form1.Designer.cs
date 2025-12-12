namespace TeamTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cb_Status = new ComboBox();
            cb_Proyek = new ComboBox();
            tb_Nama = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label12 = new Label();
            label9 = new Label();
            tb_Bug = new TextBox();
            tb_Fitur = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label13 = new Label();
            label14 = new Label();
            btn_Insert = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 19);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "TeamTracker";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 47);
            label2.Name = "label2";
            label2.Size = new Size(202, 15);
            label2.TabIndex = 1;
            label2.Text = "Developer Team performance Tracker";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_Status);
            groupBox1.Controls.Add(cb_Proyek);
            groupBox1.Controls.Add(tb_Nama);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(57, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 127);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATA DEVELOPER";
            // 
            // cb_Status
            // 
            cb_Status.FormattingEnabled = true;
            cb_Status.Location = new Point(126, 87);
            cb_Status.Name = "cb_Status";
            cb_Status.Size = new Size(193, 23);
            cb_Status.TabIndex = 8;
            cb_Status.SelectedIndexChanged += cb_Status_SelectedIndexChanged;
            // 
            // cb_Proyek
            // 
            cb_Proyek.FormattingEnabled = true;
            cb_Proyek.Location = new Point(126, 52);
            cb_Proyek.Name = "cb_Proyek";
            cb_Proyek.Size = new Size(193, 23);
            cb_Proyek.TabIndex = 7;
            cb_Proyek.SelectedIndexChanged += cb_Proyek_SelectedIndexChanged;
            // 
            // tb_Nama
            // 
            tb_Nama.Location = new Point(126, 22);
            tb_Nama.Name = "tb_Nama";
            tb_Nama.Size = new Size(312, 23);
            tb_Nama.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(110, 90);
            label8.Name = "label8";
            label8.Size = new Size(10, 15);
            label8.TabIndex = 5;
            label8.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(110, 55);
            label7.Name = "label7";
            label7.Size = new Size(10, 15);
            label7.TabIndex = 4;
            label7.Text = ":";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 25);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 3;
            label6.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 90);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 2;
            label5.Text = "Status Kontrak";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 57);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 1;
            label4.Text = "Pilih Proyek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 25);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 0;
            label3.Text = "Nama Developer";
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(tb_Bug);
            groupBox2.Controls.Add(tb_Fitur);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(57, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(593, 95);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "DATA KINERJA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(196, 59);
            label12.Name = "label12";
            label12.Size = new Size(163, 15);
            label12.TabIndex = 9;
            label12.Text = "(Jumlah bug yang dikerjakan)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(196, 26);
            label9.Name = "label9";
            label9.Size = new Size(164, 15);
            label9.TabIndex = 8;
            label9.Text = "(Jumlah fitur yang dikerjakan)";
            // 
            // tb_Bug
            // 
            tb_Bug.Location = new Point(126, 54);
            tb_Bug.Name = "tb_Bug";
            tb_Bug.Size = new Size(64, 23);
            tb_Bug.TabIndex = 7;
            // 
            // tb_Fitur
            // 
            tb_Fitur.Location = new Point(126, 22);
            tb_Fitur.Name = "tb_Fitur";
            tb_Fitur.Size = new Size(64, 23);
            tb_Fitur.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(110, 55);
            label10.Name = "label10";
            label10.Size = new Size(10, 15);
            label10.TabIndex = 4;
            label10.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(110, 25);
            label11.Name = "label11";
            label11.Size = new Size(10, 15);
            label11.TabIndex = 3;
            label11.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(9, 57);
            label13.Name = "label13";
            label13.Size = new Size(69, 15);
            label13.TabIndex = 1;
            label13.Text = "Jumlah Bug";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 25);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 0;
            label14.Text = "Fitur Selesai";
            label14.Click += label14_Click;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(57, 320);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(133, 23);
            btn_Insert.TabIndex = 10;
            btn_Insert.Text = "INSERT";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(243, 320);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(133, 23);
            btn_Update.TabIndex = 11;
            btn_Update.Text = "UPDATE";
            btn_Update.UseVisualStyleBackColor = true;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(426, 320);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(133, 23);
            btn_Delete.TabIndex = 12;
            btn_Delete.Text = "DELETE";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(57, 361);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(593, 237);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 619);
            Controls.Add(dataGridView1);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Update);
            Controls.Add(btn_Insert);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cb_Proyek;
        private TextBox tb_Nama;
        private Label label8;
        private Label label7;
        private Label label6;
        private ComboBox cb_Status;
        private GroupBox groupBox2;
        private TextBox tb_Bug;
        private TextBox tb_Fitur;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label12;
        private Label label9;
        private Button btn_Insert;
        private Button btn_Update;
        private Button btn_Delete;
        private DataGridView dataGridView1;
    }
}
