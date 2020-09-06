namespace BilgeAdam.Events
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
            this.components = new System.ComponentModel.Container();
            this.lstParents = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbMatch = new System.Windows.Forms.GroupBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSelectedBirthDate = new System.Windows.Forms.TextBox();
            this.txtSelectedParent = new System.Windows.Forms.TextBox();
            this.cmbSpouse = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctmListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxAddChild = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.grbMatch.SuspendLayout();
            this.ctmListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstParents
            // 
            this.lstParents.ContextMenuStrip = this.ctmListBox;
            this.lstParents.FormattingEnabled = true;
            this.lstParents.Location = new System.Drawing.Point(12, 12);
            this.lstParents.Name = "lstParents";
            this.lstParents.Size = new System.Drawing.Size(197, 342);
            this.lstParents.TabIndex = 0;
            this.lstParents.SelectedIndexChanged += new System.EventHandler(this.lstParents_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.dtpBirthDate);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(215, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kişi Tanımı";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(137, 69);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(53, 17);
            this.rdbMale.TabIndex = 5;
            this.rdbMale.Text = "Erkek";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Checked = true;
            this.rdbFemale.Location = new System.Drawing.Point(79, 69);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(52, 17);
            this.rdbFemale.TabIndex = 4;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Kadın";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(79, 43);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(197, 20);
            this.dtpBirthDate.TabIndex = 3;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(79, 17);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(197, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doğum Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı Soyadı";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(79, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grbMatch
            // 
            this.grbMatch.Controls.Add(this.btnMatch);
            this.grbMatch.Controls.Add(this.label5);
            this.grbMatch.Controls.Add(this.label4);
            this.grbMatch.Controls.Add(this.txtSelectedBirthDate);
            this.grbMatch.Controls.Add(this.txtSelectedParent);
            this.grbMatch.Controls.Add(this.cmbSpouse);
            this.grbMatch.Controls.Add(this.label3);
            this.grbMatch.Location = new System.Drawing.Point(215, 143);
            this.grbMatch.Name = "grbMatch";
            this.grbMatch.Size = new System.Drawing.Size(282, 145);
            this.grbMatch.TabIndex = 2;
            this.grbMatch.TabStop = false;
            this.grbMatch.Text = "Nikah Masası";
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(201, 100);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 23);
            this.btnMatch.TabIndex = 4;
            this.btnMatch.Text = "Eşleştir";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Doğum tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adı Soyadı";
            // 
            // txtSelectedBirthDate
            // 
            this.txtSelectedBirthDate.Location = new System.Drawing.Point(79, 46);
            this.txtSelectedBirthDate.Name = "txtSelectedBirthDate";
            this.txtSelectedBirthDate.ReadOnly = true;
            this.txtSelectedBirthDate.Size = new System.Drawing.Size(197, 20);
            this.txtSelectedBirthDate.TabIndex = 2;
            // 
            // txtSelectedParent
            // 
            this.txtSelectedParent.Location = new System.Drawing.Point(79, 20);
            this.txtSelectedParent.Name = "txtSelectedParent";
            this.txtSelectedParent.ReadOnly = true;
            this.txtSelectedParent.Size = new System.Drawing.Size(197, 20);
            this.txtSelectedParent.TabIndex = 2;
            // 
            // cmbSpouse
            // 
            this.cmbSpouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpouse.FormattingEnabled = true;
            this.cmbSpouse.Location = new System.Drawing.Point(79, 73);
            this.cmbSpouse.Name = "cmbSpouse";
            this.cmbSpouse.Size = new System.Drawing.Size(197, 21);
            this.cmbSpouse.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eş";
            // 
            // ctmListBox
            // 
            this.ctmListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxAddChild});
            this.ctmListBox.Name = "ctmListBox";
            this.ctmListBox.Size = new System.Drawing.Size(181, 48);
            // 
            // ctxAddChild
            // 
            this.ctxAddChild.Name = "ctxAddChild";
            this.ctxAddChild.Size = new System.Drawing.Size(180, 22);
            this.ctxAddChild.Text = "Çocuk Ekle";
            this.ctxAddChild.Click += new System.EventHandler(this.ctxAddChild_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 362);
            this.Controls.Add(this.grbMatch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstParents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Soy Ağacı";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbMatch.ResumeLayout(false);
            this.grbMatch.PerformLayout();
            this.ctmListBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstParents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbMatch;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSelectedParent;
        private System.Windows.Forms.ComboBox cmbSpouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSelectedBirthDate;
        private System.Windows.Forms.ContextMenuStrip ctmListBox;
        private System.Windows.Forms.ToolStripMenuItem ctxAddChild;
    }
}

