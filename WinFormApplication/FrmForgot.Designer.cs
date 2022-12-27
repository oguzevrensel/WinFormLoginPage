namespace WinFormApplication
{
    partial class FrmForgot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAnswer = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRepeatPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grp = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Güvenlik Sorusu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cevabı :";
            // 
            // TxtAnswer
            // 
            this.TxtAnswer.Location = new System.Drawing.Point(242, 114);
            this.TxtAnswer.Name = "TxtAnswer";
            this.TxtAnswer.Size = new System.Drawing.Size(125, 27);
            this.TxtAnswer.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(216, 34);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(125, 27);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(216, 125);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(125, 27);
            this.txtRepeatPassword.TabIndex = 5;
            this.txtRepeatPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yeni Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre Tekrar :";
            // 
            // grp
            // 
            this.grp.Controls.Add(this.btnSave);
            this.grp.Controls.Add(this.label3);
            this.grp.Controls.Add(this.label4);
            this.grp.Controls.Add(this.txtPassword);
            this.grp.Controls.Add(this.txtRepeatPassword);
            this.grp.Location = new System.Drawing.Point(42, 254);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(394, 245);
            this.grp.TabIndex = 8;
            this.grp.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(117, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 51);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Şifre Değiştir";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(145, 163);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(106, 41);
            this.btnControl.TabIndex = 9;
            this.btnControl.Text = "Kontrol Et";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(234, 50);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(0, 20);
            this.lblQuestion.TabIndex = 10;
            // 
            // FrmForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 528);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.TxtAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmForgot";
            this.Text = "FrmForgot";
            this.Load += new System.EventHandler(this.FrmForgot_Load);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtAnswer;
        private TextBox txtPassword;
        private TextBox txtRepeatPassword;
        private Label label3;
        private Label label4;
        private GroupBox grp;
        private Button btnControl;
        private Label lblQuestion;
        private Button btnSave;
    }
}