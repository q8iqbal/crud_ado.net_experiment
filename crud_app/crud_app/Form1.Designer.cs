
namespace crud_app
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dp_birthday = new System.Windows.Forms.DateTimePicker();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.tb_allergies = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_create = new System.Windows.Forms.Button();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_mr_delete = new System.Windows.Forms.Button();
            this.bt_mr_update = new System.Windows.Forms.Button();
            this.bt_mr_create = new System.Windows.Forms.Button();
            this.dgv_mr_table = new System.Windows.Forms.DataGridView();
            this.cb_mr_patient = new System.Windows.Forms.ComboBox();
            this.tb_mr_desc = new System.Windows.Forms.TextBox();
            this.tb_mr_drugs = new System.Windows.Forms.TextBox();
            this.tb_mr_diagnosis = new System.Windows.Forms.TextBox();
            this.tb_mr_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mr_table)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(958, 529);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dp_birthday);
            this.tabPage1.Controls.Add(this.cb_sex);
            this.tabPage1.Controls.Add(this.tb_allergies);
            this.tabPage1.Controls.Add(this.tb_name);
            this.tabPage1.Controls.Add(this.tb_id);
            this.tabPage1.Controls.Add(this.bt_delete);
            this.tabPage1.Controls.Add(this.bt_update);
            this.tabPage1.Controls.Add(this.bt_create);
            this.tabPage1.Controls.Add(this.dgv_table);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dp_birthday
            // 
            this.dp_birthday.CustomFormat = "MM/dd/yyyy";
            this.dp_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_birthday.Location = new System.Drawing.Point(639, 91);
            this.dp_birthday.Name = "dp_birthday";
            this.dp_birthday.Size = new System.Drawing.Size(151, 27);
            this.dp_birthday.TabIndex = 13;
            // 
            // cb_sex
            // 
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "Pria",
            "Wanita"});
            this.cb_sex.Location = new System.Drawing.Point(639, 36);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(151, 28);
            this.cb_sex.TabIndex = 12;
            // 
            // tb_allergies
            // 
            this.tb_allergies.Location = new System.Drawing.Point(110, 145);
            this.tb_allergies.Name = "tb_allergies";
            this.tb_allergies.Size = new System.Drawing.Size(272, 27);
            this.tb_allergies.TabIndex = 11;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(110, 91);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(272, 27);
            this.tb_name.TabIndex = 10;
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(110, 37);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(272, 27);
            this.tb_id.TabIndex = 9;
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(224, 447);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(94, 29);
            this.bt_delete.TabIndex = 8;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(124, 447);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(94, 29);
            this.bt_update.TabIndex = 7;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(24, 447);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(94, 29);
            this.bt_create.TabIndex = 6;
            this.bt_create.Text = "Add";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
            // 
            // dgv_table
            // 
            this.dgv_table.AllowUserToAddRows = false;
            this.dgv_table.AllowUserToDeleteRows = false;
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Location = new System.Drawing.Point(24, 227);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.ReadOnly = true;
            this.dgv_table.RowHeadersWidth = 51;
            this.dgv_table.RowTemplate.Height = 29;
            this.dgv_table.Size = new System.Drawing.Size(899, 214);
            this.dgv_table.TabIndex = 5;
            this.dgv_table.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_table_RowHeaderMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(480, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(480, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tgl Lahir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alergi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_mr_delete);
            this.tabPage2.Controls.Add(this.bt_mr_update);
            this.tabPage2.Controls.Add(this.bt_mr_create);
            this.tabPage2.Controls.Add(this.dgv_mr_table);
            this.tabPage2.Controls.Add(this.cb_mr_patient);
            this.tabPage2.Controls.Add(this.tb_mr_desc);
            this.tabPage2.Controls.Add(this.tb_mr_drugs);
            this.tabPage2.Controls.Add(this.tb_mr_diagnosis);
            this.tabPage2.Controls.Add(this.tb_mr_id);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(950, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medical Records";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_mr_delete
            // 
            this.bt_mr_delete.Location = new System.Drawing.Point(232, 449);
            this.bt_mr_delete.Name = "bt_mr_delete";
            this.bt_mr_delete.Size = new System.Drawing.Size(94, 29);
            this.bt_mr_delete.TabIndex = 14;
            this.bt_mr_delete.Text = "Delete";
            this.bt_mr_delete.UseVisualStyleBackColor = true;
            this.bt_mr_delete.Click += new System.EventHandler(this.bt_mr_delete_Click);
            // 
            // bt_mr_update
            // 
            this.bt_mr_update.Location = new System.Drawing.Point(132, 449);
            this.bt_mr_update.Name = "bt_mr_update";
            this.bt_mr_update.Size = new System.Drawing.Size(94, 29);
            this.bt_mr_update.TabIndex = 13;
            this.bt_mr_update.Text = "Update";
            this.bt_mr_update.UseVisualStyleBackColor = true;
            this.bt_mr_update.Click += new System.EventHandler(this.bt_mr_update_Click);
            // 
            // bt_mr_create
            // 
            this.bt_mr_create.Location = new System.Drawing.Point(32, 450);
            this.bt_mr_create.Name = "bt_mr_create";
            this.bt_mr_create.Size = new System.Drawing.Size(94, 29);
            this.bt_mr_create.TabIndex = 12;
            this.bt_mr_create.Text = "Add";
            this.bt_mr_create.UseVisualStyleBackColor = true;
            this.bt_mr_create.Click += new System.EventHandler(this.bt_mr_create_Click);
            // 
            // dgv_mr_table
            // 
            this.dgv_mr_table.AllowUserToAddRows = false;
            this.dgv_mr_table.AllowUserToDeleteRows = false;
            this.dgv_mr_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mr_table.Location = new System.Drawing.Point(32, 200);
            this.dgv_mr_table.Name = "dgv_mr_table";
            this.dgv_mr_table.ReadOnly = true;
            this.dgv_mr_table.RowHeadersWidth = 51;
            this.dgv_mr_table.RowTemplate.Height = 29;
            this.dgv_mr_table.Size = new System.Drawing.Size(877, 243);
            this.dgv_mr_table.TabIndex = 11;
            this.dgv_mr_table.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_mr_table_RowHeaderMouseClick);
            // 
            // cb_mr_patient
            // 
            this.cb_mr_patient.FormattingEnabled = true;
            this.cb_mr_patient.Items.AddRange(new object[] {
            ""});
            this.cb_mr_patient.Location = new System.Drawing.Point(566, 43);
            this.cb_mr_patient.Name = "cb_mr_patient";
            this.cb_mr_patient.Size = new System.Drawing.Size(266, 28);
            this.cb_mr_patient.TabIndex = 10;
            // 
            // tb_mr_desc
            // 
            this.tb_mr_desc.Location = new System.Drawing.Point(566, 94);
            this.tb_mr_desc.Name = "tb_mr_desc";
            this.tb_mr_desc.Size = new System.Drawing.Size(266, 27);
            this.tb_mr_desc.TabIndex = 9;
            // 
            // tb_mr_drugs
            // 
            this.tb_mr_drugs.Location = new System.Drawing.Point(155, 147);
            this.tb_mr_drugs.Name = "tb_mr_drugs";
            this.tb_mr_drugs.Size = new System.Drawing.Size(237, 27);
            this.tb_mr_drugs.TabIndex = 8;
            // 
            // tb_mr_diagnosis
            // 
            this.tb_mr_diagnosis.Location = new System.Drawing.Point(155, 94);
            this.tb_mr_diagnosis.Name = "tb_mr_diagnosis";
            this.tb_mr_diagnosis.Size = new System.Drawing.Size(237, 27);
            this.tb_mr_diagnosis.TabIndex = 7;
            // 
            // tb_mr_id
            // 
            this.tb_mr_id.Location = new System.Drawing.Point(155, 43);
            this.tb_mr_id.Name = "tb_mr_id";
            this.tb_mr_id.Size = new System.Drawing.Size(237, 27);
            this.tb_mr_id.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(436, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 30);
            this.label11.TabIndex = 5;
            this.label11.Text = "Pasien";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(436, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 30);
            this.label10.TabIndex = 4;
            this.label10.Text = "Keterangan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(32, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Obat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(32, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Diagnosis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(32, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mr_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dp_birthday;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.TextBox tb_allergies;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.ComboBox cb_mr_patient;
        private System.Windows.Forms.TextBox tb_mr_desc;
        private System.Windows.Forms.TextBox tb_mr_drugs;
        private System.Windows.Forms.TextBox tb_mr_diagnosis;
        private System.Windows.Forms.TextBox tb_mr_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_mr_table;
        private System.Windows.Forms.Button bt_mr_delete;
        private System.Windows.Forms.Button bt_mr_update;
        private System.Windows.Forms.Button bt_mr_create;
    }
}

