namespace Covid19_Recommender_System
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmcAge = new System.Windows.Forms.NumericUpDown();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoNotVaccinated = new System.Windows.Forms.RadioButton();
            this.rdoVaccinated = new System.Windows.Forms.RadioButton();
            this.cmbVaccine = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstYourSymptoms = new System.Windows.Forms.ListBox();
            this.lstAllSymptoms = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkSocial = new System.Windows.Forms.CheckBox();
            this.chkSanitize = new System.Windows.Forms.CheckBox();
            this.chkMasks = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtRecommendation = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcAge)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmcAge);
            this.groupBox1.Controls.Add(this.txtNIC);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Years";
            // 
            // nmcAge
            // 
            this.nmcAge.Location = new System.Drawing.Point(72, 84);
            this.nmcAge.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nmcAge.Name = "nmcAge";
            this.nmcAge.Size = new System.Drawing.Size(81, 27);
            this.nmcAge.TabIndex = 5;
            this.nmcAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(72, 131);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(176, 27);
            this.txtNIC.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 27);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoNotVaccinated);
            this.groupBox2.Controls.Add(this.rdoVaccinated);
            this.groupBox2.Controls.Add(this.cmbVaccine);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vaccination Details";
            // 
            // rdoNotVaccinated
            // 
            this.rdoNotVaccinated.AutoSize = true;
            this.rdoNotVaccinated.Location = new System.Drawing.Point(15, 63);
            this.rdoNotVaccinated.Name = "rdoNotVaccinated";
            this.rdoNotVaccinated.Size = new System.Drawing.Size(144, 24);
            this.rdoNotVaccinated.TabIndex = 3;
            this.rdoNotVaccinated.TabStop = true;
            this.rdoNotVaccinated.Text = "Not Vaccinated";
            this.rdoNotVaccinated.UseVisualStyleBackColor = true;
            this.rdoNotVaccinated.CheckedChanged += new System.EventHandler(this.rdoNotVaccinated_CheckedChanged);
            // 
            // rdoVaccinated
            // 
            this.rdoVaccinated.AutoSize = true;
            this.rdoVaccinated.Location = new System.Drawing.Point(15, 33);
            this.rdoVaccinated.Name = "rdoVaccinated";
            this.rdoVaccinated.Size = new System.Drawing.Size(113, 24);
            this.rdoVaccinated.TabIndex = 2;
            this.rdoVaccinated.TabStop = true;
            this.rdoVaccinated.Text = "Vaccinated";
            this.rdoVaccinated.UseVisualStyleBackColor = true;
            this.rdoVaccinated.CheckedChanged += new System.EventHandler(this.rdoVaccinated_CheckedChanged);
            // 
            // cmbVaccine
            // 
            this.cmbVaccine.FormattingEnabled = true;
            this.cmbVaccine.Location = new System.Drawing.Point(89, 108);
            this.cmbVaccine.Name = "cmbVaccine";
            this.cmbVaccine.Size = new System.Drawing.Size(159, 28);
            this.cmbVaccine.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vaccine:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstYourSymptoms);
            this.groupBox3.Controls.Add(this.lstAllSymptoms);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(322, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(285, 379);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symptom Details";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lstYourSymptoms
            // 
            this.lstYourSymptoms.FormattingEnabled = true;
            this.lstYourSymptoms.ItemHeight = 20;
            this.lstYourSymptoms.Location = new System.Drawing.Point(18, 225);
            this.lstYourSymptoms.Name = "lstYourSymptoms";
            this.lstYourSymptoms.Size = new System.Drawing.Size(250, 124);
            this.lstYourSymptoms.TabIndex = 3;
            this.lstYourSymptoms.DoubleClick += new System.EventHandler(this.lstYourSymptoms_DoubleClick);
            // 
            // lstAllSymptoms
            // 
            this.lstAllSymptoms.FormattingEnabled = true;
            this.lstAllSymptoms.ItemHeight = 20;
            this.lstAllSymptoms.Location = new System.Drawing.Point(18, 63);
            this.lstAllSymptoms.Name = "lstAllSymptoms";
            this.lstAllSymptoms.Size = new System.Drawing.Size(250, 124);
            this.lstAllSymptoms.TabIndex = 2;
            this.lstAllSymptoms.DoubleClick += new System.EventHandler(this.lstAllSymptoms_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Symptoms you have";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "All Symptoms";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkSocial);
            this.groupBox4.Controls.Add(this.chkSanitize);
            this.groupBox4.Controls.Add(this.chkMasks);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(24, 422);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(583, 144);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Safety Questions";
            // 
            // chkSocial
            // 
            this.chkSocial.AutoSize = true;
            this.chkSocial.Location = new System.Drawing.Point(25, 100);
            this.chkSocial.Name = "chkSocial";
            this.chkSocial.Size = new System.Drawing.Size(271, 24);
            this.chkSocial.TabIndex = 2;
            this.chkSocial.Text = "Do you follow social distancing?";
            this.chkSocial.UseVisualStyleBackColor = true;
            // 
            // chkSanitize
            // 
            this.chkSanitize.AutoSize = true;
            this.chkSanitize.Location = new System.Drawing.Point(25, 69);
            this.chkSanitize.Name = "chkSanitize";
            this.chkSanitize.Size = new System.Drawing.Size(243, 24);
            this.chkSanitize.TabIndex = 1;
            this.chkSanitize.Text = "Do you sanitize your hands?";
            this.chkSanitize.UseVisualStyleBackColor = true;
            // 
            // chkMasks
            // 
            this.chkMasks.AutoSize = true;
            this.chkMasks.Location = new System.Drawing.Point(25, 38);
            this.chkMasks.Name = "chkMasks";
            this.chkMasks.Size = new System.Drawing.Size(255, 24);
            this.chkMasks.TabIndex = 0;
            this.chkMasks.Text = "Do you wear masks in public?";
            this.chkMasks.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(232, 580);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(169, 33);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit Details";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtRecommendation
            // 
            this.txtRecommendation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecommendation.Location = new System.Drawing.Point(24, 629);
            this.txtRecommendation.Name = "txtRecommendation";
            this.txtRecommendation.Size = new System.Drawing.Size(583, 166);
            this.txtRecommendation.TabIndex = 5;
            this.txtRecommendation.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 825);
            this.Controls.Add(this.txtRecommendation);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Covid19 Recommender System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcAge)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmcAge;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoNotVaccinated;
        private System.Windows.Forms.RadioButton rdoVaccinated;
        private System.Windows.Forms.ComboBox cmbVaccine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstAllSymptoms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstYourSymptoms;
        private System.Windows.Forms.CheckBox chkSocial;
        private System.Windows.Forms.CheckBox chkSanitize;
        private System.Windows.Forms.CheckBox chkMasks;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox txtRecommendation;
    }
}

