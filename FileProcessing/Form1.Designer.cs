
namespace FileProcessing
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadStudents = new System.Windows.Forms.Button();
            this.dgStudents = new System.Windows.Forms.DataGridView();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSelectData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowGrade = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnReadStudents
            // 
            this.btnReadStudents.Location = new System.Drawing.Point(13, 82);
            this.btnReadStudents.Name = "btnReadStudents";
            this.btnReadStudents.Size = new System.Drawing.Size(290, 46);
            this.btnReadStudents.TabIndex = 1;
            this.btnReadStudents.Text = "Read Students";
            this.btnReadStudents.UseVisualStyleBackColor = true;
            this.btnReadStudents.Click += new System.EventHandler(this.btnReadStudents_Click);
            // 
            // dgStudents
            // 
            this.dgStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudents.Location = new System.Drawing.Point(327, 58);
            this.dgStudents.Name = "dgStudents";
            this.dgStudents.RowHeadersWidth = 82;
            this.dgStudents.RowTemplate.Height = 41;
            this.dgStudents.Size = new System.Drawing.Size(1016, 548);
            this.dgStudents.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 164);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(291, 46);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSelectData,
            this.menuSaveData,
            this.menuAddStudent,
            this.menuShowGrade});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1386, 40);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuSelectData
            // 
            this.menuSelectData.AccessibleName = "menuSelectData";
            this.menuSelectData.Name = "menuSelectData";
            this.menuSelectData.Size = new System.Drawing.Size(154, 36);
            this.menuSelectData.Text = "Select Data";
            // 
            // menuSaveData
            // 
            this.menuSaveData.Name = "menuSaveData";
            this.menuSaveData.Size = new System.Drawing.Size(140, 36);
            this.menuSaveData.Text = "Save Data";
            this.menuSaveData.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // menuAddStudent
            // 
            this.menuAddStudent.Name = "menuAddStudent";
            this.menuAddStudent.Size = new System.Drawing.Size(167, 36);
            this.menuAddStudent.Text = "Add Student";
            // 
            // menuShowGrade
            // 
            this.menuShowGrade.Name = "menuShowGrade";
            this.menuShowGrade.Size = new System.Drawing.Size(162, 36);
            this.menuShowGrade.Text = "Show Grade";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 686);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.dgStudents);
            this.Controls.Add(this.btnReadStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgStudents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadStudents;
        private System.Windows.Forms.DataGridView dgStudents;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSelectData;
        private System.Windows.Forms.ToolStripMenuItem menuSaveData;
        private System.Windows.Forms.ToolStripMenuItem menuAddStudent;
        private System.Windows.Forms.ToolStripMenuItem menuShowGrade;
    }
}

